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
    public partial class formBCMuonSach : Form
    {
        public formBCMuonSach()
        {
            InitializeComponent();
        }

        private DataTable LayDL(int thang, int nam)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGD8DGD;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("BCSSTheLoaiSach", conn);
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

        private void formBCMuonSach_Load(object sender, EventArgs e)
        {
            CrpBCMuonSach rp = new CrpBCMuonSach();
            rp.SetDataSource(LayDL(DateTime.Now.Month, DateTime.Now.Year));
            CrpBCMuonSach.ReportSource = rp;
            cbbThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrpBCMuonSach rp = new CrpBCMuonSach();
            rp.SetDataSource(LayDL(int.Parse(cbbThang.Text), int.Parse(txtNam.Text)));
            CrpBCMuonSach.ReportSource = rp;
        }
    }
}
