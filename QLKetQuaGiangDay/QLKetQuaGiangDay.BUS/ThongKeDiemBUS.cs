using QLKetQuaGiangDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS
{
    public class ThongKeDiemBUS
    {
        public DataTable getMonHocGiangDayInHocKy(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("MonHocGiangDayTrongHK", parameters);
            }
            else
            {
                List<SqlParameter> parameters1 = new List<SqlParameter>();
                parameters1.Add(new SqlParameter("@Parameter1", hocKiBD));
                parameters1.Add(new SqlParameter("@Parameter2", hockiKT));
                parameters1.Add(new SqlParameter("@Parameter3", "*"));

                return dbBus.DBfunction.GetDataToTableByProc("MonHocGiangDayTrongHK", parameters1);
            }

        }

        public DataTable getMonHocGiangDayInHocKyWithGV(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("MonHocGiangDayTrongHKWithGVInfo", parameters);
            }
            else
            {
                List<SqlParameter> parameters1 = new List<SqlParameter>();
                parameters1.Add(new SqlParameter("@Parameter1", hocKiBD));
                parameters1.Add(new SqlParameter("@Parameter2", hockiKT));
                parameters1.Add(new SqlParameter("@Parameter3", "*"));

                return dbBus.DBfunction.GetDataToTableByProc("MonHocGiangDayTrongHKWithGVInfo", parameters1);
            }

        }


        public DataTable getLopGiangDayInHocKy(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("CacLopGiangDayTrongHK", parameters);
            }
            else
            {
                List<SqlParameter> parameters1 = new List<SqlParameter>();
                parameters1.Add(new SqlParameter("@Parameter1", hocKiBD));
                parameters1.Add(new SqlParameter("@Parameter2", hockiKT));
                parameters1.Add(new SqlParameter("@Parameter3", "*"));

                return dbBus.DBfunction.GetDataToTableByProc("CacLopGiangDayTrongHK", parameters1);
            }

        }

        public DataTable getThongKeDiem(FrequentParam param, DbBus dbBus, string procName)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));

                DataTable temp = dbBus.DBfunction.GetDataToTableByProc(procName, parameters);

                DataTable result = temp.Clone();
                DataRow lastRow = temp.Rows[temp.Rows.Count - 1];
                result.ImportRow(lastRow);

                return result;
            }
            return null;
        }

        public DataTable getThongKeTyLeDiem(FrequentParam param, DbBus dbBus, string procName)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));

                return dbBus.DBfunction.GetDataToTableByProc(procName, parameters);

            }
            return null;
        }

        public DataTable getThongKeDiemTheoLop(FrequentParam param, DbBus dbBus, string procName)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", param.maLop));

                DataTable temp = dbBus.DBfunction.GetDataToTableByProc(procName, parameters);

                DataTable result = temp.Clone();
                DataRow lastRow = temp.Rows[temp.Rows.Count - 1];
                result.ImportRow(lastRow);

                return result;
            }
            return null;
        }

        public DataTable getThongKeTyLeDiemTheoLop(FrequentParam param, DbBus dbBus, string procName)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", param.maLop));

                return dbBus.DBfunction.GetDataToTableByProc(procName, parameters);

            }
            return null;
        }

        

    }
}
