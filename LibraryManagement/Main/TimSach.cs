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
    public partial class TimSach : UserControl
    {
        private DataTable dataSrc = new DataTable();
        string masach;
        string tensach;
        string theloai;
        string tacgia;
        string nhaxb;
        string namxb;
        string trigia;
        string ngaynhap;
        string soluong;

        internal void open()
        {
            this.Focus();
            //datatable mac dinh se hien thi tat ca cac sach ma thu vien hien co
            dataSrc = Bus_TimSach.TimSach("");
            dtDanhsach.DataSource = dataSrc;
            txtSach.Focus();
        }

        public TimSach()
        {
            InitializeComponent();

            txtMaSach.Text = "null";
            txtTenSach.Text = "null";
            txtTacGia.Text = "null";
            txtNhaXB.Text = "null";
            txtNamXB.Text = "null";
            //txtNgayNhap.Text = "0/0/0";
            txtTriGia.Text = "null";
            txtTheLoai.Text = "null";
            txtSoLuong.Text = "null";

            setTextBoxEnabled(false);
            
            btnCapNhat.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }

        private void setTextBoxEnabled(bool ok)
        {
            bool x = !ok;
            txtMaSach.Enabled = ok;
            txtTenSach.Enabled = ok;
            txtTacGia.Enabled = ok;
            txtNhaXB.Enabled = ok;
            txtNamXB.Enabled = ok;
            txtNgayNhap.Enabled = ok;
            txtTriGia.Enabled = ok;
            txtTheLoai.Enabled = ok;
            txtSoLuong.Enabled = ok;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setTextBoxEnabled(true);

            btnCapNhat.Visible = true;
            btnHuy.Visible = true;

            dtDanhsach.Enabled = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;

            txtSach.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = masach;
            txtTenSach.Text = tensach;
            txtTheLoai.Text = theloai;
            txtTacGia.Text = tacgia;
            txtNhaXB.Text = nhaxb;
            txtNamXB.Text = namxb;
            txtTriGia.Text = trigia;
            txtSoLuong.Text = soluong;
            txtNgayNhap.Text = ngaynhap;

            setTextBoxEnabled(false);
            dtDanhsach.Enabled = true;

            btnCapNhat.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = true;
            btnXoa.Visible = true;

            txtSach.Enabled = true;
        }

        private void txtSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataSrc = Bus_TimSach.TimSach(txtSach.Text);
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

        private int hangDuocChon = 0;
        private void dtDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangDuocChon = e.RowIndex;
            if (hangDuocChon >= dataSrc.Rows.Count || hangDuocChon < 0)
                return;

            string sachDuocChon = dtDanhsach[0, hangDuocChon].Value.ToString();
            DataTable dt = Bus_TimSach.TraCuuSach(sachDuocChon);

            btnSua.Visible = true;
            btnXoa.Visible = true;

             masach = dt.Rows[0][0].ToString();
             tensach = dt.Rows[0][1].ToString();
             theloai = dt.Rows[0][2].ToString();
             tacgia = dt.Rows[0][3].ToString();
             nhaxb = dt.Rows[0][4].ToString();
             namxb = dt.Rows[0][5].ToString();
             trigia = dt.Rows[0][6].ToString();
             ngaynhap = dt.Rows[0][7].ToString();
             soluong = dt.Rows[0][8].ToString();

            txtMaSach.Text = masach;
            txtTenSach.Text = tensach;
            txtTheLoai.Text = theloai;
            txtTacGia.Text = tacgia;
            txtNhaXB.Text = nhaxb;
            txtNamXB.Text = namxb;
            txtTriGia.Text = trigia;
            txtSoLuong.Text = soluong;
            txtNgayNhap.Text = ngaynhap;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _masach =  txtMaSach.Text;
            string _tensach = txtTenSach.Text;
            string _theloai = txtTheLoai.Text;
            string _tacgia = txtTacGia.Text;
            string _nhaxb = txtNhaXB.Text;
            string _namxb = txtNamXB.Text;
            string _trigia = txtTriGia.Text;
            string _soluong = txtSoLuong.Text;
            string _ngayNhap = txtNgayNhap.Text;
            
            if(_masach == "" || _tensach == "" || _theloai == "" || _tacgia == "" || _nhaxb == "" || 
                _namxb == "" || _trigia == "" || _soluong == "" || _ngayNhap == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Có chắc chắn cập nhật thông tin của sách này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    En_NhanSach sach = new En_NhanSach(_masach, _tensach, _theloai, _tacgia, _nhaxb, int.Parse(_namxb), int.Parse(_trigia), DateTime.Parse(_ngayNhap), int.Parse(_soluong));
                    Bus_TimSach.CapNhatSach(sach);
                    MessageBox.Show("Cập nhật thành công");

                    //cap nhat bang dtDachSach
                    dataSrc = Bus_TimSach.TimSach(txtSach.Text);
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

                    txtSach.Enabled = true;
                }
                else
                {
                    btnHuy_Click(sender, e);
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
            if(e.KeyCode == Keys.Enter)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Có chắc chắn xóa sách này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if(Bus_TimSach.XoaSach(masach))
                {
                    txtMaSach.Text = "null";
                    txtTenSach.Text = "null";
                    txtTacGia.Text = "null";
                    txtNhaXB.Text = "null";
                    txtNamXB.Text = "null";
                    //txtNgayNhap.Text = "0/0/0";
                    txtTriGia.Text = "null";
                    txtTheLoai.Text = "null";
                    txtSoLuong.Text = "null";


                    MessageBox.Show("Xóa thành công", "Thông báo");

                    //cap nhat bang dtDachSach
                    dataSrc = Bus_TimSach.TimSach(txtSach.Text);
                    dtDanhsach.DataSource = dataSrc;

                    txtSach.Focus();
                }

                else
                {
                    MessageBox.Show("Không thể xóa sách này", "Thông báo");
                }
                
            }
            
        }


        
    }
}
