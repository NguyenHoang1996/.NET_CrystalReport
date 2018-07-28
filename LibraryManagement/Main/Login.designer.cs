namespace Main
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btmThoat = new System.Windows.Forms.Button();
            this.btmDangNhap = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.PictureBox();
            this.btmHide = new System.Windows.Forms.PictureBox();
            this.btmClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btmThoat
            // 
            this.btmThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.btmThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btmThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmThoat.Location = new System.Drawing.Point(235, 179);
            this.btmThoat.Name = "btmThoat";
            this.btmThoat.Size = new System.Drawing.Size(171, 39);
            this.btmThoat.TabIndex = 18;
            this.btmThoat.Text = "Thoát";
            this.btmThoat.UseVisualStyleBackColor = true;
            this.btmThoat.Click += new System.EventHandler(this.btmThoat_Click);
            // 
            // btmDangNhap
            // 
            this.btmDangNhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btmDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.btmDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btmDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDangNhap.Location = new System.Drawing.Point(20, 179);
            this.btmDangNhap.Name = "btmDangNhap";
            this.btmDangNhap.Size = new System.Drawing.Size(171, 39);
            this.btmDangNhap.TabIndex = 17;
            this.btmDangNhap.Text = "Đăng nhập";
            this.btmDangNhap.UseVisualStyleBackColor = false;
            this.btmDangNhap.Click += new System.EventHandler(this.btmDangNhap_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(210, 62);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(162, 26);
            this.txtTenDN.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(236)))));
            this.titleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.setting);
            this.titleBar.Controls.Add(this.btmHide);
            this.titleBar.Controls.Add(this.btmClose);
            this.titleBar.Controls.Add(this.label5);
            this.titleBar.Location = new System.Drawing.Point(-1, -2);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(427, 41);
            this.titleBar.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // setting
            // 
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(765, 4);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(16, 16);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setting.TabIndex = 3;
            this.setting.TabStop = false;
            // 
            // btmHide
            // 
            this.btmHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmHide.Image = ((System.Drawing.Image)(resources.GetObject("btmHide.Image")));
            this.btmHide.Location = new System.Drawing.Point(792, 5);
            this.btmHide.Name = "btmHide";
            this.btmHide.Size = new System.Drawing.Size(16, 16);
            this.btmHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btmHide.TabIndex = 2;
            this.btmHide.TabStop = false;
            // 
            // btmClose
            // 
            this.btmClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmClose.Image = ((System.Drawing.Image)(resources.GetObject("btmClose.Image")));
            this.btmClose.Location = new System.Drawing.Point(818, 5);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(16, 16);
            this.btmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btmClose.TabIndex = 1;
            this.btmClose.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Library Management - Đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(210, 106);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(162, 26);
            this.txtMatKhau.TabIndex = 15;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHienMK.Location = new System.Drawing.Point(215, 143);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(106, 19);
            this.cbHienMK.TabIndex = 16;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(428, 230);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.btmThoat);
            this.Controls.Add(this.btmDangNhap);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmThoat;
        private System.Windows.Forms.Button btmDangNhap;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox setting;
        private System.Windows.Forms.PictureBox btmHide;
        private System.Windows.Forms.PictureBox btmClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}