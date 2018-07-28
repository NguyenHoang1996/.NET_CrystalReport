using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_NhanSach
    {
        private string _MaSach;
        private string _TenSach;
        private string _TheLoai;
        private string _TacGia;
        private string _NhaXB;
        private int _NXB;
        private int _TriGia;
        private DateTime _NgayNhap;
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public string MaSach
        {
            get
            {
                return _MaSach;
            }

            set
            {
                _MaSach = value;
            }
        }

        public string TenSach
        {
            get
            {
                return _TenSach;
            }

            set
            {
                _TenSach = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return _TheLoai;
            }

            set
            {
                _TheLoai = value;
            }
        }

        public string TacGia
        {
            get
            {
                return _TacGia;
            }

            set
            {
                _TacGia = value;
            }
        }

        public string NhaXB
        {
            get
            {
                return _NhaXB;
            }

            set
            {
                _NhaXB = value;
            }
        }

        public int NXB
        {
            get
            {
                return _NXB;
            }

            set
            {
                _NXB = value;
            }
        }

        public int TriGia
        {
            get
            {
                return _TriGia;
            }

            set
            {
                _TriGia = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return _NgayNhap;
            }

            set
            {
                _NgayNhap = value;
            }
        }

        
        public En_NhanSach(string masach, string tensach, string theloai, string tacgia, string nhaxb, int nxb, int trigia, DateTime ngaynhap, int soLuong)
        {
            MaSach = masach;
            TenSach = tensach;
            TheLoai = theloai;
            TacGia = tacgia;
            NhaXB = nhaxb;
            NXB = nxb;
            TriGia = trigia;
            NgayNhap = ngaynhap;
            SoLuong = soLuong;
        }
    }
}
