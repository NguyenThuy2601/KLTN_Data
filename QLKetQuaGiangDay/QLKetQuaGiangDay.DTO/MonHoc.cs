using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.DTO
{
    public class MonHoc
    {
        public string maMH;
        public string tenMH;

        public MonHoc(string maMH, string tenMH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
        }

        public override string ToString()
        {
            return string.Format("{0}   {1}", maMH, tenMH);
        }
    }
}
