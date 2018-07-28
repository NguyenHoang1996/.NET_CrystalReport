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
    public partial class TienPhat : UserControl
    {
        private string maPTT;

        public TienPhat()
        {
            InitializeComponent();

            this.VW_PHIEUTHUTIENPHATTableAdapter.Fill(this.DataBaoCao.VW_PHIEUTHUTIENPHAT);

            this.rpPhieuThuTien.RefreshReport();
            // Tinh maPT
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUTHUTIENPHAT_select", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count <= 0)
            {
                maPTT = "P0001";
            }
            else
            {
                string temp = dt.Rows[dt.Rows.Count - 1][0].ToString(); // Mã phiếu thu mới nhất trong dữ liệu
                taoMaPTT(temp);
            }
        }

        private void taoMaPTT(string lastMaPTT)
        {
            lastMaPTT = lastMaPTT.Remove(0, 1);
            int stt = int.Parse(lastMaPTT);
            stt++;
            int l = stt.ToString().Length;
            l = 4 - l;
            string prefix = "P";
            while (l > 0)
            {
                prefix += "0";
                l--;
            }
            maPTT = prefix + stt.ToString();
        }

        private void TienPhat_Load(object sender, EventArgs e)
        {
            cbMaThe.Focus();
            txtMaPTT.Text = maPTT;
            DataTable dt = Bus_LapThe.ChonThe(); // danh sách mã thẻ đọc giả.
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Hệ thống chưa có đọc giả nào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                cbMaThe.DataSource = dt; // load danh sách mã thẻ vào cbMathe.
                cbMaThe.DisplayMember = "MaThe";
                cbMaThe.ValueMember = "MaThe";
            }
            
            rpPhieuThuTien.Hide();
            btInPhieu.Enabled = false;

            this.VW_PHIEUTHUTIENPHATTableAdapter.Fill(this.DataBaoCao.VW_PHIEUTHUTIENPHAT);
            this.rpPhieuThuTien.RefreshReport();
        }

        private void txtTienThu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtConLai.Text = (int.Parse(txtTongNo.Text) - int.Parse(txtTienThu.Text)).ToString();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtTongNo.Text) < int.Parse(txtTienThu.Text))
                MessageBox.Show("Số tiền thu phải nhỏ hơn hoặc bằng tiền nợ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                En_ThuTienPhat thu = new En_ThuTienPhat(maPTT, cbMaThe.Text, int.Parse(txtTienThu.Text), int.Parse(txtConLai.Text), DateTime.Today);
                Bus_ThuTienPhat.ThuTienPhat(thu); // Tạo phiếu thu
                Sql_TraSach.TaiKhoanNo_update(cbMaThe.Text, txtConLai.Text); // Cập nhật lại tài khoản nợ sau khi thu tiền.
                MessageBox.Show("Đã thu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rpPhieuThuTien.RefreshReport();
            btInPhieu.Enabled = true;
            btnThu.Enabled = false;
        }

        private void btTaoLai_Click(object sender, EventArgs e)
        {
            btnThu.Enabled = true;
            taoMaPTT(maPTT);
            txtMaPTT.Text = maPTT;
            cbMaThe.Text = "";
            txtHoTen.Text = "";
            txtTongNo.Text = "";
            txtTienThu.Text = "";
            txtConLai.Text = "0";
        }

        private void SetParameters(string maptt)
        {
            ReportParameter rp = new ReportParameter();
            rp = new ReportParameter("MaPTT");
            rp.Values.Add(maptt);
            rpPhieuThuTien.LocalReport.SetParameters(rp);
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            TienPhat_Load(sender, e);
            rpPhieuThuTien.Show();
            string ma = txtMaPTT.Text;
            SetParameters(ma);
            rpPhieuThuTien.RefreshReport();
        }

        private void cbMaThe_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = Sql_ThuTienPhat.TimHoTen_TienNo(cbMaThe.SelectedValue.ToString());
            if(dt.Rows.Count > 0)
            {
                string hoten = dt.Rows[0][1].ToString();
                int tongno = int.Parse(dt.Rows[0][7].ToString());

                txtHoTen.Text = hoten;
                txtTongNo.Text = tongno.ToString();
            }
        }

        private void cbMaThe_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = Bus_LapThe.ChonThe();
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Hệ thống chưa có đọc giả nào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                cbMaThe.DataSource = dt;
                cbMaThe.DisplayMember = "MaThe";
                cbMaThe.ValueMember = "MaThe";
            }
        }
    }
}
