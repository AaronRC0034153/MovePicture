using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovePicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X - 5, man.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X, man.Location.Y + 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X, man.Location.Y - 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X + 5, man.Location.Y);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                man.Location = new Point(man.Location.X + 2, man.Location.Y);
                await Task.Delay(20);

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X - 5, man.Location.Y - 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X + 5, man.Location.Y - 5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X - 5, man.Location.Y + 5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            man.Location = new Point(man.Location.X + 5, man.Location.Y + 5);
        }
    }
}
