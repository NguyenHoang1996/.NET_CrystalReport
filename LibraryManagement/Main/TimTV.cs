using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ValueObject;

namespace Main
{
    public partial class TimTV : UserControl
    {
        private DataTable dataSrc;
        string mathe;
        string hoten;
        string loaidg;
        string ngaysinh;
        string ngaylapthe;
        string diachi;
        string email;
        string taikhoanno;

        internal void open()
        {
            this.Focus();
            //datatable mac dinh se hien thi tat ca cac DG thu vien hien co
            dataSrc = Bus_TimTV.TimTV("");
            dtDanhsach.DataSource = dataSrc;

            txtDocGia.Focus();
        }

        public TimTV()
        {
            InitializeComponent();


            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnCapNhat.Visible = false;
            btnHuy.Visible = false;

            txtMaThe.Text = "null";
            txtHoTen.Text = "null";
            txtLoaiDG.Text = "null";
            txtEmail.Text = "null";
            txtDiaChi.Text = "null";
            setTextBoxEnabled(false);
        }

        private void setTextBoxEnabled(bool ok)
        {
            txtMaThe.Enabled = ok;
            txtHoTen.Enabled = ok;
            txtLoaiDG.Enabled = ok;
            dtNgaySinh.Enabled = ok;
            txtEmail.Enabled = ok;
            dtNgayLapThe.Enabled = ok;
            txtDiaChi.Enabled = ok;
            
        }

        private void txtDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataSrc = Bus_TimTV.TimTV(txtDocGia.Text);
                if (dataSrc.Rows.Count <= 0)
                {
                    btnSua.Visible = false;
                    dtDanhsach.DataSource = null;
                }
                else
                {
                    dtDanhsach.DataSource = dataSrc;

                }
            }
        }

        private string chuanHoaTen(string key)
        {
            string text = key;
            if (key == "")
                return "";
            while (text.Length > 0 && text.ElementAt(0).ToString() == " ")
            {
                text = text.Remove(0, 1);
            }
            while (text.Length > 0 && text.ElementAt(text.Length - 1).ToString() == " ")
            {
                text = text.Remove(0, 1);
            }

            List<int> kiTuSpace = new List<int>();
            kiTuSpace.Add(0);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == " ")
                {
                    while (text[i + 1].ToString() == " ")
                    {
                        text = text.Remove(i + 1, 1);
                    }
                    kiTuSpace.Add(i + 1);
                }
            }
            text = text.ToLower();
            string newName = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (kiTuSpace.Count > 0 && i == kiTuSpace[0])
                {
                    newName += text[i].ToString().ToUpper();
                    kiTuSpace.RemoveAt(0);
                }
                else
                    newName += text[i].ToString();
            }
            return newName;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            //textBox.SelectAll();
        }

        private void textBox_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = chuanHoaTen(textBox.Text);
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                TextBox txt = (TextBox)sender;
                txt.Text = chuanHoaTen(txt.Text);
                btnCapNhat_Click(sender, e);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setTextBoxEnabled(true);

            btnCapNhat.Visible = true;
            btnHuy.Visible = true;

            dtDanhsach.Enabled = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            txtDocGia.Enabled = false;
        }

        private int hangDuocChon = 0;
        private void dtDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangDuocChon = e.RowIndex;
            if (hangDuocChon >= dataSrc.Rows.Count || hangDuocChon < 0)
                return;

            string theDuocChon = dtDanhsach[0, hangDuocChon].Value.ToString();
            DataTable dt = Bus_TimTV.TraCuuTV(theDuocChon);

            btnSua.Visible = true;
            btnXoa.Visible = true;

            mathe = dt.Rows[0][0].ToString();
            hoten = dt.Rows[0][1].ToString();
            loaidg = dt.Rows[0][2].ToString();
            ngaysinh = dt.Rows[0][3].ToString();
            diachi = dt.Rows[0][4].ToString();
            email = dt.Rows[0][5].ToString();
            ngaylapthe = dt.Rows[0][6].ToString();
            taikhoanno = dt.Rows[0][7].ToString();
            

            txtMaThe.Text = mathe;
            txtHoTen.Text = hoten;
            txtLoaiDG.Text = loaidg;
            txtEmail.Text = email;
            txtDiaChi.Text = diachi;
            dtNgayLapThe.Text = ngaylapthe;
            dtNgaySinh.Text = ngaysinh;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaThe.Text = mathe;
            txtHoTen.Text = hoten;
            txtLoaiDG.Text = loaidg;
            txtEmail.Text = email;
            txtDiaChi.Text = diachi;
            dtNgayLapThe.Text = ngaylapthe;
            dtNgaySinh.Text = ngaysinh;

            setTextBoxEnabled(false);
            dtDanhsach.Enabled = true;

            btnCapNhat.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            txtDocGia.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _mathe = txtMaThe.Text;
            string _hoten = txtHoTen.Text;
            string _email = txtEmail.Text;
            string _diachi = txtDiaChi.Text;
            string _ngaylapthe = dtNgayLapThe.Text;
            string _ngaysinh = dtNgaySinh.Text;
            string _loaidg = txtLoaiDG.Text;

            if (_mathe == "" || _hoten == "" || _email == "" || _diachi == "" || _ngaylapthe == "" ||
                _ngaysinh == "" || _loaidg == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Có chắc chắn cập nhật thông tin của thẻ này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    En_LapThe dg = new En_LapThe(_mathe, _hoten, DateTime.Parse(_ngaysinh), DateTime.Parse(_ngaylapthe), _email, _diachi, _loaidg, int.Parse(taikhoanno));
                    Bus_TimTV.CapNhatTV(dg);
                    MessageBox.Show("Cập nhật thành công");

                    //cap nhat bang dtDachSach
                    dataSrc = Bus_TimTV.TimTV(txtDocGia.Text);
                    dtDanhsach.DataSource = dataSrc;

                    dtDanhsach.Rows[0].Selected = false;
                    dtDanhsach.Rows[hangDuocChon].Selected = true;
                    // hien thi button
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                    dtDanhsach.Enabled = true;
                    btnCapNhat.Visible = false;
                    btnHuy.Visible = false;

                    setTextBoxEnabled(false);

                    txtDocGia.Enabled = true;
                }
                else
                {
                    btnHuy_Click(sender, e);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Có chắc chắn xóa thẻ này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (Bus_TimTV.XoaTV(mathe))
                {
                    txtMaThe.Text = "null";
                    txtHoTen.Text = "null";
                    txtLoaiDG.Text = "null";
                    txtEmail.Text = "null";
                    txtDiaChi.Text = "null";


                    MessageBox.Show("Xóa thành công", "Thông báo");

                    //cap nhat bang dtDachSach
                    dataSrc = Bus_TimTV.TimTV(txtDocGia.Text);
                    dtDanhsach.DataSource = dataSrc;

                    txtDocGia.Focus();
                }

                else
                {
                    MessageBox.Show("Không thể xóa thẻ này", "Thông báo");
                }

            }
        }

        


    }
}
