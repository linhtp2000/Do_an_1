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
    public partial class frmClassList : Form
    {
        public frmClassList()
        {
            InitializeComponent();
        }

        private void frmClassList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet5.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.thoiKhoaBieuDataSet5.Lop);

        }
    }
}
