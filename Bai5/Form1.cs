using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Nút cộng 
        private void button1_Click(object sender, EventArgs e)
        {
            double n1= double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double sum = n1 + n2;
            textBox3.Text = sum.ToString();
        }


        //Nút trừ 
        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double sub = n1 - n2;
            textBox3.Text = sub.ToString();
        }

        //nút nhân 
        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double mul = n1 * n2;
            textBox3.Text = mul.ToString();
        }

        //nút chia 
        private void button3_Click(object sender, EventArgs e)
        {

            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            if(n2==0)
            {
                MessageBox.Show("Mẫu số không được bằng 0 vui lòng nhập lại number 2");
                    return;
            }    
            double dev = n1 / n2;
            textBox3.Text = dev.ToString();
        }


        //Phần Xử lí các kí tự chữ không được nhập
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar == '-')
            {
                if (tb.SelectionStart != 0 || tb.Text.Contains("-"))
                    e.Handled = true;
                return; 
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && tb.Text.Contains("."))
                e.Handled = true;
            
        }
    }
}
