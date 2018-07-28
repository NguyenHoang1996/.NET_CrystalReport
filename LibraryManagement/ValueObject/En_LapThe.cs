using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_LapThe
    {
        private string _MaThe;
        private string _HoTen;
        private DateTime _NgaySinh;
        private DateTime _NgayLapThe;
        private string _Email;
        private string _DiaChi;
        private string _LoaiDocGia;
        private int _TaiKhoanNo;

        public int TaiKhoanNo
        {
            get { return _TaiKhoanNo; }
            set { _TaiKhoanNo = value; }
        }

        public string MaThe
        {
            get
            {
                return _MaThe;
            }

            set
            {
                _MaThe = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _HoTen;
            }

            set
            {
                _HoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public DateTime NgayLapThe
        {
            get
            {
                return _NgayLapThe;
            }

            set
            {
                _NgayLapThe = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string LoaiDocGia
        {
            get
            {
                return _LoaiDocGia;
            }

            set
            {
                _LoaiDocGia = value;
            }
        }

        public En_LapThe(string mathe, string hoten, DateTime ngaysinh, DateTime ngaylapthe, string email, string diachi, string loaidocgia, int taiKhoanNo)
        {
            MaThe = mathe;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            NgayLapThe = ngaylapthe;
            Email = email;
            DiaChi = diachi;
            LoaiDocGia = loaidocgia;
            TaiKhoanNo = taiKhoanNo;
        }
    }
}
