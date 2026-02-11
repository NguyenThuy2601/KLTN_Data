using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKetQuaGiangDay.DTO;
using System.Security.Cryptography;

namespace QLKetQuaGiangDay.BUS
{
    public class ThongKeKetQuaGiangDayBus
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

        public DataTable getTyLeDatWithDoChenhLech(string mMH, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));
                parameters.Add(new OleDbParameter("@Parameter4", mMH));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeDatWithDoChenhLech", parameters);
            }
            return null;

        }

        public DataTable getMonHoc(DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                return dbBus.DBfunction.GetDataToTableByProc("GetAllMonHoc");
            }
            return null;
        }

        public DataTable getTyLeDatGVThroughOutHK(int hocKiBD, int hockiKT, string mGV ,DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeDatGVThroughOutHK", parameters);
            }

            return null;
        }

        public DataTable getTyLeDatGVTheoMonInHK(int hkBD, int hkKT, string mGV,DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeDatGVTheoMonInHK", parameters);
            }

            return null;
        }

        public DataTable getDetailDiemGKAnhCK(string mMH, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));
                parameters.Add(new OleDbParameter("@Parameter4", mMH));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeDatThanhPhanGVTheoMonInHK", parameters);
            }
            return null;

        }

        public DataTable getTyLeDatCKGKThroughOutHK(string mGV, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeQTCKDatThroughOutHK", parameters);
            }
            return null;

        }

        public DataTable getTyLeGKVaCKDatGVTheoMonInHK(string mGV, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TyLeGKVaCKDatGVTheoMonInHK", parameters);
            }
            return null;

        }

        public DataTable getTinhHinhGiangDayInHK(string mGV, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TinhHinhGiangDayInHK", parameters);
            }
            return null;

        }

        public DataTable getTinhHinhGiangDayInHKTheoMon(string mGV, int hkBD, int hkKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", mGV));

                return dbBus.DBfunction.GetDataToTableByProc("TinhHinhGiangDayInHKTheoMon", parameters);
            }
            return null;

        }

        public DataTable getAllGV(DbBus dbBus)
        {
            if(dbBus.isUsingAcess)
            {
                return dbBus.DBfunction.GetDataToTableByProc("GetAllGiangVien");
            }
            return null;
        }

    }
}
