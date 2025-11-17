using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string truoc = "";
        string dau = "";
        String sau= "";
        string MS = "";
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Số 0
        private void button27_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 0;
                See.Text = truoc;
            }
            else
            {
                sau += 0;
                See.Text = sau;
            }
        }

        // Số 1
        private void button22_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 1;
                See.Text = truoc;
            }
            else
            {
                sau += 1;
                See.Text = sau;
            }
        }
        
        // Số 2
        private void button21_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 2;
                See.Text = truoc;
            }
            else
            {
                sau += 2;
                See.Text = sau;
            }
        }

        // Số 3
        private void button20_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 3;
                See.Text = truoc;
            }
            else
            {
                sau += 3;
                See.Text = sau;
            }
        }

        // Số 4
        private void button17_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 4;
                See.Text = truoc;
            }
            else
            {
                sau += 4;
                See.Text = sau;
            }
        }

        // Số 5
        private void button16_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 5;
                See.Text = truoc;
            }
            else
            {
                sau += 5;
                See.Text = sau;
            }
        }

        // Số 6
        private void button15_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 6;
                See.Text = truoc;
            }
            else
            {
                sau += 6;
                See.Text = sau;
            }
        }

        // Số 7
        private void button8_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 7;
                See.Text = truoc;
            }
            else
            {
                sau += 7;
                See.Text = sau;
            }    
        }

        // Số 8
        private void button9_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 8;
                See.Text = truoc;
            }
            else
            {
                sau += 8;
                See.Text = sau;
            }
        }

        // Số 9
        private void button10_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += 9;
                See.Text = truoc;
            }
            else
            {
                sau += 9;
                See.Text = sau;
            }
        }

        //Phép chia
        private void button11_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                dau = "/";
                See.Text = "/";
            }
            else
            {
                Equal_Click(sender, e);
                dau = "/";
                See.Text = "/";
            }
        }

        //Phép nhân
        private void button14_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                dau = "*";
                See.Text = "*";
            }
            else
            {
                Equal_Click(sender, e);
                dau = "*";
                See.Text = "*";
            }
        }

        //Phép trừ
        private void button19_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                dau = "-";
                See.Text = "-";
            }
            else
            {
                Equal_Click(sender, e);
                dau = "-";
                See.Text = "-";
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {

        }

        //Phép cộng
        private void button24_Click(object sender, EventArgs e)
        {
            if(dau=="")
            {
                dau = "+";
                See.Text = "+";
            }
            else
            {

                Equal_Click(sender, e);
                dau = "+";
                See.Text = "+";
            } 
                
        }

        //Dấu bằng
        private void Equal_Click(object sender, EventArgs e)
        {
            double n1, n2, kq = 0;
            double.TryParse(truoc, out n1);
            double.TryParse(sau, out n2);
            switch (dau)
            {
                case "+":
                    kq = n1 + n2;
                    break;
                case "/":
                    kq = n1 / n2;
                    break;
                case "*":
                    kq = n1 * n2;
                    break;
                case "-":
                    kq = n1 - n2;
                    break;
                default:
                    return;
            }
            See.Text = kq.ToString();
            MS = kq.ToString();
            truoc = kq.ToString();
            sau = "";
            
        }

        // dấu chấm phần thập phân
        private void Dot_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc += ".";
                See.Text = truoc;
            }
            else
            {
                sau += ".";
                See.Text = sau;
            }
        }

        // xóa số hiện tại
        private void CE_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc = "";
                See.Text = truoc;
            }
            else
            {
                sau = "";
                See.Text = sau;
            }
        }

        //chức năng xóa tất cả kể cả bộ nhớ
        private void C_Click(object sender, EventArgs e)
        {
            truoc = "";
            sau = "";
            dau = "";
            See.Text = "0.";
        }

        // Chức năng căn bậc hai
        private void button12_Click(object sender, EventArgs e)
        {

            if (dau == "")
            {
                truoc =Math.Sqrt(double.Parse(truoc)).ToString();
                See.Text = truoc;
            }
            else
            {
                sau = Math.Sqrt(double.Parse(sau)).ToString();
                See.Text = sau;
            }
        }

        //Chức năng phần trăm
        private void button13_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                See.Text = truoc+"%";
                truoc =  (double.Parse(truoc)/100).ToString();
                
            }
            else
            {
                See.Text = sau+"%";
                sau = (double.Parse(truoc) / 100).ToString();

            }
        }

        //Chắc năng 1 phần của số
        private void button18_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc = (1.0 / double.Parse(truoc)).ToString();
                See.Text = truoc;
            }
            else
            {
                sau = (1.0 / double.Parse(sau)).ToString();
                See.Text = sau;
            }
        }

        //Chức năng xóa ký tự cuối cùng
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                truoc = truoc.Substring(0, truoc.Length - 1);
                See.Text = truoc;
            }
            else
            {
                sau = sau.Substring(0, sau.Length - 1);
                See.Text = sau;
            }
        }

        // Nút đổi dấu của số
        private void button26_Click(object sender, EventArgs e)
        {
            if (dau == "")
            {
                if (double.Parse(truoc) > 0)
                    truoc = "-" + truoc;
                else
                    truoc = truoc.Substring(1);
                See.Text = truoc;
            }
            else
            {
                if (double.Parse(sau) > 0)
                    sau = "-" + sau;
                else
                    sau = sau.Substring(1);
                See.Text = sau;
            }
        }

        // Chức năng MC xóa bộ nhớ
        private void MC_Click(object sender, EventArgs e)
        {
            MS = "";
        }

        // Chức năng M+ cộng giá trị hiện tại vào bộ nhớ
        private void MPlus_Click(object sender, EventArgs e)
        {
            truoc = MS;
            dau = "+";
            MS = (double.Parse(MS) + double.Parse(sau)).ToString();
        }

        // Chức năng in bộ nhớ ra màn hình
        private void MR_Click(object sender, EventArgs e)
        {
            See.Text = MS;
        }

        // Chức năng MS lưu giá trị hiện tại vào bộ nhớ
        private void MSS_Click(object sender, EventArgs e)
        {
            MS = truoc;
            dau = "?";
        }
    }
}
