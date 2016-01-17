using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderRenderController
{
    public partial class MainForm : Form
    {
        string blendFilePath = "";
        string outFolderPath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void renderButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.WorkingDirectory = outFolderPath;
            p.StartInfo.FileName = "blender";

            p.StartInfo.Arguments = String.Format("-b \"{0}\" -E {1} -s {2} -e {3} -a",
                                                  blendFilePathTextBox.Text,
                                                  rendererComboBox.Text, 
                                                  startFrameNumericUpDown.Value, 
                                                  endFrameNumericUpDown.Value);

            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(chunk_Finished);

            p.Start();
        }

        private void chunk_Finished(object sender, EventArgs e)
        {
            MessageBox.Show("finished");
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
            endFrameNumericUpDown.Value = startFrameNumericUpDown.Value + difference;
        }
    }
}
