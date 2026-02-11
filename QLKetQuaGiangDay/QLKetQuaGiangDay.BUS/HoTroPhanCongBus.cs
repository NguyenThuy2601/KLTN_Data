using QLKetQuaGiangDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS
{
    public class HoTroPhanCongBus
    {
        public DataTable getMonHoc(DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                return dbBus.DBfunction.GetDataToTableByProc("GetAllMonHoc");
            }
            return null;

        }

        public DataTable getXepHangGV(MonHoc monHoc,int hkBD, int hkKT, double doLech, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));
                parameters.Add(new OleDbParameter("@Parameter4", monHoc.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", doLech));

                return dbBus.DBfunction.GetDataToTableByProc("XepHangTyLeDatTheoMon", parameters);
            }
            return null;

        }

        public DataTable getAllGiangVien(DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {

                return dbBus.DBfunction.GetDataToTableByProc("GetAllGiangVien");
            }
            return null;
        }

        public DataTable getThongKeTyLeDatCuaGiangVienInHK(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeDatCuaGVInHK", parameters);
            }

            return null;
        }

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
    }
}
