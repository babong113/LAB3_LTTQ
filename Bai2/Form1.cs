using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        //hàm vẽ random
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            // Random vị trí
            int x = rand.Next(0, this.ClientSize.Width - 100);
            int y = rand.Next(0, this.ClientSize.Height - 30);

            // Random màu
            int r = rand.Next(0, 256);
            int gColor = rand.Next(0, 256);
            int b = rand.Next(0, 256);
            int size=rand.Next(10, 50);
            Brush brush = new SolidBrush(Color.FromArgb(r, gColor, b));

            g.DrawString("Paint Event",
                         new Font("Arial", size, FontStyle.Bold),
                         brush,
                         x, y);
        }


        //paint click gọi lại hàm paint ở trên
        private void btnPaint_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
