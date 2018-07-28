using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ValueObject;
using DataAccessLayer;
using BusinessLayer;

namespace Main
{
    public partial class BaoCaoMuonSach : UserControl
    {
        
        public BaoCaoMuonSach()
        {
            InitializeComponent();

            // load dữ liệu vào TableAdapter
            //this.VW_BAOCAOMUONSACHTableAdapter.Fill(this.DataBaoCao.VW_BAOCAOMUONSACH);
            //this.rpBaoCao.RefreshReport(); // làm mới lại report
        }
        
        // Hàm tạo mảng parameter cho report
        private void SetParameters(int thang, int nam)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("Thang");
            rp[0].Values.Add(thang.ToString());
            rp[1] = new ReportParameter("Nam");
            rp[1].Values.Add(nam.ToString());
            rpBaoCao.LocalReport.SetParameters(rp);
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            SetParameters(int.Parse(cbThang.Text), int.Parse(txtNam.Text));
            rpBaoCao.RefreshReport();
        }

        private void BaoCaoMuonSach_Load(object sender, EventArgs e)
        {
            int t = int.Parse(DateTime.Now.Month.ToString()); // Tháng hiện tại
            string thang = (t-1).ToString();
            cbThang.Text = thang;
            int n = int.Parse(DateTime.Now.Year.ToString()); // Năm hiện tại
            string nam = n.ToString();
            txtNam.Text = nam;
            if(t == 1) 
            {
                thang = "12";
                nam = (n - 1).ToString();
            }
            SetParameters(int.Parse(cbThang.Text), int.Parse(txtNam.Text));
            rpBaoCao.RefreshReport();
        }

        private void cbThang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btBaoCao_Click(sender, e);
        }

        private void txtNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btBaoCao_Click(sender, e);
        }
    }
}
