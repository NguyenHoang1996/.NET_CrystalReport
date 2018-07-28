using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_ThuTienPhat
    {
        string _MaPTT;

        public string MaPTT
        {
            get { return _MaPTT; }
            set { _MaPTT = value; }
        }
       

        string _MaDG;

        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }
        
        int _SoTienThu;

        public int SoTienThu
        {
            get { return _SoTienThu; }
            set { _SoTienThu = value; }
        }
        int _ConLai;

        public int ConLai
        {
            get { return _ConLai; }
            set { _ConLai = value; }
        }

        DateTime _NgayThu;

        public DateTime NgayThu
        {
            get { return _NgayThu; }
            set { _NgayThu = value; }
        }

        public En_ThuTienPhat(string maPTT, string maDG, int soTienThu, int conLai, DateTime ngayThu)
        {
            MaPTT = maPTT;
            MaDG = maDG;
            SoTienThu = soTienThu;
            ConLai = conLai;
            NgayThu = ngayThu;
        }
    }
}
