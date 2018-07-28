using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;

namespace Main
{
    public partial class BaoCaoTraSachTre : UserControl
    {
        public BaoCaoTraSachTre()
        {
            InitializeComponent();

            // load dữ liệu vào TableAdapter.
            //this.VW_BAOCAOTRASACHTRETableAdapter.Fill(this.DataBaoCao.VW_BAOCAOTRASACHTRE);

            //this.rpBaoCao.RefreshReport();
        }


    }
}
