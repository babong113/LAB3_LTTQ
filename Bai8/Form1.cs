using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class FQLTK : Form
    {
        public FQLTK()
        {
            InitializeComponent();
        }
        int stt = 0;
        //Kiem tra nhap tat ca o chua
        private bool KiemTraNhap()
        {
            if (tbSTK.Text == "" || tbTen.Text == "" || tbDiaChi.Text == "" || tbSoTien.Text == "")
                return false;
            return true;
        }

        //Tim khac hang theo stk
        private ListViewItem TimTheoSTK(string stk)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == stk)
                    return item;
            }
            return null;
        }

        //Tổng tiền
        private void TinhTongTien()
        {
            long tong = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                tong += long.Parse(item.SubItems[4].Text);
            }

            tbTongTien.Text = tong.ToString(); 
        }

        //listview
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];

            tbSTK.Text = item.SubItems[1].Text;
            tbTen.Text = item.SubItems[2].Text;
            tbDiaChi.Text = item.SubItems[3].Text;
            tbSoTien.Text = item.SubItems[4].Text;
        }

        //
        private void tbSTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem item = TimTheoSTK(tbSTK.Text);

            if (item == null)
            {
                // ======= THÊM MỚI =======
                ListViewItem newItem = new ListViewItem(stt.ToString());
                newItem.SubItems.Add(tbSTK.Text);
                newItem.SubItems.Add(tbTen.Text);
                newItem.SubItems.Add(tbDiaChi.Text);
                newItem.SubItems.Add(tbSoTien.Text);

                listView1.Items.Add(newItem);
                stt++;

                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                // ======= CẬP NHẬT =======
                item.SubItems[2].Text = tbTen.Text;
                item.SubItems[3].Text = tbDiaChi.Text;
                item.SubItems[4].Text = tbSoTien.Text;

                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }

            TinhTongTien();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ListViewItem item = TimTheoSTK(tbSTK.Text);

            if (item == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa?",
                                             "Xóa",
                                             MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                listView1.Items.Remove(item);
                MessageBox.Show("Xóa tài khoản thành công!");
                TinhTongTien();
            }
        }

        private void Revise_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem item = TimTheoSTK(tbSTK.Text);

            if (item == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản để sửa!");
                return;
            }

            // ======= THỰC HIỆN SỬA =======
            item.SubItems[2].Text = tbTen.Text;
            item.SubItems[3].Text = tbDiaChi.Text;
            item.SubItems[4].Text = tbSoTien.Text;

            MessageBox.Show("Cập nhật dữ liệu thành công!");

            TinhTongTien();
        }
    }
}
