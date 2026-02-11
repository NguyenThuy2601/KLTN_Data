using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.DAO
{
    public abstract class DbConection
    {

        public abstract int Connect();
        public abstract int Disconnect();

        public abstract DataTable GetDataToTableByProc<TParameter>(string procName, List<TParameter> paramList);
        public abstract DataTable GetDataToTableByProc(string procName);
    }
}
