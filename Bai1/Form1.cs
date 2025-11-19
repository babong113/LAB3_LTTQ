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
            listView1.View = View.Details;
            listView1.Columns.Add("Các hoạt động", 400);
        }
        private Form2 f2;
        //nút tắt 
        private void btnOpen_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);    // truyền Form1 vào Form2
            f2.Show();
        }
        public void AddLog(string msg)
        {
            listView1.Items.Add(msg);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (f2 != null && !f2.IsDisposed)
            {
                f2.Close();   // tắt form 2
                AddLog("Form2 closed by Form1 button");
            }
            else
            {
                MessageBox.Show("Form 2 đang không mở!");
            }
        }
    }
}
