using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS.Common
{
    public static class CommonBusUtils
    {
        public static DataTable findDataByQuery(DataTable originalDT, string queryString)
        {
            DataTable dt = originalDT.Copy();
            dt.DefaultView.RowFilter = queryString;
            return dt;
        }
    }
}
