using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.DTO
{
    public class FrequentParam
    {
        public string hkBD { get; set; }
        public string hkKT { get; set; }
        public string maGV { get; set; }
        public string maMH { get; set; }
        public string maLop { get; set; }
        public FrequentParam(string hkBD, string hkKT, string maGV, string maMH, string maLop)
        {
            this.hkBD = hkBD;
            this.hkKT = hkKT;
            this.maGV = maGV.Equals("*") ? "%" : maGV;
            this.maMH = maMH;
            this.maLop = maLop;
        }
    }
}
