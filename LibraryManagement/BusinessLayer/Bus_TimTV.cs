using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using ValueObject;

namespace BusinessLayer
{
    public class Bus_TimTV
    {
        public static DataTable TimTV(string key)
        {
            return Sql_TimTV.TimTV(key);
        }

        public static DataTable TraCuuTV(string maThe)
        {
            return Sql_TimTV.TraCuuTV(maThe);
        }

        public static void CapNhatTV(En_LapThe dg)
        {
            Sql_TimTV.CapNhatTV(dg);
        }

        public static bool XoaTV(string maThe)
        {
            return Sql_TimTV.XoaTV(maThe);
        }
    }
}
