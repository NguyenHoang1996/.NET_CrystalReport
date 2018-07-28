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
    
    public partial class TraSach : UserControl
    {
        internal void open()
        {
            ckbChonTatCa.Checked = false;
            this.Focus();
            cbMaThe.Focus();

            //txtHoTen.Text = "null";
            //txtNgaysinh.Text = "null";
            //txtLoaiDG.Text = "null";
            //txtNgaylapthe.Text = "null";
        }

        private string maPT;
        private TimeSpan soNgayMuon;
        private TimeSpan soNgayTre;
        private DateTime ngayTra = DateTime.Today;
        private int tienNo;   // la tien no truoc do cua DOCGIA ( chua tinh luc dang trả sách lần này)
        private int tongNo;   // à tổng nợ bao gồm tiền phạt kỳ này + tiền nợ trc đó của đọc giả
        private int tongTienPhat;

        public TraSach()
        {
            InitializeComponent();

            // disable Chon tat ca
            ckbChonTatCa.Enabled = false;

            // Tinh maPT
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUTRA_SELECT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
               
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count <= 0)
            {
                maPT = "T0001";
            }
            else
            {
                string temp = dt.Rows[dt.Rows.Count - 1][0].ToString();
                taoMaPT(temp);
            }
        }

        /*
         input: MaPT cuoi cung
         output: MaPT ke tiep
         
         
         */
        private void taoMaPT(string lastMaPT)
        {
            lastMaPT = lastMaPT.Remove(0, 1);
            int stt = int.Parse(lastMaPT);
            stt++;
            int l = stt.ToString().Length;
            l = 4 - l;
            string prefix = "T";
            while (l > 0)
            {
                prefix += "0";
                l--;
            }
            maPT = prefix + stt.ToString();
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            cbMaThe.Focus();

            lbTienPhat.Text = "0";
            lbTongNo.Text = "0";
            ckbChonTatCa.Checked = false;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            String maThe = cbMaThe.SelectedValue.ToString();

            if(maThe == "")  /// kiem tra xem user da nhap MaThe hay chua
            {
                MessageBox.Show("Vui lòng nhập mã thẻ");
                return;
            }

            List<ListViewItem> sachCanTra = new List<ListViewItem>();  // danh sach SACH can tra
            
            string tenSachCanTra = "";
            foreach(ListViewItem item in listResult.Items)
            {
                if (item.Checked)
                    sachCanTra.Add(item);
            }
            
            if(sachCanTra.Count <= 0)   // kiem tra xem user da check vao sach can duoc tra chua
            {
                MessageBox.Show("Vui lòng chọn sách cần trả");
                return;
            }


            List<string> maSachDuocTra = new List<string>();

            foreach(ListViewItem item in sachCanTra)
            {
                ThongTinSachMuon tts = (ThongTinSachMuon)item.Tag;
                En_TraSach traSach = new En_TraSach(maPT, tts.MaPM, soNgayMuon.Days, soNgayTre.Days, tongTienPhat.ToString(), ngayTra);
                Bus_TraSach.TraSach(traSach);

                // update lại tài khoản nợ của đọc giả
                Bus_TraSach.TaiKhoanNo_update(cbMaThe.SelectedValue.ToString(), tongNo.ToString());

                taoMaPT(maPT);
                tenSachCanTra += "\n" + item.Text;
                maSachDuocTra.Add(tts.MaSach);

                // xoa trong listResult
                item.Remove();

                // update lại tổng tiền nợ, tổng tiền phạt
                tongTienPhat = 0;
                tongNo = Bus_TraSach.LayTienNo(cbMaThe.SelectedValue.ToString());
                lbTienPhat.Text = hienThiGiaTri(tongTienPhat.ToString());
                lbTongNo.Text = hienThiGiaTri(tongNo.ToString());
            }
            if (tenSachCanTra != "")
            {
                MessageBox.Show("Đã trả thành công:" + tenSachCanTra);
                ckbChonTatCa.Checked = false;
                /// tang so luong sach duoc tra
                foreach(var masach in maSachDuocTra)
                {
                    Bus_TraSach.Tang_SLSACH(masach);
                }
            }

        }

        private void ckbChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbChonTatCa.Checked)  // da check -> bỏ check
            {
                foreach(ListViewItem item in listResult.Items)
                {
                    item.Checked = true;
                }
            }
            else  // chưa check  -> check
            {
                foreach (ListViewItem item in listResult.Items)
                {
                    item.Checked = false;
                }
            }
        }

        private void listResult_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (listResult.Items[e.Index].Checked) 
            {
                // từ trạng thái check qua uncheck
                // Giam tien phat dự kiến trong lần trả này nếu sách đó trả quá hạn
                ThongTinSachMuon tts = (ThongTinSachMuon)listResult.Items[e.Index].Tag;
                tongTienPhat -= tts.TienPhat;
                tongNo -= tts.TienPhat;
                lbTienPhat.Text = hienThiGiaTri(tongTienPhat.ToString());
                lbTongNo.Text = hienThiGiaTri(tongNo.ToString());
            }
            else   
            {
                // từ trạng thái uncheck qua check
                // tăng tien phat dự kiến trong lần trả này nếu sách đó trả quá hạn
                ThongTinSachMuon tts = (ThongTinSachMuon)listResult.Items[e.Index].Tag;
                tongTienPhat += tts.TienPhat;
                tongNo += tts.TienPhat;
                lbTienPhat.Text = hienThiGiaTri(tongTienPhat.ToString());
                lbTongNo.Text = hienThiGiaTri(tongNo.ToString());
            }
        }


        private string hienThiGiaTri(string src)
        {
            string text = "";
            for (int i = 1; i <= src.Length; i++)
            {
                text += src[i - 1].ToString();
                if ((src.Length - i) % 3 == 0 && i != src.Length)
                    text += ".";
            }
            return text;
        }

        private int layGiaTri(string src)
        {
            
            while(src.Contains("."))
            {
                src.Remove(src.LastIndexOf("."), 1);
            }


            return int.Parse(src);
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            DataTable dt = Sql_MuonSach.SelectMaThe();
            if(dt.Rows.Count<=0)
                MessageBox.Show("Chưa có đọc giả nào mượn sách!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                cbMaThe.DataSource = dt;
                cbMaThe.DisplayMember = "MaThe";
                cbMaThe.ValueMember = "MaThe";
            }
            
        }

        private void cbMaThe_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)  // nhap xong MATHE
            //{
                //hien thi thong tin qua BANG THONG TIN

            DataTable dttable = Bus_MuonSach.ThongTinDocGia(cbMaThe.SelectedValue.ToString());

            if (dttable.Rows.Count > 0)
            {
                // hien thi qua bang thong tin doc gia

                string hoten = dttable.Rows[0][1].ToString();
                string ngaysinh = DateTime.Parse(dttable.Rows[0][3].ToString()).ToShortDateString();
                string loaidocgia = dttable.Rows[0][2].ToString();
                string ngaylapthe = DateTime.Parse(dttable.Rows[0][6].ToString()).ToShortDateString();

                txtHoTen.Text = hoten;
                txtNgaysinh.Text = ngaysinh;
                txtLoaiDG.Text = loaidocgia;
                txtNgaylapthe.Text = ngaylapthe;

            }
            else
            {
                txtHoTen.Text = "'Mã thẻ không tồn tại'";
                txtNgaysinh.Text = "'Mã thẻ không tồn tại'";
                txtLoaiDG.Text = "'Mã thẻ không tồn tại'";
                txtNgaylapthe.Text = "'Mã thẻ không tồn tại'";
            }
            // tính tiền nợ
            tienNo = Bus_TraSach.LayTienNo(cbMaThe.SelectedValue.ToString());
            lbTongNo.Text = hienThiGiaTri(tienNo.ToString());
            tongNo = tienNo;
            //// tao lai listResult
            listResult.Items.Clear();

            //load du lieu tu PHIEUMUON len listView

            DataTable dt = Bus_TraSach.ThongTinSachMuon(cbMaThe.SelectedValue.ToString());

            ///data table gom 4 cot: |   MaPM  |   TenSach |   NgayMuon    |   HanTra  |
            if (dt.Rows.Count <= 0)
            {
                ListViewItem item = new ListViewItem("Không có dữ liệu");
                listResult.Items.Add(item);
                ckbChonTatCa.Enabled = false;
            }
            else
            {
                ckbChonTatCa.Enabled = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string stt = "";
                    DateTime ngayMuon = DateTime.Parse(dt.Rows[i][3].ToString());
                    DateTime hanTra = DateTime.Parse(dt.Rows[i][4].ToString());
                    int tienPhat = 0;
                    soNgayMuon = ngayTra - ngayMuon;

                    if (ngayTra > DateTime.Parse(dt.Rows[i][4].ToString()))  // qua han
                    {
                        soNgayTre = ngayTra - hanTra;
                        stt = "Quá hạn " + soNgayTre.Days.ToString() + " ngày";
                        tienPhat = soNgayTre.Days * 1000;
                    }
                    else // chua quá hạn
                    {

                        var soNgayConLai = hanTra - ngayTra;
                        stt = "Còn lại " + soNgayConLai.Days.ToString() + " ngày";
                    }

                    ListViewItem item = new ListViewItem(dt.Rows[i][2].ToString());
                    ListViewItem.ListViewSubItem[] subItem = new ListViewItem.ListViewSubItem[]{
                            new ListViewItem.ListViewSubItem(item, DateTime.Parse(dt.Rows[i][3].ToString()).ToShortDateString()),
                            new ListViewItem.ListViewSubItem(item, DateTime.Parse(dt.Rows[i][4].ToString()).ToShortDateString()),
                            new ListViewItem.ListViewSubItem(item, stt)
                            };

                    item.SubItems.AddRange(subItem);
                    item.Tag = new ThongTinSachMuon(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), tienPhat);
                    listResult.Items.Add(item);
                }


            }
        }

        private void cbMaThe_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = Sql_MuonSach.SelectMaThe();
            cbMaThe.DataSource = dt;
            cbMaThe.DisplayMember = "MaThe";
            cbMaThe.ValueMember = "MaThe";
        }


    }

    public class ThongTinSachMuon
    {
        string _MaPM;

        public String MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }

        string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }

        int _TienPhat;

        public int TienPhat
        {
            get { return _TienPhat; }
            set { _TienPhat = value; }
        }

        

        public ThongTinSachMuon(string maPM, string maSach, int tienPhat)
        {
            MaPM = maPM;
            MaSach = maSach;
            TienPhat = tienPhat;
        }
    }
}
