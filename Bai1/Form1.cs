using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e) { MessageBox.Show("Load"); }
        private void Form1_Activated(object sender, EventArgs e) { MessageBox.Show("Activated"); }
        private void Form1_Deactivate(object sender, EventArgs e) { MessageBox.Show("Deactivated"); }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { MessageBox.Show("FormClosing"); }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) { MessageBox.Show("FormClosed"); }
        private void Form1_Resize(object sender, EventArgs e) { MessageBox.Show("Resize"); }
        private void Form1_Click(object sender, EventArgs e) { MessageBox.Show("Click"); }
        private void Form1_GotFocus(object sender, EventArgs e) { MessageBox.Show("GotFocus"); }
        
    }
}
