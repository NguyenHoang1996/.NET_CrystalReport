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
using ValueObject;
using BusinessLayer;
using DataAccessLayer;

namespace Main
{
    public partial class NhanSach : UserControl
    {
        private string maSach;
        private DataTable dtDanhSachDG = new DataTable();
        private static int namXBChoPhep;

        private int triGia = 0; /// tri gia cua cuon sach muon nhap vao
        public NhanSach()
        {
            InitializeComponent();

            open();
        }

        internal static void layThongTinCaiDat()
        {
            namXBChoPhep = CaiDat.caiDatNhanSach();
        }


        internal void open()
        {

            this.Focus();

            List<Control> control = new List<Control>();
            control.Add(txtTenSach);
            control.Add(txtNhaXB);
            control.Add(txtNXB);
            control.Add(cbTheLoai);
            control.Add(txtTacGia);
            control.Add(dtNgayNhap);
            control.Add(txtTriGia);
            control.Add(txtSoLuong);


            ///
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("SACH_Select", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDanhSachDG = new DataTable();
            da.Fill(dtDanhSachDG);
            conn.Close();

            dgvDanhSach.Rows.Clear();
            // update lai dgvDanhSach

            if (dtDanhSachDG.Rows.Count <= 0)
            {
                maSach = "S0001";
                txtMaSach.Text = maSach.ToString();
            }
            else
            {
                string temp = dtDanhSachDG.Rows[dtDanhSachDG.Rows.Count - 1][0].ToString();
                taoMaSach(temp);

               
                /// load database len dgvDAnhSach
                for (int i = 0; i < dtDanhSachDG.Rows.Count; i++)
                {
                    dgvDanhSach.Rows.Add(dtDanhSachDG.Rows[i].ItemArray);
                }


                // sort lai dgvDanhsach 
                dgvDanhSach.Sort(dgvDanhSach.Columns["Column1"], ListSortDirection.Descending);
            }

            txtTenSach.Focus();
            layThongTinCaiDat();
        }


        /*
         input: maPM cuoi cung
         output: maPM ke tiep
         
         
         */
        private void taoMaSach(string lastMaSach)
        {
            lastMaSach = lastMaSach.Remove(0, 1);
            int stt = int.Parse(lastMaSach);
            stt++;
            int l = stt.ToString().Length;
            l = 4 - l;
            string prefix = "S";
            while (l > 0)
            {
                prefix += "0";
                l--;
            }
            maSach = prefix + stt.ToString();
            txtMaSach.Text = maSach.ToString();
        }

      
        private void btNhanSach_Click(object sender, EventArgs e)
        {
            // kiem tra xem co thong tin nao con trong hay khong
            if(txtTenSach.Text == "" || txtNhaXB.Text == "" || txtNXB.Text == "" || txtSoLuong.Text == "" ||
                txtTacGia.Text == "" || txtTriGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }

            // kiem tra xem user co nhap dung NAM XB, Tri Gia, So Luong khong
            int kiemTra = 0;  // = 1 thi NAMXB sai, = 2 thi Tri Gia sai, =3 thi SL sai
            try
            {
                kiemTra = 1;
                int x = int.Parse(txtNXB.Text);
                kiemTra = 2;
                x = int.Parse(txtSoLuong.Text);
                
                
            }
            catch(Exception)
            {
                switch(kiemTra)
                {
                    case 1:
                        MessageBox.Show("Định dạng Năm xuất bản sai, vui lòng nhập lại", "Năm xuất bản");
                        txtNXB.Focus();
                        break;
                    case 2:
                        MessageBox.Show("Định dạng Số lượng bản sai, vui lòng nhập lại", "Số lượng");
                        txtSoLuong.Focus();
                        break;
                }
                return;
            }
            // kiem tra xem so luong phải lớn hơn 0
            if(int.Parse(txtSoLuong.Text) <=0)
            {
                MessageBox.Show("Sô lượng nhập sách phải lớn hơn 0", "Số lượng");
                txtSoLuong.Focus();
                return;
            }
            // kiem tra xem Tri Gia sach co dung hay khong, triGia phai > 0
            if(triGia <= 0)
            {
                MessageBox.Show("Trị giá sách không hợp lệ, vui lòng nhập lại", "Trị giá");
                txtTriGia.Focus();
                return;
            }
            // kiem tra xem user nhap THE LOAI co trung hay khong
            if (!cbTheLoai.Items.Contains(cbTheLoai.Text.ToUpper()))
            {
                MessageBox.Show("Không có thể loại " + cbTheLoai.Text +" , vui lòng kiểm tra và nhập lại", "Thể loại");
                cbTheLoai.Focus();
                return;
            }

            
            // kiem tra NAM XUAT BAN qui dinh
            // vi chi nhap NamXB cua SACH nen:  nam hien tai - NAMXB

            if (int.Parse(dtNgayNhap.Text.Remove(0, dtNgayNhap.Text.LastIndexOf("/") + 1)) - int.Parse(txtNXB.Text) > namXBChoPhep)
            {
                MessageBox.Show("Chỉ nhận sách trong vòng " + namXBChoPhep + " năm", "Thông báo");
                txtNXB.Focus();
                return;
            }

            string masach = txtMaSach.Text;
            string tensach = txtTenSach.Text;
            string nhaxb = txtNhaXB.Text;
            int nxb = int.Parse(txtNXB.Text.ToString());
            string theloai = cbTheLoai.Text;
            string tacgia = txtTacGia.Text;
            DateTime ngaynhap = DateTime.Parse(dtNgayNhap.Value.ToString());
            int soLuong = int.Parse(txtSoLuong.Text);

            En_NhanSach s = new En_NhanSach(masach, tensach, theloai, tacgia, nhaxb, nxb, triGia, ngaynhap, soLuong);
            Bus_NhanSach.ThemSach(s);
            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            

            // them 1 row vao dgvDanhsach
            string[] row = new string[]{txtMaSach.Text, txtTenSach.Text, cbTheLoai.Text, txtTacGia.Text, txtNhaXB.Text, txtNXB.Text, txtTriGia.Text ,  dtNgayNhap.Text, txtSoLuong.Text};
            dgvDanhSach.Rows.Add(row);
            
            // sort lai dgvDanhsach de row minh vua nhap dung o dau table
            dgvDanhSach.Sort(dgvDanhSach.Columns["Column1"], ListSortDirection.Descending);
            
           
            /// tao lai ma Sach
            taoMaSach(maSach);
            // reset lai tat ca cac textbox
            btTaoLai_Click(sender, e);
            // focus lai textbox ten sach
            txtTenSach.Focus();
        }

        private void btTaoLai_Click(object sender, EventArgs e)
        {

            txtTenSach.Clear();
            txtNhaXB.Clear();
            txtNXB.Clear();
            txtTacGia.Clear();
            txtTriGia.Clear();
            cbTheLoai.Text = "";
            dtNgayNhap.Text = "";
            txtSoLuong.Clear();
           
        }

        private string chuanHoaTen(string key)
        {
            string text = key;
            if (key == "")
                return "";
            while (text.Length > 0 &&  text.ElementAt(0).ToString() == " ")
            {
                text = text.Remove(0, 1);
            }
            while (text.Length > 0 &&  text.ElementAt(text.Length - 1).ToString() == " ")
            {
                text = text.Remove(text.Length - 1, 1);
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

        
        private void txtTacGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /// chuan hoa ten
                txtTacGia.Text = chuanHoaTen(txtTacGia.Text);
                txtNhaXB.Focus();
            }
        }

        private void txtTenSach_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                /// chuan hoa ten
                txtTenSach.Text = chuanHoaTen(txtTenSach.Text);
                
                if(e.KeyCode == Keys.Enter)
                    txtTacGia.Focus();
            }
        }

        private void txtNhaXB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                /// chuan hoa ten
                txtNhaXB.Text = chuanHoaTen(txtNhaXB.Text);
                if (e.KeyCode == Keys.Enter)
                   txtNXB.Focus();
            }
        }

        private void txtNXB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbTheLoai.Focus();
        }

        private void cbTheLoai_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                /// chuan hoa ten
                cbTheLoai.Text = cbTheLoai.Text.ToUpper();
                if (e.KeyCode == Keys.Enter)
                    dtNgayNhap.Focus();
            }
            
        }

        private void txtTacGia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                /// chuan hoa ten
                txtTacGia.Text = chuanHoaTen(txtTacGia.Text);
                if (e.KeyCode == Keys.Enter)
                    txtNhaXB.Focus();
            }
        }

        private void dtNgayNhap_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
                txtTriGia.Focus();
        }

        private void txtTriGia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // luu triGia 
                try
                {
                    triGia = int.Parse(txtTriGia.Text);

                    // tu dong hien thi them dau cham
                    string text = "";
                    for (int i = 1; i <= txtTriGia.Text.Length; i++)
                    {
                        text += txtTriGia.Text[i - 1].ToString();
                        if ((txtTriGia.Text.Length - i) % 3 == 0 && i != txtTriGia.Text.Length)
                            text += ".";
                    }

                    txtTriGia.Text = text;
                }
                catch(Exception)
                {

                }

                
                if (e.KeyCode == Keys.Enter)
                    txtSoLuong.Focus();   
            }
        }

        private void txtSoLuong_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btNhanSach.Focus();
        }

        
    }
}
