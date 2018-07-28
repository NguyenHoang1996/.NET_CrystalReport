using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main.CrystalReport
{
    public partial class formBCLuocSuMuonTheLoaiSach : Form
    {
        public formBCLuocSuMuonTheLoaiSach()
        {
            InitializeComponent();
        }
        private DataTable LayDL()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGD8DGD;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("BCLuocSuMuonTheLoaiSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void formBCLuocSuMuonTheLoaiSach_Load(object sender, EventArgs e)
        {
            CrpBCLuocSuMuonTheLoaiSach rp = new CrpBCLuocSuMuonTheLoaiSach();
            rp.SetDataSource(LayDL());
            crpCrpBCLuocSuMuonTheLoaiSach.ReportSource = rp;
        }
    }
}
