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
    public partial class LapThe : UserControl
    {

        private string maThe;
        private DataTable dtDanhSachDG = new DataTable();
        private static int doTuoiToiThieu;
        private static int doTuoiToiDa;


        public LapThe()
        {
            InitializeComponent();

            open();

        }
        
        internal static void layThongTinCaiDat()
        {
            List<int> caiDat = CaiDat.caiDatLapThe();
            doTuoiToiThieu = caiDat[0];
            doTuoiToiDa = caiDat[1];
        }

        /// Khi từ chức năng nào đó click vào chức năng này thì sẽ gọi đến hàm open() này
        internal void open()
        {
            ngayLapthe.Text = DateTime.Today.ToShortDateString();

            this.Focus();
            txtHoTen.Focus();

            dgvDanhSach.Rows.Clear();

            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Select", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtDanhSachDG = new DataTable();
            da.Fill(dtDanhSachDG);
            conn.Close();

            if (dtDanhSachDG.Rows.Count <= 0)
            {
                maThe = "A0001";
                txtMathe.Text = maThe.ToString();
            }
            else
            {
                string temp = dtDanhSachDG.Rows[dtDanhSachDG.Rows.Count - 1][0].ToString();
                taoMaThe(temp);


                /// load database len dgvDAnhSach
                for (int i = 0; i < dtDanhSachDG.Rows.Count; i++)
                {
                    dgvDanhSach.Rows.Add(dtDanhSachDG.Rows[i].ItemArray);
                }


                // sort lai dgvDanhsach 
                dgvDanhSach.Sort(dgvDanhSach.Columns["Column1"], ListSortDirection.Descending);

            }
            layThongTinCaiDat();
        }

        /*
         input: maPM cuoi cung
         output: maPM ke tiep
         
         
         */
        private void taoMaThe(string lastMaThe)
        {
            lastMaThe = lastMaThe.Remove(0, 1);
            int stt = int.Parse(lastMaThe);
            stt++;
            int l = stt.ToString().Length;
            l = 4 - l;
            string prefix = "A";
            while (l > 0)
            {
                prefix += "0";
                l--;
            }
            maThe = prefix + stt.ToString();
            txtMathe.Text = maThe.ToString();
        }
        private void btLapThe_Click(object sender, EventArgs e)
        {
            // kiem tra xem co de trong o nao khong
            if(txtDiaChi.Text == "" || txtEmail.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }

            // kiem tra xem co dung nhu tuoi quy dinh hay k
         
            TimeSpan _tuoiDocGia = DateTime.Today - DateTime.Parse(dtNgaySinh.Text.ToString());
            int tuoiDocGia = _tuoiDocGia.Days / 365;
            int tuoiToiThieu = doTuoiToiThieu;
            int tuoiToiDa = doTuoiToiDa;
            if(tuoiDocGia < tuoiToiThieu || tuoiDocGia > tuoiToiDa)
            {
                MessageBox.Show("Độ tuổi hợp lệ từ " + tuoiToiThieu.ToString() + " đến " + tuoiToiDa.ToString() + " tuổi");
                return;
            }



            string hoten = txtHoTen.Text;
            DateTime ngaysinh = DateTime.Parse(dtNgaySinh.Value.ToString());
            DateTime ngaylapthe = DateTime.Parse(ngayLapthe.Text.ToString());
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            string loaidocgia = cbLoaiDocGia.Text;

            En_LapThe tdg = new En_LapThe(maThe, hoten, ngaysinh, ngaylapthe, email, diachi, loaidocgia, 0); /// ban dau lap the thi TaikhoanNo cua doc gia bang 0
            Bus_LapThe.ThemTheDocGia(tdg);
            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK);

            // them 1 row vao dgvDanhsach
            string[] row = new string[] { txtMathe.Text, txtHoTen.Text, cbLoaiDocGia.Text, dtNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, ngayLapthe.Text, "0"};
            dgvDanhSach.Rows.Add(row);

            // sort lai dgvDanhsach de row minh vua nhap dung o dau table
            dgvDanhSach.Sort(dgvDanhSach.Columns["Column1"], ListSortDirection.Descending);
            

            taoMaThe(maThe);
            btTaoLai_Click(sender, e);
        }

        private void btTaoLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cbLoaiDocGia.Text = "";
            dtNgaySinh.Text = "";

            txtHoTen.Focus();
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

        private void txtHoTen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtHoTen.Text = chuanHoaTen(txtHoTen.Text);

                if(e.KeyCode == Keys.Enter)
                    dtNgaySinh.Focus();
            }
        }

        private void dtNgaySinh_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if(!txtEmail.Text.Contains("@"))
                {
                    string temp = txtEmail.Text + "@gmail.com";
                    txtEmail.Text = temp;
                }
                else if(!txtEmail.Text.Contains(".com"))
                {
                    string temp = txtEmail.Text + ".com";
                    txtEmail.Text = temp;
                }
                else if (!txtEmail.Text.Contains("com"))
                {
                    string temp = txtEmail.Text + "com";
                    txtEmail.Text = temp;
                }

                if (e.KeyCode == Keys.Enter)
                    txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtDiaChi.Text = chuanHoaTen(txtDiaChi.Text);

                if (e.KeyCode == Keys.Enter)
                    cbLoaiDocGia.Focus();
            }
        }

        private void cbLoaiDocGia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ngayLapthe.Focus();
        }

        private void ngayLapthe_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btLapThe.Focus();
        }






    }
}
