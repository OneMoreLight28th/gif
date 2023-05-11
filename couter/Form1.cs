using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace couter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index >= this.imageList1.Images.Count)
                index = 0;
            this.pictureBox1.Image = this.imageList1.Images[index];
            index++;
        }
    }
}
