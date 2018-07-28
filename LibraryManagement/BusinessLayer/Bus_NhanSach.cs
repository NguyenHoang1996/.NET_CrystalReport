using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Bus_NhanSach
    {
        public static void ThemSach(En_NhanSach s)
        {
            Sql_NhanSach.ThemSach(s);
        }
    }
}
