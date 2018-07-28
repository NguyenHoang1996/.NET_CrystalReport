using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DataAccessLayer;
using System.Data;
namespace BusinessLayer
{
    public class Bus_CaiDat
    {
        public static DataTable CaiDat_select()
        {
            return Sql_CaiDat.CaiDat_select();
        }
        public static void CaiDat_insert(En_CaiDat s)
        {
            Sql_CaiDat.CaiDat_insert(s);
        }
    }
}
