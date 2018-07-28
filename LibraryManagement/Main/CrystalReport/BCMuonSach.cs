using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Main.CrystalReport;

namespace Main
{
    public partial class BCMuonSach : UserControl
    {
        public BCMuonSach()
        {
            InitializeComponent();
        }

        private void BCMuonSach_Load(object sender, EventArgs e)
        {
            CrpBCMuonSach rp = new CrpBCMuonSach();
            rp.SetDataSource(LayDL(DateTime.Now.Month, DateTime.Now.Year));
            crpViewer.ReportSource = rp;
            cbThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private DataTable LayDL(int thang, int nam)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE3MJK7;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("BCMuonSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Thang", SqlDbType.Int);
            cmd.Parameters.Add("@Nam", SqlDbType.Int);

            cmd.Parameters["@Thang"].Value = thang;
            cmd.Parameters["@Nam"].Value = nam;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            CrpBCMuonSach rp = new CrpBCMuonSach();
            rp.SetDataSource(LayDL(int.Parse(cbThang.Text), int.Parse(txtNam.Text)));
            crpViewer.ReportSource = rp;
        }
    }
}
