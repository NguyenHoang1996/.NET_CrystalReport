using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class LibraryManagement : Form
    {
       
        public LibraryManagement()
        {
            InitializeComponent();

            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.White;
            //tienPhat.Hide();
            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            //picThuVien.Show();

            label1.Text = "Library Management";
        }

        private void btmLapThe_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.Chocolate;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.White;

            tienPhat.Hide();
            lapThe.Show();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            //picThuVien.Hide();
            label1.Text = "Library Management - Lập thẻ đọc giả";
            this.Text = "Lập thẻ";
            lapThe.open();
        }

        private void btmNhanSach_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.Chocolate;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.White;

            tienPhat.Hide();
            lapThe.Hide();
            nhanSach.Show();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            //picThuVien.Hide();
            label1.Text = "Library Management - Nhận sách";
            this.Text = "Nhận sách";
            nhanSach.open();
        }

        private void btmMuonSach_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.Chocolate;
            btnTraSach.BackColor = Color.White;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.White;

            tienPhat.Hide();
            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Show();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            //picThuVien.Hide();
            label1.Text = "Library Management - Mượn sách";
            this.Text = "Mượn sách";
            muonSach.open();
        }

        private void btmTraSach_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.Chocolate;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();
            btnThuTienPhat.BackColor = Color.White;

            tienPhat.Hide();
            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Show();
            timSach.Hide();
            timTV.Hide();

            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            //picThuVien.Hide();
            label1.Text = "Library Management - Trả sách";
            this.Text = "Trả sách";
            traSach.open();
        }

        private void btmTimSach_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnTimKiem.BackColor = Color.Chocolate;
            btnBaoCao.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.White;

            tienPhat.Hide();

            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            pnBaoCao.Visible = false;
            pnTimKiem.Visible = true;
            //picThuVien.Hide();
            label1.Text = "Library Management - Tìm sách";
            this.Text = "Tìm sách";
            //timSach.open();
        }

        private void btmTimNguoi_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnBaoCao.BackColor = Color.Chocolate;
            btnThuTienPhat.BackColor = Color.White;

            //tienPhat.Hide();

            FormBaoCao formBaoCao = new FormBaoCao();

            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();
            //picThuVien.Hide();
            pnTimKiem.Visible = false;
            //pnBaoCao.Visible = true;
            pnBaoCao.Visible = false;

            formBaoCao.Show();

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btmHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void setting_Click(object sender, EventArgs e)
        {
            var frmCaiDat = new CaiDat();
            frmCaiDat.ShowDialog();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            pnTimKiem.Visible = false;
            btnTimSach.BackColor = Color.Chocolate;
            btnTimTV.BackColor = Color.White;

            timSach.Show();
            timSach.open();
            label1.Text = "Library Management - Tìm sách";
            this.Text = "Tìm sách";
            //picThuVien.Hide();
        }

        private void btnTimTV_Click(object sender, EventArgs e)
        {
            pnTimKiem.Visible = false;
            btnTimSach.BackColor = Color.White;
            btnTimTV.BackColor = Color.Chocolate;

            timTV.Show();
            //picThuVien.Hide();
            label1.Text = "Library Management - Tìm đọc giả";
            this.Text = "Tìm đọc giả";
            timTV.open();
        }   

        private void btnBaoCaoMuonSach_Click(object sender, EventArgs e)
        {
            pnBaoCao.Visible = false;
            btnBaoCaoMuonSach.BackColor = Color.Chocolate;
            btnBaoCaoTraSachTre.BackColor = Color.White;
            //baoCaoMuonSach.Show();

            //picThuVien.Hide();
            label1.Text = "Library Management - Báo cáo tình hình mượn sách";
            this.Text = "Báo cáo tình hình mượn sách";
        }

        private void btnBaoCaoTraSachTre_Click(object sender, EventArgs e)
        {
            pnBaoCao.Visible = false;
            btnBaoCaoMuonSach.BackColor = Color.White;
            btnBaoCaoTraSachTre.BackColor = Color.Chocolate;
            //baoCaoTraSachTre.Show();

            //picThuVien.Hide();
            label1.Text = "Library Management - Báo cáo trả sách trễ";
            this.Text = "Báo cáo sách trả trễ";
        }

        private void btnThuTienPhat_Click(object sender, EventArgs e)
        {
            btnLapThe.BackColor = Color.White;
            btnNhanSach.BackColor = Color.White;
            btnMuonSach.BackColor = Color.White;
            btnTraSach.BackColor = Color.White;
            btnBaoCao.BackColor = Color.White;
            btnTimKiem.BackColor = Color.White;
            btnThuTienPhat.BackColor = Color.Chocolate;

            tienPhat.Show();
            lapThe.Hide();
            nhanSach.Hide();
            muonSach.Hide();
            traSach.Hide();
            timSach.Hide();
            timTV.Hide();
            //baoCaoMuonSach.Hide();
           // baoCaoTraSachTre.Hide();

            //picThuVien.Hide();
            pnTimKiem.Visible = false;
            pnBaoCao.Visible = false;
            label1.Text = "Library Management - Thu tiền phạt";
            this.Text = "Thu tiền phạt";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
        }

        private void splitContainer1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1: btmLapThe_Click(sender, e); break;
                case Keys.F2: btmNhanSach_Click(sender, e); break;
                case Keys.F3: btmMuonSach_Click(sender, e); break;
                case Keys.F4: btmTraSach_Click(sender, e); break;
                case Keys.F5: btmTimSach_Click(sender, e); break;
                case Keys.F6: btmTimNguoi_Click(sender, e); break;
                case Keys.F7: btnBaoCaoMuonSach_Click(sender, e); break;
                case Keys.F8: btnBaoCaoTraSachTre_Click(sender, e); break;
                case Keys.F9: btnThuTienPhat_Click(sender, e); break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var thongTin = new ThongTin();
            thongTin.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
