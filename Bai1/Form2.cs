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
    public partial class Form2 : Form
    {
        private Form1 _main;

        public Form2(Form1 main)
        {
            InitializeComponent();
            _main = main;
            _main.AddLog("Constructor");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _main.AddLog("Load");
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            _main.AddLog("Shown");
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            _main.AddLog("Activated");
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            _main.AddLog("Paint");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _main.AddLog("FormClosing");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.AddLog("FormClosed");
        }

    }
}
