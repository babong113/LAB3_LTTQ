namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btChon = new System.Windows.Forms.Button();
            this.btBoChon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckNu = new System.Windows.Forms.CheckBox();
            this.CheckNam = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbChuyenNganh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Controls.Add(this.btBoChon);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CheckNu);
            this.groupBox1.Controls.Add(this.CheckNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 25);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa Chọn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 25);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu Thông Tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(494, 199);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(185, 84);
            this.listBox2.TabIndex = 13;
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(395, 199);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(49, 33);
            this.btChon.TabIndex = 12;
            this.btChon.Text = ">";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // btBoChon
            // 
            this.btBoChon.Location = new System.Drawing.Point(395, 250);
            this.btBoChon.Name = "btBoChon";
            this.btBoChon.Size = new System.Drawing.Size(49, 33);
            this.btBoChon.TabIndex = 11;
            this.btBoChon.Text = "<";
            this.btBoChon.UseVisualStyleBackColor = true;
            this.btBoChon.Click += new System.EventHandler(this.btBoChon_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Cơ sở dữ liệu ",
            "Cơ sở dữ liệu NC",
            "PTTK Hệ Thống Thông Tin"});
            this.listBox1.Location = new System.Drawing.Point(164, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 84);
            this.listBox1.TabIndex = 10;
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn các Môn Học Tham Gia";
            // 
            // CheckNu
            // 
            this.CheckNu.AutoSize = true;
            this.CheckNu.Location = new System.Drawing.Point(392, 136);
            this.CheckNu.Name = "CheckNu";
            this.CheckNu.Size = new System.Drawing.Size(43, 20);
            this.CheckNu.TabIndex = 8;
            this.CheckNu.Text = "Nữ";
            this.CheckNu.UseVisualStyleBackColor = true;
            // 
            // CheckNam
            // 
            this.CheckNam.AutoSize = true;
            this.CheckNam.Location = new System.Drawing.Point(307, 136);
            this.CheckNam.Name = "CheckNam";
            this.CheckNam.Size = new System.Drawing.Size(55, 20);
            this.CheckNam.TabIndex = 7;
            this.CheckNam.Text = "Nam";
            this.CheckNam.UseVisualStyleBackColor = true;
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(307, 76);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(428, 22);
            this.tbHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // tbMaSV
            // 
            this.tbMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSV.Location = new System.Drawing.Point(307, 44);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(252, 22);
            this.tbMaSV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colChuyenNganh,
            this.ColGioiTinh,
            this.colSoMon});
            this.dataGridView1.Location = new System.Drawing.Point(12, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // colMSSV
            // 
            this.colMSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChuyenNganh.HeaderText = "Chuyên Ngành ";
            this.colChuyenNganh.Name = "colChuyenNganh";
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColGioiTinh.HeaderText = "Giới Tính";
            this.ColGioiTinh.Name = "ColGioiTinh";
            // 
            // colSoMon
            // 
            this.colSoMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoMon.HeaderText = "Số Môn";
            this.colSoMon.Name = "colSoMon";
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Items.AddRange(new object[] {
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Hệ thống thông tin ",
            "Khoa học dữ liệu",
            "thương mại điện tử",
            "công nghệ thông tin ",
            "Trí tuệ nhân tạo "});
            this.cbChuyenNganh.Location = new System.Drawing.Point(307, 106);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(428, 24);
            this.cbChuyenNganh.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 676);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhập Dữ Liệu Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckNu;
        private System.Windows.Forms.CheckBox CheckNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Button btBoChon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoMon;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
    }
}

