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

namespace txtEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\txtEdit", rtbUpis.Text);
        }

        private void btnSaveas_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            rtbUpis.SaveFile(saveFileDialog1.FileName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbUpis.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            rtbUpis.Text =    
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbUpis.Clear();
        }
    }
}
