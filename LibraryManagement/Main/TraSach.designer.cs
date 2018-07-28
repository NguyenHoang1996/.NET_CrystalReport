namespace Main
{
    partial class TraSach
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
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.btnTra = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongNo = new System.Windows.Forms.Label();
            this.lbTienPhat = new System.Windows.Forms.Label();
            this.ckbChonTatCa = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaylapthe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaThe = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLai.Image = global::Main.Properties.Resources.reload_icon;
            this.btnTaoLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLai.Location = new System.Drawing.Point(397, 475);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(100, 50);
            this.btnTaoLai.TabIndex = 3;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThe.Location = new System.Drawing.Point(63, 84);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(105, 16);
            this.lbMaThe.TabIndex = 41;
            this.lbMaThe.Text = "Mã Thẻ Đọc Giả";
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Image = global::Main.Properties.Resources.Book_icon2;
            this.btnTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTra.Location = new System.Drawing.Point(211, 475);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(112, 50);
            this.btnTra.TabIndex = 2;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // listResult
            // 
            this.listResult.CheckBoxes = true;
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1});
            this.listResult.FullRowSelect = true;
            this.listResult.GridLines = true;
            this.listResult.Location = new System.Drawing.Point(71, 256);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(601, 157);
            this.listResult.TabIndex = 44;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            this.listResult.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listResult_ItemCheck);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Mượn";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hạn Trả";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 148;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trạng thái";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tổng tiền phạt: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tổng nợ:";
            // 
            // lbTongNo
            // 
            this.lbTongNo.AutoSize = true;
            this.lbTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongNo.Location = new System.Drawing.Point(617, 447);
            this.lbTongNo.Name = "lbTongNo";
            this.lbTongNo.Size = new System.Drawing.Size(15, 16);
            this.lbTongNo.TabIndex = 48;
            this.lbTongNo.Text = "0";
            // 
            // lbTienPhat
            // 
            this.lbTienPhat.AutoSize = true;
            this.lbTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhat.Location = new System.Drawing.Point(617, 425);
            this.lbTienPhat.Name = "lbTienPhat";
            this.lbTienPhat.Size = new System.Drawing.Size(15, 16);
            this.lbTienPhat.TabIndex = 47;
            this.lbTienPhat.Text = "0";
            // 
            // ckbChonTatCa
            // 
            this.ckbChonTatCa.AutoSize = true;
            this.ckbChonTatCa.Location = new System.Drawing.Point(105, 229);
            this.ckbChonTatCa.Name = "ckbChonTatCa";
            this.ckbChonTatCa.Size = new System.Drawing.Size(87, 19);
            this.ckbChonTatCa.TabIndex = 1;
            this.ckbChonTatCa.Text = "Chọn tất cả";
            this.ckbChonTatCa.UseVisualStyleBackColor = true;
            this.ckbChonTatCa.CheckedChanged += new System.EventHandler(this.ckbChonTatCa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Trả sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaylapthe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLoaiDG);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNgaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(385, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 169);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đọc giả";
            // 
            // txtNgaylapthe
            // 
            this.txtNgaylapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylapthe.Location = new System.Drawing.Point(108, 134);
            this.txtNgaylapthe.Name = "txtNgaylapthe";
            this.txtNgaylapthe.ReadOnly = true;
            this.txtNgaylapthe.Size = new System.Drawing.Size(163, 22);
            this.txtNgaylapthe.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Ngày lập thẻ";
            // 
            // txtLoaiDG
            // 
            this.txtLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiDG.Location = new System.Drawing.Point(108, 97);
            this.txtLoaiDG.Name = "txtLoaiDG";
            this.txtLoaiDG.ReadOnly = true;
            this.txtLoaiDG.Size = new System.Drawing.Size(163, 22);
            this.txtLoaiDG.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Loại đọc giả";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinh.Location = new System.Drawing.Point(108, 62);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.ReadOnly = true;
            this.txtNgaysinh.Size = new System.Drawing.Size(163, 22);
            this.txtNgaysinh.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(108, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(163, 22);
            this.txtHoTen.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Họ tên";
            // 
            // cbMaThe
            // 
            this.cbMaThe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaThe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaThe.FormattingEnabled = true;
            this.cbMaThe.Location = new System.Drawing.Point(187, 81);
            this.cbMaThe.Name = "cbMaThe";
            this.cbMaThe.Size = new System.Drawing.Size(121, 23);
            this.cbMaThe.TabIndex = 53;
            this.cbMaThe.SelectedValueChanged += new System.EventHandler(this.cbMaThe_SelectedValueChanged);
            this.cbMaThe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMaThe_MouseClick);
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaThe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbChonTatCa);
            this.Controls.Add(this.lbTongNo);
            this.Controls.Add(this.lbTienPhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.lbMaThe);
            this.Controls.Add(this.btnTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TraSach";
            this.Size = new System.Drawing.Size(742, 554);
            this.Load += new System.EventHandler(this.TraSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongNo;
        private System.Windows.Forms.Label lbTienPhat;
        private System.Windows.Forms.CheckBox ckbChonTatCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgaylapthe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaThe;
    }
}
