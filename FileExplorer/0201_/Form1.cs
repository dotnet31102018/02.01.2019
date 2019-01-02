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

namespace _0201_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.9.0", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frontColor_Click(object sender, EventArgs e)
        {
            if (myColorDialog.ShowDialog() == DialogResult.OK)
            {
                colorLabel.ForeColor = myColorDialog.Color;
            }
        }

        private void backColor_Click(object sender, EventArgs e)
        {
            if (myColorDialog.ShowDialog() == DialogResult.OK)
            {
                colorLabel.BackColor = myColorDialog.Color;
            }
        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            myOpenFileDialog.Title = "Choose an Image file";
            myOpenFileDialog.Filter = "Image files(*.jpg)| *.jpg";
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(myOpenFileDialog.FileName);
            }
        }

        private void loadTxtFileBtn_Click(object sender, EventArgs e)
        {
            myOpenFileDialog.Title = "Choose a text file";
            myOpenFileDialog.Filter = "Text files(*.txt)| *.txt";
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLines.Items.Clear();

                // Chinese

                var fileStream = new FileStream(myOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        fileLines.Items.Add(line);
                    }

                }
            }
        }
    }
}
