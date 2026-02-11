using QLKetQuaGiangDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS
{
    public class XemKetQuaDanhGiaBus : ThongKeDiemBUS
    {
        public DataTable getDiemKhaoSat(FrequentParam param, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", string.IsNullOrEmpty(param.maLop) ? "%" : param.maLop));

                return dbBus.DBfunction.GetDataToTableByProc("DanhGiaTuSinhVien", parameters);
            }
            return null;
        }

        public DataTable getYKienKhac(FrequentParam param, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", string.IsNullOrEmpty(param.maLop) ? "%" : param.maLop));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter3", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", param.maGV));
                

                return dbBus.DBfunction.GetDataToTableByProc("GetDanhGiaKhacCuaSV", parameters);
            }
            return null;
        }

        public DataTable getThongKeKhaoSat(FrequentParam param, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", param.hkBD));
                parameters.Add(new OleDbParameter("@Parameter2", param.hkKT));
                parameters.Add(new OleDbParameter("@Parameter3", param.maGV));
                parameters.Add(new OleDbParameter("@Parameter4", param.maMH));
                parameters.Add(new OleDbParameter("@Parameter5", string.IsNullOrEmpty(param.maLop) ? "%" : param.maLop));

                return dbBus.DBfunction.GetDataToTableByProc("ThongKeDAU_ROT_Feedback_LMS", parameters);
            }
            return null;
        }
    }
}
