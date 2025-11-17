using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r=random.Next(0,256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color randomColor = Color.FromArgb(r, g, b);
            button1.BackColor = randomColor;
            this.BackColor = randomColor;
        }
    }
}
