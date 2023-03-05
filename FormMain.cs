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
        OpenFileDialog openFileDialog1 = new OpenFileDialog
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

            //while(listBoxProjectOpener.SelectedItem.ToString() != null)
            //{
            //    listBoxOutput.Items.Add(openFileDialog1.OpenFile());
            //}
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
