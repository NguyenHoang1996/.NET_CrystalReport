using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnBCMuonSach_Click(object sender, EventArgs e)
        {
            CrystalReport.formBCMuonSach frmBCMuonSach = new CrystalReport.formBCMuonSach();

            frmBCMuonSach.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport.formThongKeTheLoaiSach frm = new CrystalReport.formThongKeTheLoaiSach();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport.formBCLuocSuMuonTheLoaiSach formBCLuocSuMuon = new CrystalReport.formBCLuocSuMuonTheLoaiSach();
            formBCLuocSuMuon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrystalReport.formBCTKSachDangDuocMuon formBCTKSachDangDuocMuon =
                new CrystalReport.formBCTKSachDangDuocMuon();
            formBCTKSachDangDuocMuon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrystalReport.formBCTTMuonTLSach formBCTTMuonTLSach =
                new CrystalReport.formBCTTMuonTLSach();
            formBCTTMuonTLSach.Show();
        }
    }
}
