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
    public partial class frmSubjectList : Form
    {
        public frmSubjectList()
        {
            InitializeComponent();
        }

        private void frmSubjectList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet7.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.thoiKhoaBieuDataSet7.MonHoc);

        }
    }
}
