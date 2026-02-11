using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.DAO
{
    public class SqlConnect : DbConection
    {
        public SqlConnection Con = null;

        public override int Connect()
        {
            if (Con == null)
            {
                Con = new SqlConnection();
                Con.ConnectionString = @"Data Source=DESKTOP-4CBR9B5;Initial Catalog=BCMH;Integrated Security=True; MultipleActiveResultSets=true";
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
            SqlCommand cmd = new SqlCommand(procName, Con);
            cmd.CommandType = CommandType.StoredProcedure;

            if (paramList != null || paramList.Count > 0)
                cmd.Parameters.AddRange(paramList.ToArray());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            return table;
        }

        public override DataTable GetDataToTableByProc(string procName)
        {
            SqlCommand cmd = new SqlCommand(procName, Con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            return table;
        }
    }
}
