namespace Main
{
    partial class BCMuonSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.crpViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo tình hình mượn sách theo tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng: ";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(253, 59);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(57, 21);
            this.cbThang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm:";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(379, 59);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(79, 20);
            this.txtNam.TabIndex = 4;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(482, 57);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // crpViewer
            // 
            this.crpViewer.ActiveViewIndex = -1;
            this.crpViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpViewer.Location = new System.Drawing.Point(3, 112);
            this.crpViewer.Name = "crpViewer";
            this.crpViewer.Size = new System.Drawing.Size(739, 439);
            this.crpViewer.TabIndex = 6;
            // 
            // BCMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crpViewer);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BCMuonSach";
            this.Size = new System.Drawing.Size(742, 554);
            this.Load += new System.EventHandler(this.BCMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnXuat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpViewer;
    }
}
