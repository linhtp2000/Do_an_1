using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_GAs
{
    public partial class frmTeacherList : Form
    {
        public frmTeacherList()
        {
            InitializeComponent();
        }

        private void frmTeacherList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet3.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.thoiKhoaBieuDataSet3.GiaoVien);

        }
    }
}
