namespace Main
{
    partial class TienPhat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VW_PHIEUTHUTIENPHATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataBaoCao = new Main.DataBaoCao();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaThe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTaoLai = new System.Windows.Forms.Button();
            this.rpPhieuThuTien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_PHIEUTHUTIENPHATTableAdapter = new Main.DataBaoCaoTableAdapters.VW_PHIEUTHUTIENPHATTableAdapter();
            this.btInPhieu = new System.Windows.Forms.Button();
            this.btnThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VW_PHIEUTHUTIENPHATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VW_PHIEUTHUTIENPHATBindingSource
            // 
            this.VW_PHIEUTHUTIENPHATBindingSource.DataMember = "VW_PHIEUTHUTIENPHAT";
            this.VW_PHIEUTHUTIENPHATBindingSource.DataSource = this.DataBaoCao;
            // 
            // DataBaoCao
            // 
            this.DataBaoCao.DataSetName = "DataBaoCao";
            this.DataBaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Thu Tiền Phạt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPTT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbMaThe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtTienThu);
            this.groupBox1.Controls.Add(this.txtTongNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConLai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbMaThe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 142);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtMaPTT
            // 
            this.txtMaPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPTT.Location = new System.Drawing.Point(125, 31);
            this.txtMaPTT.Name = "txtMaPTT";
            this.txtMaPTT.Size = new System.Drawing.Size(182, 23);
            this.txtMaPTT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Mã Phiếu Thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMaThe
            // 
            this.cbMaThe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaThe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaThe.FormattingEnabled = true;
            this.cbMaThe.Location = new System.Drawing.Point(111, 68);
            this.cbMaThe.Name = "cbMaThe";
            this.cbMaThe.Size = new System.Drawing.Size(196, 24);
            this.cbMaThe.TabIndex = 1;
            this.cbMaThe.SelectedValueChanged += new System.EventHandler(this.cbMaThe_SelectedValueChanged);
            this.cbMaThe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMaThe_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tổng nợ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(111, 108);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(196, 23);
            this.txtHoTen.TabIndex = 61;
            // 
            // txtTienThu
            // 
            this.txtTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThu.Location = new System.Drawing.Point(430, 68);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(196, 23);
            this.txtTienThu.TabIndex = 2;
            this.txtTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienThu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTienThu_KeyDown);
            // 
            // txtTongNo
            // 
            this.txtTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongNo.Location = new System.Drawing.Point(430, 34);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(196, 23);
            this.txtTongNo.TabIndex = 60;
            this.txtTongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số tiền thu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConLai
            // 
            this.txtConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConLai.Location = new System.Drawing.Point(430, 110);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(196, 23);
            this.txtConLai.TabIndex = 59;
            this.txtConLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Họ tên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThe.Location = new System.Drawing.Point(23, 71);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(56, 17);
            this.lbMaThe.TabIndex = 50;
            this.lbMaThe.Text = "Mã Thẻ";
            this.lbMaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Còn lại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btTaoLai
            // 
            this.btTaoLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoLai.Image = global::Main.Properties.Resources.reload_icon;
            this.btTaoLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoLai.Location = new System.Drawing.Point(478, 485);
            this.btTaoLai.Name = "btTaoLai";
            this.btTaoLai.Size = new System.Drawing.Size(103, 46);
            this.btTaoLai.TabIndex = 5;
            this.btTaoLai.Text = "Tạo lại";
            this.btTaoLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoLai.UseVisualStyleBackColor = true;
            this.btTaoLai.Click += new System.EventHandler(this.btTaoLai_Click);
            // 
            // rpPhieuThuTien
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VW_PHIEUTHUTIENPHATBindingSource;
            this.rpPhieuThuTien.LocalReport.DataSources.Add(reportDataSource2);
            this.rpPhieuThuTien.LocalReport.ReportEmbeddedResource = "Main.rpPhieuThuTienPhat.rdlc";
            this.rpPhieuThuTien.Location = new System.Drawing.Point(40, 178);
            this.rpPhieuThuTien.Name = "rpPhieuThuTien";
            this.rpPhieuThuTien.Size = new System.Drawing.Size(654, 301);
            this.rpPhieuThuTien.TabIndex = 69;
            // 
            // VW_PHIEUTHUTIENPHATTableAdapter
            // 
            this.VW_PHIEUTHUTIENPHATTableAdapter.ClearBeforeFill = true;
            // 
            // btInPhieu
            // 
            this.btInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPhieu.Image = global::Main.Properties.Resources.Print_icon;
            this.btInPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInPhieu.Location = new System.Drawing.Point(305, 485);
            this.btInPhieu.Name = "btInPhieu";
            this.btInPhieu.Size = new System.Drawing.Size(109, 46);
            this.btInPhieu.TabIndex = 4;
            this.btInPhieu.Text = "In Phiếu";
            this.btInPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInPhieu.UseVisualStyleBackColor = true;
            this.btInPhieu.Click += new System.EventHandler(this.btInPhieu_Click);
            // 
            // btnThu
            // 
            this.btnThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThu.Image = global::Main.Properties.Resources.payment_icon;
            this.btnThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThu.Location = new System.Drawing.Point(136, 485);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(110, 46);
            this.btnThu.TabIndex = 3;
            this.btnThu.Text = "Thu Tiền";
            this.btnThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThu.UseVisualStyleBackColor = true;
            this.btnThu.Click += new System.EventHandler(this.btnThu_Click);
            // 
            // TienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpPhieuThuTien);
            this.Controls.Add(this.btInPhieu);
            this.Controls.Add(this.btTaoLai);
            this.Controls.Add(this.btnThu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TienPhat";
            this.Size = new System.Drawing.Size(742, 554);
            this.Load += new System.EventHandler(this.TienPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_PHIEUTHUTIENPHATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInPhieu;
        private System.Windows.Forms.Button btTaoLai;
        private System.Windows.Forms.Button btnThu;
        private Microsoft.Reporting.WinForms.ReportViewer rpPhieuThuTien;
        private System.Windows.Forms.BindingSource VW_PHIEUTHUTIENPHATBindingSource;
        private DataBaoCao DataBaoCao;
        private DataBaoCaoTableAdapters.VW_PHIEUTHUTIENPHATTableAdapter VW_PHIEUTHUTIENPHATTableAdapter;
    }
}
