using QLKetQuaGiangDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKetQuaGiangDay.Utils
{
    public static class CommonUtils
    {
        public static void hideControl(Control control)
        {
            control.Visible = false;
        }
        public static void showControl(Control control)
        {
            control.Visible = true;
        }
        public static void clearText(Control control)
        {
            control.Text = "";
        }
        public static void setText(Control control, string content)
        {
            control.Text = content;
        }
        public static List<String> getColumn(DataTable dt, string colName)
        {
            List<String> value = dt.AsEnumerable()
                              .Select(row => row[colName].ToString())
                              .Distinct()
                              .ToList();
            return value;
        }

        public static void initCbbData(ComboBox cbb, object dataSource)
        {
            switch (dataSource)
            {
                case DataTable dt:
                    cbb.DataSource = dt;
                    break;

                case List<string> stringList:
                    cbb.DataSource = stringList;
                    break;

                default:
                    throw new ArgumentException("Unsupported data source type");
            }

            cbb.SelectedIndex = -1;
            cbb.SelectedText = "";
        }

        

        public static void initCbbData(ComboBox cbb, DataTable dt, string valueMember, string displayMember)
        {
            cbb.DataSource = dt;
            cbb.ValueMember = valueMember;
            cbb.DisplayMember = displayMember;

            cbb.SelectedIndex = -1;
            cbb.SelectedText = "";
        }

        public static void initListBoxData(ListBox listBox, object dataSource)
        {
            switch (dataSource)
            {
                case DataTable dt:
                    listBox.DataSource = dt;
                    break;

                case List<string> stringList:
                    listBox.DataSource = stringList;
                    break;

                case List<MonHoc> monHocList:
                    listBox.DataSource = monHocList;
                    listBox.DisplayMember = "ToString";
                    break;

                default:
                    throw new ArgumentException("Unsupported data source type");
            }
        
        }

        public static double RoundIfNeeded(double value)
        {
            // Check if the value is an integer
            if (value == Math.Floor(value))
            {
                return value; // Do nothing if it's already an integer
            }
            else
            {
                return Math.Round(value, 2); // Round to 2 decimal places if it's not an integer
            }
        }

        

    }
}
