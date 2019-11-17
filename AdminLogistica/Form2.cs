using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdminLogistica
{
    public partial class FormLote : Form
    {
        public FormLote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach(string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(dir);
                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
