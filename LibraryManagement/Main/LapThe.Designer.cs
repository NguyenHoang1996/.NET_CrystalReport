namespace Main
{
    partial class LapThe
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
            this.btTaoLai = new System.Windows.Forms.Button();
            this.txtMathe = new System.Windows.Forms.TextBox();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ngayLapthe = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLapThe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btTaoLai
            // 
            this.btTaoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoLai.Image = global::Main.Properties.Resources.reload_icon;
            this.btTaoLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoLai.Location = new System.Drawing.Point(442, 254);
            this.btTaoLai.Name = "btTaoLai";
            this.btTaoLai.Size = new System.Drawing.Size(100, 50);
            this.btTaoLai.TabIndex = 7;
            this.btTaoLai.Text = "Tạo lại";
            this.btTaoLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoLai.UseVisualStyleBackColor = true;
            this.btTaoLai.Click += new System.EventHandler(this.btTaoLai_Click);
            // 
            // txtMathe
            // 
            this.txtMathe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathe.Location = new System.Drawing.Point(146, 86);
            this.txtMathe.Name = "txtMathe";
            this.txtMathe.ReadOnly = true;
            this.txtMathe.Size = new System.Drawing.Size(202, 22);
            this.txtMathe.TabIndex = 8;
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThe.Location = new System.Drawing.Point(24, 90);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(54, 16);
            this.lbMaThe.TabIndex = 34;
            this.lbMaThe.Text = "Mã Thẻ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "MM/dd/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(146, 157);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(202, 21);
            this.dtNgaySinh.TabIndex = 1;
            this.dtNgaySinh.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtNgaySinh_PreviewKeyDown);
            // 
            // cbLoaiDocGia
            // 
            this.cbLoaiDocGia.FormattingEnabled = true;
            this.cbLoaiDocGia.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.cbLoaiDocGia.Location = new System.Drawing.Point(508, 153);
            this.cbLoaiDocGia.Name = "cbLoaiDocGia";
            this.cbLoaiDocGia.Size = new System.Drawing.Size(131, 23);
            this.cbLoaiDocGia.TabIndex = 4;
            this.cbLoaiDocGia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbLoaiDocGia_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày lập thẻ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Loại đọc giả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(146, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtEmail_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày Sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Địa chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(508, 79);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(214, 57);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtDiaChi_PreviewKeyDown);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(146, 121);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(202, 22);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtHoTen_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Họ và Tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Lập thẻ đọc giả";
            // 
            // ngayLapthe
            // 
            this.ngayLapthe.CustomFormat = "MM/dd/yyyy";
            this.ngayLapthe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayLapthe.Location = new System.Drawing.Point(508, 194);
            this.ngayLapthe.Name = "ngayLapthe";
            this.ngayLapthe.Size = new System.Drawing.Size(131, 21);
            this.ngayLapthe.TabIndex = 5;
            this.ngayLapthe.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ngayLapthe_PreviewKeyDown);
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
            this.Column8});
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 316);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.Size = new System.Drawing.Size(742, 238);
            this.dgvDanhSach.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thẻ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 68;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại ĐG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày lập thẻ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiền nợ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // btLapThe
            // 
            this.btLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapThe.Image = global::Main.Properties.Resources.Add_group_icon;
            this.btLapThe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapThe.Location = new System.Drawing.Point(202, 254);
            this.btLapThe.Name = "btLapThe";
            this.btLapThe.Size = new System.Drawing.Size(108, 50);
            this.btLapThe.TabIndex = 6;
            this.btLapThe.Text = "Lập thẻ";
            this.btLapThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLapThe.UseVisualStyleBackColor = true;
            this.btLapThe.Click += new System.EventHandler(this.btLapThe_Click);
            // 
            // LapThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.ngayLapthe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btTaoLai);
            this.Controls.Add(this.txtMathe);
            this.Controls.Add(this.lbMaThe);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.cbLoaiDocGia);
            this.Controls.Add(this.btLapThe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LapThe";
            this.Size = new System.Drawing.Size(742, 554);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTaoLai;
        private System.Windows.Forms.TextBox txtMathe;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbLoaiDocGia;
        private System.Windows.Forms.Button btLapThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ngayLapthe;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
