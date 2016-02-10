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

namespace BlenderRenderController
{
    public partial class MainForm : Form
    {
        string blendFilePath;
        string outFolderPath;

        Timer renderAllTimer;
        int runningRenderProcessCount;

        public MainForm()
        {
            InitializeComponent();
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

            if (result == DialogResult.OK)
            {
                blendFilePath = blendFileBrowseDialog.FileName;
                blendFilePathTextBox.Text = blendFilePath;
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

            p.StartInfo.Arguments = String.Format("-b \"{0}\" -E {1} -s {2} -e {3} -a",
                                                  blendFilePathTextBox.Text,
                                                  rendererComboBox.Text,
                                                  //"BLENDER_RENDER",
                                                  startFrameNumericUpDown.Value, 
                                                  endFrameNumericUpDown.Value);

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
            renderAllTimer.Enabled = !renderAllTimer.Enabled;
            renderAllButton.Text = renderAllTimer.Enabled ? "Stop" : "Render all";
        }

        private void updateProcessManagement(object sender, EventArgs e)
        {
            if (!(startFrameNumericUpDown.Value < totalFrameCountNumericUpDown.Value))
            {
                renderAllButton_Click(sender, e);
                return;
            }

            renderProgressBar.Value = (int)((endFrameNumericUpDown.Value / totalFrameCountNumericUpDown.Value) * 100);

            if (runningRenderProcessCount < processCountNumericUpDown.Value)
            {
                renderSegmentButton_Click(null, EventArgs.Empty);
                nextChunkButton_Click(null, EventArgs.Empty);
            }
        }

        private void concatenatePartsButton_Click(object sender, EventArgs e)
        {
            string[] partList = Directory.GetFiles(outFolderPath, "*.mp4");
            StreamWriter partListWriter = new StreamWriter(outFolderPath + "\\partList.txt");

            List<string> stringPartList = partList.ToList();

            stringPartList.Sort(compareParts);

            foreach (var currentPart in stringPartList)
            {
                partListWriter.WriteLine("file '{0}'", currentPart);
            }

            partListWriter.Close();


            Process p = new Process();

            p.StartInfo.WorkingDirectory = outFolderPath;
            p.StartInfo.FileName = "ffmpeg";

            p.StartInfo.Arguments = "-f concat -i partList.txt -c copy ../output.mp4";
            
            p.Start();
        }

        public int compareParts(string a, string b)
        {
            Regex pattern = new Regex(@"-(.*)\.mp4");

            int aEnd = Convert.ToInt32(pattern.Match(a).Groups[1].Value);
            int bEnd = Convert.ToInt32(pattern.Match(b).Groups[1].Value);

            return aEnd.CompareTo(bEnd);
        }
    }
}
