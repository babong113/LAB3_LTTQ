using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //nút check nhập thông tin
        private bool CheckTB()
        {
            if(tbMaSV.Text==null ||tbHoTen.Text==null||cbChuyenNganh.Text.Trim()==null)
                return false;
            return true;
        }

        //nút lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckTB())
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ!");
                return;
            }
            string gt=null;
            if (CheckNam.Checked)
                gt = "Nam";
            else if (CheckNu.Checked)
                gt = "Nu";
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            } 
            
            int somonhoc=listBox2.Items.Count;
            dataGridView1.Rows.Add(
                tbMaSV.Text, tbHoTen.Text, cbChuyenNganh.Text, gt, somonhoc);
            MessageBox.Show("Lưu thành công!");
        }

        //nút chọn
        private void btChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            } 
                
        }

        //nút bỏ chọn
        private void btBoChon_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            } 
                
        }


        //nút xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbMaSV.Clear();
            tbHoTen.Clear();
            cbChuyenNganh.SelectedIndex = -1;
            CheckNam.Checked = false;
            CheckNu.Checked = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("Cơ sở dữ liệu");
            listBox1.Items.Add("Cơ sở DL nâng cao");
            listBox1.Items.Add("PTTK hệ thống thông tin");
            listBox2.Items.Clear();
        }
    }
}

