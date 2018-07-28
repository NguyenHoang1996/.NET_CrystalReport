namespace Main
{
    partial class BaoCaoTraSachTre
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
            this.VW_BAOCAOTRASACHTREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataBaoCao = new Main.DataBaoCao();
            this.rpBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_BAOCAOTRASACHTRETableAdapter = new Main.DataBaoCaoTableAdapters.VW_BAOCAOTRASACHTRETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_BAOCAOTRASACHTREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_BAOCAOTRASACHTREBindingSource
            // 
            this.VW_BAOCAOTRASACHTREBindingSource.DataMember = "VW_BAOCAOTRASACHTRE";
            this.VW_BAOCAOTRASACHTREBindingSource.DataSource = this.DataBaoCao;
            // 
            // DataBaoCao
            // 
            this.DataBaoCao.DataSetName = "DataBaoCao";
            this.DataBaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_BAOCAOTRASACHTREBindingSource;
            this.rpBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpBaoCao.LocalReport.ReportEmbeddedResource = "Main.rpBaoCaoSachTre.rdlc";
            this.rpBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Size = new System.Drawing.Size(742, 476);
            this.rpBaoCao.TabIndex = 22;
            // 
            // VW_BAOCAOTRASACHTRETableAdapter
            // 
            this.VW_BAOCAOTRASACHTRETableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoTraSachTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpBaoCao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BaoCaoTraSachTre";
            this.Size = new System.Drawing.Size(742, 476);
            ((System.ComponentModel.ISupportInitialize)(this.VW_BAOCAOTRASACHTREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpBaoCao;
        private System.Windows.Forms.BindingSource VW_BAOCAOTRASACHTREBindingSource;
        private DataBaoCao DataBaoCao;
        private DataBaoCaoTableAdapters.VW_BAOCAOTRASACHTRETableAdapter VW_BAOCAOTRASACHTRETableAdapter;


    }
}
