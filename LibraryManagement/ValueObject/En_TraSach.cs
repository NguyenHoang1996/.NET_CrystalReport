using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_TraSach
    {
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private string _MaPM;

        public string MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }
        private int _SoNgayMuon;

        public int SoNgayMuon
        {
            get { return _SoNgayMuon; }
            set { _SoNgayMuon = value; }
        }

        private int _SoNgayTre;

        public int SoNgayTre
        {
            get { return _SoNgayTre; }
            set { _SoNgayTre = value; }
        }

        private string _TienPhat;

        public string TienPhat
        {
            get { return _TienPhat; }
            set { _TienPhat = value; }
        }
 
        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

        

        public En_TraSach(string maPT, string maPM, int soNgayMuon, int soNgayTre, string tienPhat, DateTime ngayTra )
        {
            MaPT = maPT;
            MaPM = maPM;
            SoNgayMuon = soNgayMuon;
            SoNgayTre = soNgayTre;
            TienPhat = tienPhat;
            NgayTra = ngayTra;
        }
    }
}
