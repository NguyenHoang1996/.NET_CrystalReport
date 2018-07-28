namespace Main.CrystalReport
{
    partial class formBCMuonSach
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
            this.CrpBCMuonSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.CrpBCMuonSach1 = new Main.CrystalReport.CrpBCMuonSach();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrpBCMuonSach
            // 
            this.CrpBCMuonSach.ActiveViewIndex = 0;
            this.CrpBCMuonSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrpBCMuonSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrpBCMuonSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CrpBCMuonSach.Location = new System.Drawing.Point(0, 89);
            this.CrpBCMuonSach.Name = "CrpBCMuonSach";
            this.CrpBCMuonSach.ReportSource = this.CrpBCMuonSach1;
            this.CrpBCMuonSach.Size = new System.Drawing.Size(826, 507);
            this.CrpBCMuonSach.TabIndex = 0;
            this.CrpBCMuonSach.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(362, 50);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO TÌNH HÌNH MƯỢN SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÁNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NĂM";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
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
            this.cbbThang.Location = new System.Drawing.Point(186, 50);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formBCMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.CrpBCMuonSach);
            this.Name = "formBCMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formBCMuonSach";
            this.Load += new System.EventHandler(this.formBCMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrpBCMuonSach;
        private CrpBCMuonSach CrpBCMuonSach1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button button1;
    }
}