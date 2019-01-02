using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targil5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jumpBtn_Click(object sender, EventArgs e)
        {
            int toY = Size.Height - smileyPic.Height - 20;

            int previousY = smileyPic.Location.Y;

            for (int i = smileyPic.Location.Y; i < toY; i = i + 5)
            {
                smileyPic.Location = new Point(smileyPic.Location.X, i);
                Thread.Sleep(1);
            }

            for (int i = smileyPic.Location.Y; i >= previousY; i = i - 5)
            {
                smileyPic.Location = new Point(smileyPic.Location.X, i);
                Thread.Sleep(1);
            }
        }
    }
}
