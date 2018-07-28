using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace BusinessLayer
{
    public class Bus_ThuTienPhat
    {
        public static void ThuTienPhat(En_ThuTienPhat s)
        {
            Sql_ThuTienPhat.ThuTienPhat(s);
        }
    }
}
