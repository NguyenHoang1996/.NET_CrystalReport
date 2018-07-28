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
using DataAccessLayer;

namespace Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }

            txtTenDN.Focus();
        }

        private void btmThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btmDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("DANGNHAP_Select", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenDN", SqlDbType.Char, 200);
            cmd.Parameters.Add("@MatKhau", SqlDbType.Char, 200);

            cmd.Parameters["@TenDN"].Value = txtTenDN.Text;
            cmd.Parameters["@MatKhau"].Value = txtMatKhau.Text;

            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();

            if (txtTenDN.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDN.Focus();
            }
            else if (i == 1)
            {
                LibraryManagement f = new LibraryManagement();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Text = "";
                txtMatKhau.Focus(); ;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection conn = sqlConnectionData.KetNoi();
                SqlCommand cmd = new SqlCommand("DANGNHAP_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TenDN", SqlDbType.Char, 200);
                cmd.Parameters.Add("@MatKhau", SqlDbType.Char, 200);

                cmd.Parameters["@TenDN"].Value = txtTenDN.Text;
                cmd.Parameters["@MatKhau"].Value = txtMatKhau.Text;

                conn.Open();
                int i = (int)cmd.ExecuteScalar();
                conn.Close();

                if (txtTenDN.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDN.Focus();
                }
                if (i == 1)
                {
                    this.Hide();
                    LibraryManagement f = new LibraryManagement();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.ResetText();
                    txtMatKhau.Focus();
                }
            }
        }

    }
}
