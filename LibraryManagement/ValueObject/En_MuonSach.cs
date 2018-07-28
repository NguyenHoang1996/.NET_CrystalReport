using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_MuonSach
    {
        private string _MaThe;  // ma the doc gia
        private string _MaSach;   // sach la thong tin cua sach can muon: ma sach HOAC ten sach
        private DateTime _HanTra;
        private DateTime _NgayMuon;
        private string _MaPM;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
   

        public string MaPM
        {
            get { return _MaPM; }
            set { _MaPM = value; }
        }
        

        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }
        

        public DateTime HanTra
        {
            get { return _HanTra; }
            set { _HanTra = value; }
        }

        public string MaThe
        {
            get { return _MaThe; }
            set { _MaThe = value; }
        }

       
        public En_MuonSach(string maPM, string maThe, string maSach, DateTime ngayMuon, DateTime hanTra)
        {
            MaPM = maPM;
            MaThe = maThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            HanTra = hanTra;
        }
        
    }
}
