using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class En_CaiDat
    {
        int _STT;

        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
        int _DoTuoiToiThieu;

        public int DoTuoiToiThieu
        {
            get { return _DoTuoiToiThieu; }
            set { _DoTuoiToiThieu = value; }
        }
        int _DoTuoiToiDa;

        public int DoTuoiToiDa
        {
            get { return _DoTuoiToiDa; }
            set { _DoTuoiToiDa = value; }
        }
        int _ThoiHanThe;

        public int ThoiHanThe
        {
            get { return _ThoiHanThe; }
            set { _ThoiHanThe = value; }
        }
        int _KhoangCachNamXB;

        public int KhoangCachNamXB
        {
            get { return _KhoangCachNamXB; }
            set { _KhoangCachNamXB = value; }
        }
        int _SachMuonToiDa;

        public int SachMuonToiDa
        {
            get { return _SachMuonToiDa; }
            set { _SachMuonToiDa = value; }
        }
        int _SoNgayMuonToiDa;

        public int SoNgayMuonToiDa
        {
            get { return _SoNgayMuonToiDa; }
            set { _SoNgayMuonToiDa = value; }
        }
        int _SoTienNoToiDa;

        public int SoTienNoToiDa
        {
            get { return _SoTienNoToiDa; }
            set { _SoTienNoToiDa = value; }
        }
        DateTime _NgaySuaDoi;

        public DateTime NgaySuaDoi
        {
            get { return _NgaySuaDoi; }
            set { _NgaySuaDoi = value; }
        }

        public En_CaiDat(int stt, int tuoiToiThieu, int tuoiToiDa, int thoihanThe, int khoangCachNXB, int sachMuonToiDa, int ngayMuonToiDa, int tienNoToiDa, DateTime ngaySuaDoi)
        {
            STT = stt;
            DoTuoiToiThieu = tuoiToiThieu;
            DoTuoiToiDa = tuoiToiDa;
            ThoiHanThe = thoihanThe;
            KhoangCachNamXB = khoangCachNXB;
            SachMuonToiDa = sachMuonToiDa;
            SoNgayMuonToiDa = ngayMuonToiDa;
            SoTienNoToiDa = tienNoToiDa;
            NgaySuaDoi = ngaySuaDoi;
        }
    }
}
