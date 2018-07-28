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
using DataAccessLayer;
using BusinessLayer;
namespace Main
{
    public partial class MuonSach : UserControl
    {

        private DateTime ngayMuon;
        private DateTime hanTra;
        private string maPM;
        private static int soLuongSachDuocMuon;   // La so sach toi da ma DG co the muon, duoc qui dinh trong phan CaiDat
        private int soLuongSachDaMuon;  // la so sach ma DG da muon truoc do ma chua tra
        private int soLuongSachCoTheDuocMuon;  // la so sach ma lan muon nay DG co the muon: soLuongSachCoTheDuocMuon = soLuongSachDuocMuon - soLuongSachDaMuon

        private static int thoiHanTheQuiDinh;
        private static int tienNoQuiDinh;
        private static int soNgayMuonQuiDinh;
     
        private int tienNo = 0; // tien no cua DOC GIA

        internal void open()
        {
            this.Focus();
            cbMaThe.Focus();

            layThongTinCaiDat();

            ngayMuon = DateTime.Today;
            TimeSpan soNgayDuocMuon = new TimeSpan(soNgayMuonQuiDinh, 0, 0, 0);
            hanTra = ngayMuon + soNgayDuocMuon;
            dtNgayMuon.Text = ngayMuon.ToShortDateString();
            dtHanTra.Text = hanTra.ToShortDateString();
        }

        internal static void layThongTinCaiDat()
        {
            List<int> caiDat= CaiDat.caiDatMuonSach();
            soLuongSachDuocMuon = caiDat[0];
            soNgayMuonQuiDinh = caiDat[1];
            tienNoQuiDinh = caiDat[2];
            thoiHanTheQuiDinh = caiDat[3];
        }
      
        
        public MuonSach()
        {
            InitializeComponent();
            

            // Tinh maPT
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUMUON_SELECT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count <= 0)
            {
                maPM = "M0001";
            }
            else
            {
                string temp = dt.Rows[dt.Rows.Count - 1][0].ToString();
                taoMaPM(temp);
            }
        }

        /*
         input: maPM cuoi cung
         output: maPM ke tiep
         
         
         */
        private void taoMaPM(string lastMaPM)
        {
            lastMaPM = lastMaPM.Remove(0, 1);
            int stt = int.Parse(lastMaPM);
            stt++;
            int l = stt.ToString().Length;
            l = 4 - l;
            string prefix = "M";
            while (l > 0)
            {
                prefix += "0";
                l--;
            }
            maPM = prefix + stt.ToString();
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            cbMaThe.Focus();
            txtSach.Clear();
            txtNgaylapthe.Clear();
            txtNgaysinh.Clear();
            txtHoTen.Clear();
            txtLoaiDG.Clear();
            txtSoSachDaMuon.Clear();

            listResult.Items.Clear();
        }


        private void hienThiThongTinSach()
        {
            listResult.Items.Clear();
            btnMuon.Focus();
            DataTable dt = Bus_MuonSach.TimKiemSach(txtSach.Text);
            // dt gồm 5 cột: |  mã sách |  tên sách    |   tác giả |   thể loại    |   tình trạng (số lượng)   |
            if (dt.Rows.Count <= 0)
            {
                ListViewItem item = new ListViewItem("Không có dữ liệu");
                listResult.Items.Add(item);
                txtSach.SelectAll();
                txtSach.Focus();
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string maSach = dt.Rows[i][0].ToString();
                    string tenSach = dt.Rows[i][1].ToString();
                    string tacGia = dt.Rows[i][2].ToString();
                    string theLoai = dt.Rows[i][3].ToString();
                    int soLuong = int.Parse(dt.Rows[i][4].ToString());
                    // những sách nào có số lượng = 0 thì sẽ k hiển thị

                    if (soLuong > 0)
                    {
                        ListViewItem item = new ListViewItem(tenSach);
                        ListViewItem.ListViewSubItem[] subItem = new ListViewItem.ListViewSubItem[]{
                            new ListViewItem.ListViewSubItem(item, tacGia),
                            new ListViewItem.ListViewSubItem(item, theLoai),
                            new ListViewItem.ListViewSubItem(item, soLuong.ToString())
                        };

                        item.SubItems.AddRange(subItem);
                        item.Tag = maSach;
                        listResult.Items.Add(item);
                    }
                }
            }
        }
        
        private void txtSach_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                hienThiThongTinSach();
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            String maThe = cbMaThe.SelectedValue.ToString();
            String sach = txtSach.Text;


            List<ListViewItem> sachDuocChon = new List<ListViewItem>();  ///sachDuocChon la những sách đc check
            foreach(ListViewItem item in listResult.Items)
            {
                if (item.Checked)
                    sachDuocChon.Add(item);
            }


            if (txtHoTen.Text == "null")  /// kiem tra xem user da nhap MaThe hay chua, neu chua nhap thi txtHoten ben bang thong tin DG k co gi het (= mull)
            {
                if(cbMaThe.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã thẻ");
                }
                else
                {
                    MessageBox.Show("Mã thẻ không hợp lệ, vui lòng nhập lại");
                }

                cbMaThe.Focus();
                return;
            }

            if(sachDuocChon.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sách");
                return;
            }

            if (sachDuocChon.Count > ( soLuongSachDuocMuon - int.Parse(txtSoSachDaMuon.Text) ))  // số lượng tối đa khi chọn sach
            {
                if (soLuongSachCoTheDuocMuon == 5)
                    MessageBox.Show("Chỉ được mượn tối đa " + soLuongSachDuocMuon.ToString() + " cuốn sách", "Quá số lượng sách qui định");
                else if (soLuongSachCoTheDuocMuon == 0)
                    MessageBox.Show("Đọc giả " + txtHoTen.Text + " đã mượn đúng với số lượng qui định", "Thông báo");
                else
                    MessageBox.Show("Đọc giả " + txtHoTen.Text + " đã mượn " + soLuongSachDaMuon.ToString() + " cuốn sách\nBây giờ chỉ được mượn tối đa " +
                       soLuongSachCoTheDuocMuon.ToString() + " cuốn", "Quá số lượng sách qui định");
                return;
            }

            // kiem tra xem co qua han su dung the khong
            TimeSpan soNgaySuDungThe = DateTime.Today - DateTime.Parse(txtNgaylapthe.Text);
            float thangSuDungThe = soNgaySuDungThe.Days / 30;
            if(thangSuDungThe > thoiHanTheQuiDinh)
            {
                MessageBox.Show("Thẻ đã quá hạn", "Thông báo");
                cbMaThe.SelectAll();
                cbMaThe.Focus();
                return;
            }

            /// kiem tra xem so tien no cua doc gia co lon hon so voi qui dinh hay khong
            if(tienNo > tienNoQuiDinh)
            {
                MessageBox.Show("Số tiền nợ của " + txtHoTen.Text + " đã vượt quá qui định:  " + tienNo.ToString() + " VND" , "Thông báo");
                return;
            }

            string tenSachDuocMuon = "";
            List<string> maSachDuocMuon = new List<string>();
            foreach(ListViewItem item in sachDuocChon)
            {
                if(Bus_MuonSach.SachDaMuon(cbMaThe.SelectedValue.ToString(), (string)item.Tag))
                {
                    MessageBox.Show("Không được mượn sách này\nSách này đang mượn", "Thông báo");
                    
                }
                else
                {
                    tenSachDuocMuon += "\n" + item.Text;
                    maSachDuocMuon.Add((string)item.Tag);
                    En_MuonSach ms = new En_MuonSach(maPM, maThe.ToUpper(), (string)item.Tag, ngayMuon, hanTra);
                    Bus_MuonSach.MuonSach(ms);

                    // tạo lại maPM
                    taoMaPM(maPM);
                }

                
            }

            if(tenSachDuocMuon != "")
            {
                MessageBox.Show("Mượn thành công: " + tenSachDuocMuon);

                // giam so luong sach
                foreach(var masach in maSachDuocMuon)
                {
                    Bus_MuonSach.Giam_SLSACH(masach);
                }
            }
            txtSoSachDaMuon.Text = Bus_MuonSach.SoSachDaMuon(cbMaThe.SelectedValue.ToString()).ToString();
            soLuongSachDaMuon = int.Parse(txtSoSachDaMuon.Text);
            soLuongSachCoTheDuocMuon = soLuongSachDuocMuon - soLuongSachDaMuon;
            

            // update lai bang hien thi thong tin sach
            hienThiThongTinSach();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            hienThiThongTinSach();
            DataTable dt = Bus_LapThe.ChonThe();
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Hệ thống chưa có thẻ đọc giả nào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                cbMaThe.DataSource = dt;
                cbMaThe.DisplayMember = "MaThe";
                cbMaThe.ValueMember = "MaThe";
            }
            
        }

        private void cbMaThe_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            //{
            /// kiểm tra xem đọc giả này đã đăng kí thành viên chưa

            DataTable dt = Bus_MuonSach.ThongTinDocGia(cbMaThe.SelectedValue.ToString());

            if (dt.Rows.Count > 0)
            {
                // hien thi qua bang thong tin doc gia

                string hoten = dt.Rows[0][1].ToString();
                string x = dt.Rows[0][3].ToString();
                string ngaysinh = DateTime.Parse(dt.Rows[0][3].ToString()).ToShortDateString();
                string loaidocgia = dt.Rows[0][2].ToString();
                string ngaylapthe = DateTime.Parse(dt.Rows[0][6].ToString()).ToShortDateString();
                soLuongSachDaMuon = Bus_MuonSach.SoSachDaMuon(cbMaThe.SelectedValue.ToString());
                soLuongSachCoTheDuocMuon = soLuongSachDuocMuon - soLuongSachDaMuon;
                tienNo = int.Parse(dt.Rows[0][7].ToString());


                txtHoTen.Text = hoten;
                txtNgaysinh.Text = ngaysinh;
                txtLoaiDG.Text = loaidocgia;
                txtNgaylapthe.Text = ngaylapthe;
                txtSoSachDaMuon.Text = soLuongSachDaMuon.ToString();

                //if (e.KeyCode == Keys.Enter) // neu keycode == enter thi phai txtsach duoc focus
                //    txtSach.Focus();
            }
            else
            {
                //MessageBox.Show("Mã thẻ này chưa phải là thành viên");
                //txtMathe.SelectAll();
                //txtMathe.Focus();

                txtHoTen.Text = "null";
                txtNgaysinh.Text = "null";
                txtLoaiDG.Text = "null";
                txtNgaylapthe.Text = "null";
                txtSoSachDaMuon.Text = "null";

                //if (e.KeyCode == Keys.Enter)
                //    txtSach.Focus();
            }



        }

        private void cbMaThe_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = Bus_LapThe.ChonThe();
            cbMaThe.DataSource = dt;
            cbMaThe.DisplayMember = "MaThe";
            cbMaThe.ValueMember = "MaThe";
        }
    }
}
