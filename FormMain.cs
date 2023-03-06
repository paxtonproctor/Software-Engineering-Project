using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormMain : Form
    {
        readonly OpenFileDialog openFileDialog1 = new OpenFileDialog
        {

            InitialDirectory = @"D:\",
            Title = "Browse Text Files",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true,
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxProjectOpener.Items.Add(Path.GetFileName(openFileDialog1.FileName));
            };
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {

            //If a file is selected  
            var selectedFile = listBoxProjectOpener.SelectedItem as string;
            if (String.IsNullOrEmpty(selectedFile))
                return;

            //Open the file
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
