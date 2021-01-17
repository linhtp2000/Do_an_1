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
    public partial class frmLectureList : Form
    {
        public frmLectureList()
        {
            InitializeComponent();
        }

        private void frmLectureList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet6.BaiGiang' table. You can move, or remove it, as needed.
            this.baiGiangTableAdapter.Fill(this.thoiKhoaBieuDataSet6.BaiGiang);

        }
    }
}
