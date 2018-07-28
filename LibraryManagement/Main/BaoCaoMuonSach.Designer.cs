namespace Main
{
    partial class BaoCaoMuonSach
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VW_BAOCAOMUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataBaoCao = new Main.DataBaoCao();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBaoCao = new System.Windows.Forms.Button();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_BAOCAOMUONSACHTableAdapter = new Main.DataBaoCaoTableAdapters.VW_BAOCAOMUONSACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_BAOCAOMUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_BAOCAOMUONSACHBindingSource
            // 
            this.VW_BAOCAOMUONSACHBindingSource.DataMember = "VW_BAOCAOMUONSACH";
            this.VW_BAOCAOMUONSACHBindingSource.DataSource = this.DataBaoCao;
            // 
            // DataBaoCao
            // 
            this.DataBaoCao.DataSetName = "DataBaoCao";
            this.DataBaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(358, 56);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(64, 26);
            this.txtNam.TabIndex = 20;
            this.txtNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNam_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Năm";
            // 
            // btBaoCao
            // 
            this.btBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCao.Image = global::Main.Properties.Resources.reports_icon;
            this.btBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaoCao.Location = new System.Drawing.Point(440, 53);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(116, 31);
            this.btBaoCao.TabIndex = 18;
            this.btBaoCao.Text = "Báo Cáo";
            this.btBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBaoCao.UseVisualStyleBackColor = true;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(247, 56);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(45, 26);
            this.cbThang.TabIndex = 17;
            this.cbThang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbThang_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Báo Cáo Tình Hình Mượn Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tháng";
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_BAOCAOMUONSACHBindingSource;
            this.rpBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpBaoCao.LocalReport.ReportEmbeddedResource = "Main.rpBaoCaoMuon.rdlc";
            this.rpBaoCao.Location = new System.Drawing.Point(0, 44);
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Size = new System.Drawing.Size(742, 432);
            this.rpBaoCao.TabIndex = 21;
            // 
            // VW_BAOCAOMUONSACHTableAdapter
            // 
            this.VW_BAOCAOMUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpBaoCao);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBaoCao);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BaoCaoMuonSach";
            this.Size = new System.Drawing.Size(742, 476);
            this.Load += new System.EventHandler(this.BaoCaoMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_BAOCAOMUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBaoCao;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpBaoCao;
        private System.Windows.Forms.BindingSource VW_BAOCAOMUONSACHBindingSource;
        private DataBaoCao DataBaoCao;
        private DataBaoCaoTableAdapters.VW_BAOCAOMUONSACHTableAdapter VW_BAOCAOMUONSACHTableAdapter;

    }
}
