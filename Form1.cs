using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(250, 100);
            button2.Size = new Size(50, 50);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button3.Location = new Point(170, 300);
            button3.Size = new Size(40, 70);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button4.Location = new Point(120, 60);
            button4.Size = new Size(25, 15);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(140, 210);
            button1.Size = new Size(104, 59);
        }
    }
}
