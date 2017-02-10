using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web.Script.Serialization;

namespace BlenderRenderController
{

    public partial class MainForm : Form
    {
        string   blendFilePath;
        string   outFolderPath;
		string   blendProjectName = "concat_output.mp4";
		DateTime startTime        = DateTime.MaxValue;

		string ScriptsPath;

        Timer renderAllTimer;
        int runningRenderProcessCount;

        int ErrorCode;
        string AltDir;
        // Lenth of segments, TEST
        int SeqFrame = 1000;

        public class BlenderData {
			public int    StartFrame;
			public int    EndFrame;
			public string OutputDirectory;
			public string ProjectName;
            // new
            public string NumScenes;
            public string ActiveScene;
            public string AltDir;
            public int ErrorCode;
            //public int SegFrame = 1000;
        }


        string[] args = Environment.GetCommandLineArgs();


        public MainForm()
        {
            InitializeComponent();

			//string execPath = Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().CodeBase );
			string execPath = new Uri( System.Reflection.Assembly.GetExecutingAssembly().CodeBase ).LocalPath;

			ScriptsPath = Path.Combine( Path.GetDirectoryName( execPath ), "Scripts" );
			Trace.WriteLine( String.Format( "Scripts Path: '{0}'", ScriptsPath ) );

        }

        // Deletes json on form close
        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            jsonDel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Arguments
            if (args.Length > 1)
            {
                //test arguments
                //for (int i = 0; i < args.Length; i++)
                //{
                //    string teste = string.Format("Arg[{0}] = [{1}] \r\n", i, args[i]);
                //    MessageBox.Show(teste);
                //}

                // arg 1 = .blend path
                blendFilePath = args[1];
                blendFilePathTextBox.Text = blendFilePath;
                DoReadBlenderData();
            }

            blendFilePath = "";
            outFolderPath = "";

            renderAllTimer = new Timer();
            renderAllTimer.Interval = 2500;
            renderAllTimer.Tick += new EventHandler(updateProcessManagement);

            runningRenderProcessCount = 0;
        }

        private void blendFileBrowseButton_Click(object sender, EventArgs e)
        {
            var blendFileBrowseDialog = new OpenFileDialog();
            blendFileBrowseDialog.Filter = "Blend|*.blend";

            var result = blendFileBrowseDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                blendFilePath             = blendFileBrowseDialog.FileName;
                blendFilePathTextBox.Text = blendFilePath;
				DoReadBlenderData();
            }

        }

        private void partsFolderBrowseButton_Click(object sender, EventArgs e)
        {
            var partsFolderBrowseDialog = new FolderBrowserDialog();
            //outFileBrowseDialog.Filter = "Blend|*.blend";

            var result = partsFolderBrowseDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                outFolderPath = partsFolderBrowseDialog.SelectedPath;
                partsFolderPathTextBox.Text = outFolderPath;
            }
        }

        private void outFolderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            outFolderPath = partsFolderPathTextBox.Text;
        }

        private void renderSegmentButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.WorkingDirectory = outFolderPath;
            p.StartInfo.FileName = "blender";
			p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            //p.StartInfo.Arguments = String.Format("-b \"{0}\" -E {1} -s {2} -e {3} {4} -a ",
            p.StartInfo.Arguments = String.Format("-b \"{0}\" -E {1} -s {2} -e {3} -a ",
                                                  blendFilePathTextBox.Text,
                                                  rendererComboBox.Text,
                                                  startFrameNumericUpDown.Value, 
                                                  endFrameNumericUpDown.Value
												  );

			Trace.WriteLine( String.Format( "CEW: {0}", p.StartInfo.Arguments ) );

            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(chunk_Finished);

            p.Start();
            runningRenderProcessCount++;

        }

        private void chunk_Finished(object sender, EventArgs e)
        {
            runningRenderProcessCount--;
        }

        private void prevChunkButton_Click(object sender, EventArgs e)
        {
            var difference = endFrameNumericUpDown.Value - startFrameNumericUpDown.Value;
            //difference = SegFrame;
            //var step =  endFrameNumericUpDown.Value = startFrameNumericUpDown.Value + SegFrame;
            if (startFrameNumericUpDown.Value - difference < 1)
            {
                startFrameNumericUpDown.Value = 1;
                endFrameNumericUpDown.Value = 1 + difference;
            }
            else
            {
                endFrameNumericUpDown.Value = startFrameNumericUpDown.Value - 1;
                startFrameNumericUpDown.Value = endFrameNumericUpDown.Value - difference;
            }

        }

        private void nextChunkButton_Click(object sender, EventArgs e)
        {
            var difference = endFrameNumericUpDown.Value - startFrameNumericUpDown.Value;
            startFrameNumericUpDown.Value = endFrameNumericUpDown.Value + 1;

            if (endFrameNumericUpDown.Value + difference + 1 > totalFrameCountNumericUpDown.Value)
            {
                endFrameNumericUpDown.Value = totalFrameCountNumericUpDown.Value;
            }
            else
            {
                endFrameNumericUpDown.Value = startFrameNumericUpDown.Value + difference;
            }

        }

        private void renderAllButton_Click(object sender, EventArgs e)
        {
			//Becuase "clever" coding before us
			if( startTime == DateTime.MaxValue ) {
				//First time, set start time
				startTime = DateTime.Now;
				TotalTime.Text = "Total Time: 00:00:00";
			}
			else {
				//Stopping whether finished or user intervention so show time run
				TimeSpan runTime = DateTime.Now - startTime;
				TotalTime.Text = String.Format( "Total Time: {0,2:D2}:{1,2:D2}:{2,2:D2}", (int)runTime.TotalHours, runTime.Minutes, runTime.Seconds );
				startTime = DateTime.MaxValue;
			}

            renderAllTimer.Enabled = !renderAllTimer.Enabled;
            renderAllButton.Text   = renderAllTimer.Enabled ? "Stop" : "Render all";
        }

        private void updateProcessManagement(object sender, EventArgs e)
        {

            if (!(startFrameNumericUpDown.Value < totalFrameCountNumericUpDown.Value))
            {
                renderAllButton_Click(sender, e);
                return;
            }

            renderProgressBar.Value = (int)((endFrameNumericUpDown.Value / totalFrameCountNumericUpDown.Value) * 100);

			TimeSpan runTime = DateTime.Now - startTime;
			TotalTime.Text = String.Format( "Total Time: {0,2:D2}:{1,2:D2}:{2,2:D2}", (int)runTime.TotalHours, runTime.Minutes, runTime.Seconds );

            if (runningRenderProcessCount < processCountNumericUpDown.Value)
            {
                renderSegmentButton_Click(null, EventArgs.Empty);
                nextChunkButton_Click(null, EventArgs.Empty);
            }

        }

		private List<string> findFiles( string folderPath, string fileSearch )
		{
            string[] partList   = Directory.GetFiles(folderPath, fileSearch);
			Regex    filePatern = new Regex( @"\d+-\d+" + Path.GetExtension(fileSearch) );

            return partList.Where( file => filePatern.IsMatch( file ) ).ToList();

		}

        private void concatenatePartsButton_Click(object sender, EventArgs e)
        {
            string ffmpeg_dir;
            if (ajustOutDir.Checked == true)
            {
                ffmpeg_dir = AltDir;
            }
            else
            {
                ffmpeg_dir = outFolderPath;
            }
            if (!Directory.Exists(ffmpeg_dir))
            {
                errorMsgs(-100);
                return;
            }

            StreamWriter partListWriter = new StreamWriter(ffmpeg_dir + "\\partList.txt");
            List<string> stringPartList = findFiles(ffmpeg_dir, "*.avi");
            string fileExtension = "avi";
            string audioFile = Path.GetFileNameWithoutExtension(blendFilePathTextBox.Text);
            string audioSettings = string.Empty;//"-c:a aac -b:a 256k";

            if (stringPartList == null || stringPartList.Count == 0)
            {
                stringPartList = findFiles(ffmpeg_dir, "*.mp4");
                fileExtension = "mp4";
            }

            if (File.Exists(Path.Combine(ffmpeg_dir, audioFile + ".ac3")))
            {
                audioFile = " -i " + audioFile + ".ac3";
            }
            else
            {
                audioFile = string.Empty;
                audioSettings = string.Empty;
            }

            stringPartList.Sort(compareParts);

            foreach (var currentPart in stringPartList)
            {
                partListWriter.WriteLine("file '{0}'", Path.GetFileName(currentPart));
            }

            partListWriter.Close();


            Process p = new Process();
            
            p.StartInfo.WorkingDirectory = ffmpeg_dir;
            //p.StartInfo.WorkingDirectory = AltDir;
            p.StartInfo.FileName = "ffmpeg";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            p.StartInfo.Arguments = String.Format("-f concat -i partList.txt {0} -c:v copy {1} concat_output.{2}",
                                                   audioFile,
                                                   audioSettings,
                                                   fileExtension
                                    );

            p.Start();

        }

        public int compareParts(string a, string b)
        {
            Regex pattern = new Regex(@"-(.*)\.(mp4|avi)");

            int aEnd = Convert.ToInt32(pattern.Match(a).Groups[1].Value);
            int bEnd = Convert.ToInt32(pattern.Match(b).Groups[1].Value);

            return aEnd.CompareTo(bEnd);
        }

		private void DoReadBlenderData() {

            if ( !File.Exists( blendFilePathTextBox.Text ) ) {
                // file does not exist
                errorMsgs(-104);
                return;
			}

            if (!Directory.Exists(ScriptsPath))
            {
                // Error scriptsfolder not found
                string caption = "Error";
                string message = "Scripts folder not found";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process p = new Process();
            //p.StartInfo.WorkingDirectory     = outFolderPath;
            p.StartInfo.WorkingDirectory       = ScriptsPath;
            p.StartInfo.FileName               = "blender";
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.CreateNoWindow         = true;
			p.StartInfo.UseShellExecute        = false;

            p.StartInfo.Arguments = String.Format("-b \"{0}\" -P \"{1}\"",
                                                  blendFilePathTextBox.Text,
                                                  Path.Combine(ScriptsPath, "get_project_info.py")
                                    );

			try {
				p.Start();
			}
			catch( Exception ex ) {
				Trace.WriteLine( ex );
			}
            
			StringBuilder jsonInfo    = new StringBuilder();
			bool          jsonStarted = false;
			int           curlyStack  = 0;

            while ( !p.StandardOutput.EndOfStream ) {
				string line = p.StandardOutput.ReadLine();

				if( line.Contains( "{" ) ) {
					jsonStarted = true;
					curlyStack++;
				}

				if( jsonStarted ) {

					if( !line.ToLower().Contains( "blender quit" ) && curlyStack > 0 ) {
						jsonInfo.AppendLine( line );
					}

					if( line.Contains( "}" ) ) {

						curlyStack--;

						if( curlyStack == 0 ) {
							jsonStarted = false;
						}

					}

				}

			}

			BlenderData blendData = null;
			if( jsonInfo.Length > 0 ) { 
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				blendData = serializer.Deserialize<BlenderData>( jsonInfo.ToString() );
			}

			if( blendData != null ) {

                startFrameNumericUpDown.Value      = blendData.StartFrame;
				totalFrameCountNumericUpDown.Value = blendData.EndFrame;

                //endFrameNumericUpDown.Value = startFrameNumericUpDown.Value + endFrameNumericUpDown.Value;

                // Remove last bit from file path, if checked
                if (ajustOutDir.Checked == true)
                {
                    partsFolderPathTextBox.Text = blendData.AltDir;
                }
                else
                {
                    partsFolderPathTextBox.Text = outFolderPath = blendData.OutputDirectory;
                }

                outFolderPathTextBox.Text          = outFolderPath = blendData.OutputDirectory;
                infoActiveScene.Text               = blendData.ActiveScene;
                infoNoScenes.Text                  = blendData.NumScenes;
                AltDir                             = blendData.AltDir;
                ErrorCode                          = blendData.ErrorCode;
                //blendProjectName                   = blendData.ProjectName;

                if ( blendData.EndFrame < endFrameNumericUpDown.Value ) {
					endFrameNumericUpDown.Value = blendData.EndFrame;
				}

			}
            // Error checker
            errorMsgs(ErrorCode);

            //outFolderPathTextBox.Text = string.Empty;

            Trace.WriteLine( "Json data = " + jsonInfo.ToString() );

			//Trace.WriteLine( String.Format( "CEW: {0}", p.StartInfo.Arguments ) );

		}

        /// <summary>
        /// Error central, displays message and does actions
        /// according to given code, return's int equal to 
        /// error code
        /// </summary>
        /// <param name="er"></param>
        /// <returns>same as er</returns>
        int errorMsgs(int er)
        {
            int input = er;

            // Actions

            // disable buttons if invalid
            var invalid_list = new List<int> { -1, -2, -3, -104 };
            var isbad = invalid_list.Contains(input);
            if (isbad == true)
            {
                renderAllButton.Enabled = false;
                renderSegmentButton.Enabled = false;
                concatenatePartsButton.Enabled = false;
                MixdownAudio.Enabled = false;
            }
            else
            {
                renderAllButton.Enabled = true;
                renderSegmentButton.Enabled = true;
                concatenatePartsButton.Enabled = true;
                MixdownAudio.Enabled = true;
            }

            // Messages
            string message;
            string caption = string.Format("Error ({0})", input);

            if (input == -1)
            {
                message = "Output file path empty, please set a valid path in project";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (input == -2)
            {
                message = "Invalid Output path";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -2;
            }
            else if (input == -3)
            {
                message = "Output path is relative, you MUST use absolute paths ONLY";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -3;
            }
            else if (input == -100)
            {
                message = "FFmpeg can't find working folder";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -100;
            }
            else if (input == -104)
            {
                message = "Invalid project";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -104;
            }
            else
            {
                // no problems, don't show error message
                return 0;
            }
            
        }

		private void ReadBlenderData_Click( object sender, EventArgs e ) {

            DoReadBlenderData();
		}

        private void MixdownAudio_Click(object sender, EventArgs e) {

            if (!File.Exists(blendFilePathTextBox.Text)) {
                return;
            }

            if (!Directory.Exists(ScriptsPath))
            {
                // Error scriptsfolder not found
                string caption = "Error";
                string message = "Scripts folder not found. Separate audio mixdown and automatic project info detection will not work, but you can still use the basic rendering functionality.";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (!Directory.Exists(partsFolderPathTextBox.Text)) {
                Directory.CreateDirectory(partsFolderPathTextBox.Text);
            }

            Process p = new Process();

            p.StartInfo.FileName = "blender";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            //Using minimized instead so we get feedback
            //p.StartInfo.CreateNoWindow         = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            p.StartInfo.Arguments = String.Format("-b \"{0}\" -P \"{1}\"",
                                                  blendFilePathTextBox.Text,
                                                  Path.Combine(ScriptsPath, "mixdown_audio.py")
                                    );

            p.Start();

            p.WaitForExit((int)TimeSpan.FromMinutes(5).TotalMilliseconds);

            Trace.WriteLine("MixDown Completed");


        }

        /* About this app
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        */

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show / hide tooltips
            if (tipsToolStripMenuItem.Checked == false)
            {
                activeWarn.Active = false;
                toolTip1.Active = false;
                //toolTip.Active = false;
            }
            else if (tipsToolStripMenuItem.Checked == true)
            {
                activeWarn.Active = true;
                toolTip1.Active = true;
            }

        }
        
        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            json_info op = new json_info();
            op.Show();
        }

        private void ajustOutDir_CheckedChanged(object sender, EventArgs e)
        {
            DoReadBlenderData();
        }

        // DEBUG OPTIONS
        private void debugMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (debugShow.Checked == false)
            {
                debugToolStripMenuItem.Visible = false;
            }
            else if (debugShow.Checked == true)
            {
                debugToolStripMenuItem.Visible = true;
            }
        }

        void jsonDel()
        {
            // delete json
            string jsonfile = Path.Combine(ScriptsPath, "blend_info.json");
            if (File.Exists(jsonfile))
            {
                File.Delete(jsonfile);
                //MessageBox.Show("Json deleted", "Ok");
            }
            else
            {
                //MessageBox.Show("Json not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void deleteJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonDel();
        }

        private void endFrameNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isti115ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Isti115/BlenderRenderController");
        }

        private void meTwentyFiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MeTwentyFive/BlenderRenderController");
        }

        private void redRaptor93ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RedRaptor93/BlenderRenderController");
        }
    }
}
