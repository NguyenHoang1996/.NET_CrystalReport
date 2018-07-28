namespace Main.CrystalReport
{
    partial class formBCLuocSuMuonTheLoaiSach
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
            this.crpCrpBCLuocSuMuonTheLoaiSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrpBCLuocSuMuonTheLoaiSach1 = new Main.CrystalReport.CrpBCLuocSuMuonTheLoaiSach();
            this.SuspendLayout();
            // 
            // crpCrpBCLuocSuMuonTheLoaiSach
            // 
            this.crpCrpBCLuocSuMuonTheLoaiSach.ActiveViewIndex = 0;
            this.crpCrpBCLuocSuMuonTheLoaiSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpCrpBCLuocSuMuonTheLoaiSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpCrpBCLuocSuMuonTheLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpCrpBCLuocSuMuonTheLoaiSach.Location = new System.Drawing.Point(0, 0);
            this.crpCrpBCLuocSuMuonTheLoaiSach.Name = "crpCrpBCLuocSuMuonTheLoaiSach";
            this.crpCrpBCLuocSuMuonTheLoaiSach.ReportSource = this.CrpBCLuocSuMuonTheLoaiSach1;
            this.crpCrpBCLuocSuMuonTheLoaiSach.Size = new System.Drawing.Size(846, 489);
            this.crpCrpBCLuocSuMuonTheLoaiSach.TabIndex = 0;
            this.crpCrpBCLuocSuMuonTheLoaiSach.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // formBCLuocSuMuonTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 489);
            this.Controls.Add(this.crpCrpBCLuocSuMuonTheLoaiSach);
            this.Name = "formBCLuocSuMuonTheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formBCLuocSuMuonTheLoaiSach";
            this.Load += new System.EventHandler(this.formBCLuocSuMuonTheLoaiSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpCrpBCLuocSuMuonTheLoaiSach;
        private CrpBCLuocSuMuonTheLoaiSach CrpBCLuocSuMuonTheLoaiSach1;
    }
}