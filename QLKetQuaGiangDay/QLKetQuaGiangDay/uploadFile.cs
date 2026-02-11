using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKetQuaGiangDay
{
    public partial class uploadFile : Form
    {
        string fullPath;
        public uploadFile()
        {
            InitializeComponent();
        }

        public uploadFile(string fileName) : this()
        {
            string[] name = fileName.Split('\\');
            fullPath = fileName;
            fileName = name[name.Length - 1];
            tenFile.Text = fileName;
        }
        public string getFullPath()
        {
            return fullPath;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            fullPath = "";
            this.Close();
        }
    }
}
