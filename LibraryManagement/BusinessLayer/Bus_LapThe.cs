using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ValueObject;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Bus_LapThe
    {
        public static void ThemTheDocGia(En_LapThe tdg)
        {
            Sql_LapThe.ThemTheDocGia(tdg);
        }

        public static DataTable ChonThe()
        {
            return Sql_LapThe.ChonThe();
        }
    }
}
