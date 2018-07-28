namespace Main
{
    partial class NhanSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.btTaoLai = new System.Windows.Forms.Button();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNhanSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "MM/dd/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.Location = new System.Drawing.Point(506, 106);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(199, 21);
            this.dtNgayNhap.TabIndex = 5;
            this.dtNgayNhap.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtNgayNhap_PreviewKeyDown);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.ItemHeight = 15;
            this.cbTheLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTheLoai.Location = new System.Drawing.Point(506, 68);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(199, 23);
            this.cbTheLoai.TabIndex = 4;
            this.cbTheLoai.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbTheLoai_PreviewKeyDown);
            // 
            // btTaoLai
            // 
            this.btTaoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoLai.Image = global::Main.Properties.Resources.reload_icon;
            this.btTaoLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoLai.Location = new System.Drawing.Point(442, 254);
            this.btTaoLai.Name = "btTaoLai";
            this.btTaoLai.Size = new System.Drawing.Size(107, 50);
            this.btTaoLai.TabIndex = 9;
            this.btTaoLai.Text = "Tạo lại";
            this.btTaoLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoLai.UseVisualStyleBackColor = true;
            this.btTaoLai.Click += new System.EventHandler(this.btTaoLai_Click);
            // 
            // txtTriGia
            // 
            this.txtTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriGia.Location = new System.Drawing.Point(506, 144);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTriGia.Size = new System.Drawing.Size(199, 22);
            this.txtTriGia.TabIndex = 6;
            this.txtTriGia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTriGia_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trị giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ngày nhập";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(152, 144);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(199, 22);
            this.txtTacGia.TabIndex = 1;
            this.txtTacGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTacGia_KeyDown);
            this.txtTacGia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTacGia_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thể loại";
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(152, 222);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(199, 22);
            this.txtNXB.TabIndex = 3;
            this.txtNXB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNXB_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Năm xuất bản";
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXB.Location = new System.Drawing.Point(152, 183);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(199, 22);
            this.txtNhaXB.TabIndex = 2;
            this.txtNhaXB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNhaXB_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhà xuất bản";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(152, 105);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(199, 22);
            this.txtTenSach.TabIndex = 0;
            this.txtTenSach.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTenSach_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(152, 68);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(199, 21);
            this.txtMaSach.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(506, 183);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoLuong.Size = new System.Drawing.Size(199, 22);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSoLuong_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nhập Sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 316);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.Size = new System.Drawing.Size(742, 238);
            this.dgvDanhSach.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể loại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tác giả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nhà XB";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Năm XB";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trị giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày nhập";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số lượng";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // btNhanSach
            // 
            this.btNhanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanSach.Image = global::Main.Properties.Resources.Actions_address_book_new_icon;
            this.btNhanSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanSach.Location = new System.Drawing.Point(202, 254);
            this.btNhanSach.Name = "btNhanSach";
            this.btNhanSach.Size = new System.Drawing.Size(127, 50);
            this.btNhanSach.TabIndex = 8;
            this.btNhanSach.Text = "Nhận sách";
            this.btNhanSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNhanSach.UseVisualStyleBackColor = true;
            this.btNhanSach.Click += new System.EventHandler(this.btNhanSach_Click);
            // 
            // NhanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.btTaoLai);
            this.Controls.Add(this.btNhanSach);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhaXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NhanSach";
            this.Size = new System.Drawing.Size(742, 554);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Button btTaoLai;
        private System.Windows.Forms.Button btNhanSach;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
