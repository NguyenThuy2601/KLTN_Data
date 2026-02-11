using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.DAO
{
    public class AccessConnect : DbConection
    {
        public OleDbConnection Con = null;

        public override int Connect()
        {
            if (Con == null)
            {
                Con = new OleDbConnection();
                Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\test\KhoaCNTT_Demo.accdb";
                Con.Open();
                if (Con.State == ConnectionState.Open)
                    return 1;
                else
                    return 0;
            }
            return 1;

        }
        public override int Disconnect()
        {
            if (Con != null)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
                return 0;
            }
            return 0;

        }

        public override DataTable GetDataToTableByProc<TParameter>(string procName, List<TParameter> paramList)
        {
            OleDbCommand cmd = new OleDbCommand(procName, Con);
            cmd.CommandType = CommandType.StoredProcedure;

            if (paramList != null || paramList.Count > 0)
                cmd.Parameters.AddRange(paramList.ToArray());

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            return table;
        }

        public override DataTable GetDataToTableByProc(string procName)
        {
            OleDbCommand cmd = new OleDbCommand(procName, Con);
            cmd.CommandType = CommandType.StoredProcedure;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            return table;
        }
    }
}
