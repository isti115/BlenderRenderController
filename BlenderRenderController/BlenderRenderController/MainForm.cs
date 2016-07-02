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

		public class BlenderData {
			public int    StartFrame;
			public int    EndFrame;
			public string OutputDirectory;
			public string ProjectName;
		}

        public MainForm()
        {
            InitializeComponent();

			//string execPath = Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().CodeBase );
			string execPath = new Uri( System.Reflection.Assembly.GetExecutingAssembly().CodeBase ).LocalPath;

			ScriptsPath = Path.Combine( Path.GetDirectoryName( execPath ), "Scripts" );
			Trace.WriteLine( String.Format( "Scripts Path: '{0}'", ScriptsPath ) );

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

        private void outFolderBrowseButton_Click(object sender, EventArgs e)
        {
            var outFolderBrowseDialog = new FolderBrowserDialog();
            //outFileBrowseDialog.Filter = "Blend|*.blend";

            var result = outFolderBrowseDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                outFolderPath = outFolderBrowseDialog.SelectedPath;
                outFolderPathTextBox.Text = outFolderPath;
            }

        }

        private void outFolderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            outFolderPath = outFolderPathTextBox.Text;
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
            StreamWriter partListWriter = new StreamWriter(outFolderPath + "\\partList.txt");
			string       fileExtension  = "mp4";
			List<string> stringPartList = findFiles( outFolderPath, "*.mp4" );
			string       audioFile      = Path.GetFileNameWithoutExtension( blendFilePathTextBox.Text );
			string       audioSettings  = string.Empty;//"-c:a aac -b:a 256k";

			//Fall back to seraching for .avi files instead
			if( stringPartList == null || stringPartList.Count == 0 ) {
				stringPartList = findFiles( outFolderPath, "*.avi" );
				fileExtension = "avi";
			}

			if( File.Exists( Path.Combine( outFolderPath, audioFile + ".ac3" ) ) ) {
				audioFile = " -i " + audioFile + ".ac3";
			}
			else {
				audioFile     = string.Empty;
				audioSettings = string.Empty;
			}

            stringPartList.Sort(compareParts);

            foreach (var currentPart in stringPartList)
            {
                partListWriter.WriteLine("file '{0}'", Path.GetFileName( currentPart ) );
            }

            partListWriter.Close();


            Process p = new Process();

            p.StartInfo.WorkingDirectory = outFolderPath;
            p.StartInfo.FileName = "ffmpeg";
			p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

			p.StartInfo.Arguments = String.Format( "-f concat -i partList.txt {0} -c:v copy {1} concat_output.{2}",
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

			if( !File.Exists( blendFilePathTextBox.Text ) ) {
				return;
			}

            Process p = new Process();

            //p.StartInfo.WorkingDirectory     = outFolderPath;

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

			while( !p.StandardOutput.EndOfStream ) {
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
				outFolderPathTextBox.Text          = outFolderPath = blendData.OutputDirectory;
				//blendProjectName                   = blendData.ProjectName;

				if( blendData.EndFrame < endFrameNumericUpDown.Value ) {
					endFrameNumericUpDown.Value = blendData.EndFrame;
				}

			}

			Trace.WriteLine( "Json data = " + jsonInfo.ToString() );

			//Trace.WriteLine( String.Format( "CEW: {0}", p.StartInfo.Arguments ) );

		}

		private void ReadBlenderData_Click( object sender, EventArgs e ) {
			DoReadBlenderData();
		}

		private void MixdownAudio_Click( object sender, EventArgs e ) {

			if( !File.Exists( blendFilePathTextBox.Text ) ) {
				return;
			}

			if( !Directory.Exists( outFolderPathTextBox.Text ) ) {
				Directory.CreateDirectory( outFolderPathTextBox.Text );
			}

            Process p = new Process();

            p.StartInfo.FileName               = "blender";
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.UseShellExecute        = false;
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

    }

}
