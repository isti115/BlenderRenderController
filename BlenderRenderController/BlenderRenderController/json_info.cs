using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderRenderController
{
    public partial class json_info : Form
    {
        string ScriptsPath;
        string jsonfile;

        public class BlenderData
        {
            public int StartFrame;
            public int EndFrame;
            public string OutputDirectory;
            public string ProjectName;
            public string NumScenes;
            public string ActiveScene;
        }

        public json_info()
        {
            InitializeComponent();

            string execPath = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            ScriptsPath = Path.Combine(Path.GetDirectoryName(execPath), "Scripts");
            jsonfile = Path.Combine(ScriptsPath, "blend_info.json");
        }

        private void debug_Load(object sender, EventArgs e)
        {
            
            if (!File.Exists(jsonfile))
            {
                textBox1.Text = "Json file not found!";
            }
            else
            {
                textBox1.Text = File.ReadAllText(jsonfile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!File.Exists(jsonfile))
            {
                return;
            }
            else
            {
                textBox1.Text = File.ReadAllText(jsonfile);
            }
            //textBox1.Text = File.ReadAllText(jsonfile);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
