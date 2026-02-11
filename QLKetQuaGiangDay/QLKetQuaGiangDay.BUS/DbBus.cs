using QLKetQuaGiangDay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS
{
    public class DbBus
    {
        DbConection dbfunction = null;
        bool isAcess;

        public DbConection DBfunction { get => dbfunction; }
        public bool isUsingAcess { get => isAcess; }

        public void load(bool isAcess)
        {
            this.isAcess = isAcess;
            if (isAcess)
                dbfunction = new AccessConnect();
            else
                dbfunction = new SqlConnect();
            dbfunction.Connect();
        }

        
        public void close()
        {
            dbfunction.Disconnect();
            //dbfunction = null;
        }
    }
}
