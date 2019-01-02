using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW0201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redPanel_Click(object sender, EventArgs e)
        {
            labelWithColor.ForeColor = redPanel.BackColor;
        }

        private void yellowPanel_Click(object sender, EventArgs e)
        {
            labelWithColor.ForeColor = yellowPanel.BackColor;
        }

        private void olivePanel_Click(object sender, EventArgs e)
        {
            labelWithColor.ForeColor = olivePanel.BackColor;
        }

        private void bluePanel_Click(object sender, EventArgs e)
        {
            labelWithColor.ForeColor = bluePanel.BackColor;
        }

        private void purplePanel_Click_1(object sender, EventArgs e)
        {
            //labelWithColor.ForeColor = (sender as Panel).BackColor;

            labelWithColor.ForeColor = purplePanel.BackColor;
        }
    }
}
