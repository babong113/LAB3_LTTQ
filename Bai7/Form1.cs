using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class QLBV : Form
    {
        public QLBV()
        {
            InitializeComponent();
        }

        private int HangA = 0;
        private int HangB = 0;
        private int HangC = 0;
        long Sum = 0;
       
        // Tính tiền tổng thể
        private void TinhTien(int HangA,int HangB, int HangC)
        {
            Sum = HangA * 5000 + HangB * 6500 + HangC * 8000;
        }
        //Number 1


        //Nút hủy bỏ
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is Button btn && btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                }
            }
            textBox2.Text = "0";
            HangA = 0;
            HangB = 0;
            HangC = 0;
        }


        //Nút chọn
        private void btn_Choose_Click(object sender, EventArgs e)
        {
            TinhTien(HangA, HangB,HangC);
            textBox2.Text=Sum.ToString();
            foreach(Control ctr in this.Controls)
            {
                if (ctr is Button bth && bth.BackColor == Color.Blue)
                    bth.BackColor = Color.Yellow;
            }
            HangA = HangB = HangC = 0;
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Close();
        }


        // 1 hàm dùng cho 15 nút chọn ghế ngồi
        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string row = btn.Tag.ToString();

            // Nếu ghế đã bán
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí đã được bán!");
                return;
            }

            // Nếu ghế đang trắng → chọn (xanh)
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;

                if (row == "A") HangA++;
                else if (row == "B") HangB++;
                else if (row == "C") HangC++;
            }
            // Nếu ghế đang xanh → bỏ chọn
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;

                if (row == "A") HangA--;
                else if (row == "B") HangB--;
                else if (row == "C") HangC--;
            }
        }
    }
}
