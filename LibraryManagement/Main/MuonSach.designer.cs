namespace Main
{
    partial class MuonSach
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
            this.components = new System.ComponentModel.Container();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMuon = new System.Windows.Forms.Button();
            this.txtSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtHanTra = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoSachDaMuon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Mã Thẻ";
            // 
            // btnMuon
            // 
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.Image = global::Main.Properties.Resources.Book_icon1;
            this.btnMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuon.Location = new System.Drawing.Point(223, 475);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(100, 50);
            this.btnMuon.TabIndex = 2;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // txtSach
            // 
            this.txtSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSach.Location = new System.Drawing.Point(174, 276);
            this.txtSach.Name = "txtSach";
            this.txtSach.Size = new System.Drawing.Size(174, 22);
            this.txtSach.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSach, "Nhập tên sách, mã sách, hoặc tên tác giả");
            this.txtSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSach_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thông tin sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listResult
            // 
            this.listResult.CheckBoxes = true;
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listResult.FullRowSelect = true;
            this.listResult.GridLines = true;
            this.listResult.Location = new System.Drawing.Point(64, 305);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(598, 153);
            this.listResult.TabIndex = 45;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sách";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tác giả";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 179;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thể loại";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 142;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ngày mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Hạn trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mượn sách";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.CustomFormat = "MM/dd/yyyy";
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMuon.Location = new System.Drawing.Point(179, 52);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(136, 21);
            this.dtNgayMuon.TabIndex = 4;
            // 
            // dtHanTra
            // 
            this.dtHanTra.CustomFormat = "MM/dd/yyyy";
            this.dtHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHanTra.Location = new System.Drawing.Point(408, 49);
            this.dtHanTra.Name = "dtHanTra";
            this.dtHanTra.Size = new System.Drawing.Size(136, 21);
            this.dtHanTra.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoSachDaMuon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNgaylapthe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLoaiDG);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNgaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(381, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 185);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đọc giả";
            // 
            // txtSoSachDaMuon
            // 
            this.txtSoSachDaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSachDaMuon.Location = new System.Drawing.Point(155, 153);
            this.txtSoSachDaMuon.Name = "txtSoSachDaMuon";
            this.txtSoSachDaMuon.ReadOnly = true;
            this.txtSoSachDaMuon.Size = new System.Drawing.Size(67, 22);
            this.txtSoSachDaMuon.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Số sách đã mượn";
            // 
            // txtNgaylapthe
            // 
            this.txtNgaylapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylapthe.Location = new System.Drawing.Point(108, 121);
            this.txtNgaylapthe.Name = "txtNgaylapthe";
            this.txtNgaylapthe.ReadOnly = true;
            this.txtNgaylapthe.Size = new System.Drawing.Size(163, 22);
            this.txtNgaylapthe.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Ngày lập thẻ";
            // 
            // txtLoaiDG
            // 
            this.txtLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiDG.Location = new System.Drawing.Point(108, 87);
            this.txtLoaiDG.Name = "txtLoaiDG";
            this.txtLoaiDG.ReadOnly = true;
            this.txtLoaiDG.Size = new System.Drawing.Size(163, 22);
            this.txtLoaiDG.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Loại đọc giả";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinh.Location = new System.Drawing.Point(108, 54);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.ReadOnly = true;
            this.txtNgaysinh.Size = new System.Drawing.Size(163, 22);
            this.txtNgaysinh.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(108, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(163, 22);
            this.txtHoTen.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
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
            this.cbMaThe.Location = new System.Drawing.Point(179, 101);
            this.cbMaThe.Name = "cbMaThe";
            this.cbMaThe.Size = new System.Drawing.Size(136, 23);
            this.cbMaThe.TabIndex = 52;
            this.cbMaThe.SelectedValueChanged += new System.EventHandler(this.cbMaThe_SelectedValueChanged);
            this.cbMaThe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMaThe_MouseClick);
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaThe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtHanTra);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.txtSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MuonSach";
            this.Size = new System.Drawing.Size(742, 554);
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.TextBox txtSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtHanTra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgaylapthe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoSachDaMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaThe;
    }
}
