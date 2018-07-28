using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ValueObject;
namespace Main
{
    public partial class CaiDat : Form
    {
        private DataTable dt;
        private int STT;
        public CaiDat()
        {
            InitializeComponent();

            LoadDatabase();
        }

        private void LoadDatabase()
        {
            dt = Bus_CaiDat.CaiDat_select();
            int max = dt.Rows.Count - 1;
            STT = int.Parse(dt.Rows[max][0].ToString());

            txtTuoiToiThieu.Text = dt.Rows[max][1].ToString();
            txtTuoiToiDa.Text = dt.Rows[max][2].ToString();
            txtThoiHanThe.Text = dt.Rows[max][3].ToString();
            txtNamXB.Text = dt.Rows[max][4].ToString();
            txtSoSachMuon.Text = dt.Rows[max][5].ToString();
            txtSoNgayMuon.Text = dt.Rows[max][6].ToString();


            txtSoTienNo.Text = hienThiGiaTri(dt.Rows[max][7].ToString());
        }

        private bool dragging = false; // cho biet co dang move hay k
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtTuoiToiThieu.Text = dt.Rows[0][1].ToString();
            txtTuoiToiDa.Text = dt.Rows[0][2].ToString();
            txtThoiHanThe.Text = dt.Rows[0][3].ToString();
            txtNamXB.Text = dt.Rows[0][4].ToString();
            txtSoSachMuon.Text = dt.Rows[0][5].ToString();
            txtSoNgayMuon.Text = dt.Rows[0][6].ToString();

            // hien thi them dấu .  cho tiền nợ

            txtSoTienNo.Text = hienThiGiaTri(dt.Rows[0][7].ToString());

            //int tuoiToiThieu = int.Parse(txtTuoiToiThieu.Text);
            //int tuoiToiDa = int.Parse(txtTuoiToiDa.Text);
            //int thoiHanThe = int.Parse(txtThoiHanThe.Text);
            //int namXB = int.Parse(txtNamXB.Text);
            //int soSachMuon = int.Parse(txtSoSachMuon.Text);
            //int soNgayMuon = int.Parse(txtSoNgayMuon.Text);
            //int soTienNo = int.Parse(txtSoTienNo.Text);
            //En_CaiDat caidat = new En_CaiDat(tuoiToiThieu, tuoiToiDa, thoiHanThe, namXB, soSachMuon, soNgayMuon, soTienNo, DateTime.Today);
            //Bus_CaiDat.CaiDat_insert(caidat);
            //MessageBox.Show("Thiết lập thành công");
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTuoiToiThieu.Text == "" || txtTuoiToiDa.Text == "" ||txtThoiHanThe.Text == "" ||txtNamXB.Text == "" ||
                txtSoSachMuon.Text == "" ||txtSoNgayMuon.Text == "" ||txtSoTienNo.Text == "")
            {
                MessageBox.Show("Vui lòng thiết lập đầy đủ thông tin");
            }
            else
            {
                int tuoiToiThieu = int.Parse(txtTuoiToiThieu.Text);
                int tuoiToiDa = int.Parse(txtTuoiToiDa.Text);
                int thoiHanThe = int.Parse(txtThoiHanThe.Text);
                int namXB = int.Parse(txtNamXB.Text);
                int soSachMuon = int.Parse(txtSoSachMuon.Text);
                int soNgayMuon  =int.Parse(txtSoNgayMuon.Text);

                string text = txtSoTienNo.Text;
                while (text.Contains("."))  /// xoa het dấu . trong txtSotienno
                {
                    text = text.Remove(text.LastIndexOf("."), 1);
                }
                int soTienNo = int.Parse(text);

                // neu txtSoTienNo khong co chua dấu chấm thì hiện thị lên ( trường hợp user vừa mới nhập tiền nợ và lưu luôn)
                if (!txtSoTienNo.Text.Contains("."))
                    txtSoTienNo.Text = hienThiGiaTri(txtSoTienNo.Text);

                En_CaiDat caidat = new En_CaiDat(++STT, tuoiToiThieu, tuoiToiDa, thoiHanThe, namXB, soSachMuon, soNgayMuon, soTienNo, DateTime.Today);
                Bus_CaiDat.CaiDat_insert(caidat);
                MessageBox.Show("Thiết lập thành công");
                STT++;

                MuonSach.layThongTinCaiDat();
                NhanSach.layThongTinCaiDat();
                LapThe.layThongTinCaiDat();
            }
        }
        static DataTable caiDat = Bus_CaiDat.CaiDat_select();

        public static List<int> caiDatMuonSach()
        {
            DataTable caiDatTable = Bus_CaiDat.CaiDat_select();
            List<int> caiDat = new List<int>();
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][5].ToString()));  // so sach duoc muon
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][6].ToString()));  // so ngay duoc muon
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][7].ToString()));  // tien no qui dinh
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][3].ToString()));  // thoi han the


            return caiDat;
        }

        public static int caiDatNhanSach()
        {
            DataTable caiDatTable = Bus_CaiDat.CaiDat_select();
            return int.Parse(caiDat.Rows[caiDat.Rows.Count - 1][4].ToString());   // nam xuat ban qui dinh
        }

        public static List<int> caiDatLapThe()
        {
            DataTable caiDatTable = Bus_CaiDat.CaiDat_select();
            List<int> caiDat = new List<int>();
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][1].ToString()));  // tuoi toi thieu
            caiDat.Add(int.Parse(caiDatTable.Rows[caiDatTable.Rows.Count - 1][2].ToString()));  // tuoi toi da
          
            return caiDat;
        }


     

        private void txtTuoiToiThieu_Click(object sender, EventArgs e)
        {
            txtTuoiToiThieu.SelectAll();
        }

        private void txtTuoiToiDa_Click(object sender, EventArgs e)
        {
            txtTuoiToiDa.SelectAll();
        }

        private void txtThoiHanThe_Click(object sender, EventArgs e)
        {
            txtThoiHanThe.SelectAll();
        }

        private void txtNamXB_Click(object sender, EventArgs e)
        {
            txtNamXB.SelectAll();
        }

        private void txtSoSachMuon_Click(object sender, EventArgs e)
        {
            txtSoSachMuon.SelectAll();
        }

        private void txtSoNgayMuon_Click(object sender, EventArgs e)
        {
            txtSoNgayMuon.SelectAll();
        }

        private void txtSoTienNo_Click(object sender, EventArgs e)
        {
            txtSoTienNo.SelectAll();
        }

        
    }
}
