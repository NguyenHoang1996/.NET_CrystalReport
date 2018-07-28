namespace Main.CrystalReport
{
    partial class formThongKeTheLoaiSach
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
            this.crpViewerBCMuonSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Main.CrystalReport.CrpThongKeTheLoaiSach();
            this.cbThang1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNam1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crpViewerBCMuonSach
            // 
            this.crpViewerBCMuonSach.ActiveViewIndex = 0;
            this.crpViewerBCMuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crpViewerBCMuonSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpViewerBCMuonSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpViewerBCMuonSach.DisplayStatusBar = false;
            this.crpViewerBCMuonSach.Location = new System.Drawing.Point(0, 83);
            this.crpViewerBCMuonSach.Name = "crpViewerBCMuonSach";
            this.crpViewerBCMuonSach.ReportSource = this.CrystalReport11;
            this.crpViewerBCMuonSach.Size = new System.Drawing.Size(932, 591);
            this.crpViewerBCMuonSach.TabIndex = 0;
            this.crpViewerBCMuonSach.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbThang1
            // 
            this.cbThang1.FormattingEnabled = true;
            this.cbThang1.Items.AddRange(new object[] {
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
            this.cbThang1.Location = new System.Drawing.Point(293, 56);
            this.cbThang1.Name = "cbThang1";
            this.cbThang1.Size = new System.Drawing.Size(75, 21);
            this.cbThang1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "BÁO CÁO THỐNG KÊ THỂ LOẠI SÁCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNam1
            // 
            this.txtNam1.Location = new System.Drawing.Point(495, 58);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(100, 20);
            this.txtNam1.TabIndex = 7;
            // 
            // formThongKeTheLoaiSach
            // 
            this.ClientSize = new System.Drawing.Size(932, 674);
            this.Controls.Add(this.txtNam1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbThang1);
            this.Controls.Add(this.crpViewerBCMuonSach);
            this.Name = "formThongKeTheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formThongKeTheLoaiSach_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpViewerBCMuonSach;
        private System.Windows.Forms.ComboBox cbThang1;
        private CrpThongKeTheLoaiSach CrystalReport11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNam1;
    }
}