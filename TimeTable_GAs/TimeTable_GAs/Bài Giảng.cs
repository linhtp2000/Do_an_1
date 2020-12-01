using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable_GAs.Data;

namespace TimeTable_GAs
{
    public partial class Bài_Giảng : Form
    {
        bool them;
        Class BaiGiang = new Class();
        public Bài_Giảng()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dataGridViewBG.DataSource = BaiGiang.Index();
                dataGridViewBG.AutoResizeColumns();
                txtMaBG.Enabled = false;
                txtMaGV.Enabled = false;
                txtMaMH.Enabled = false;
                txtMaPhong.Enabled = false;
                txtMaSV.Enabled = false;
                txtSTTTuan.Enabled = false;
                txtThu.Enabled = false;
                txtTietBatDau.Enabled = false;
                txtTietKetThuc.Enabled = false;

                btnThemBaiGiang.Enabled = true;
                btnSuaBG.Enabled = true;
                btnXacNhan.Enabled = true;
                btnXoa.Enabled = true;
                cmbLocBG.Enabled = true;

                txtMaBG.ResetText();
                txtMaGV.ResetText();
                txtMaMH.ResetText();
                txtMaPhong.ResetText();
                txtMaSV.ResetText();
                txtSTTTuan.ResetText();
                txtThu.ResetText();
                txtTietBatDau.ResetText();
                txtTietKetThuc.ResetText();

                dataGridViewBG_CellClick(null, null);               
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }


        private void btnThemBaiGiang_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridViewBG.Enabled = true;
           
            txtMaBG.Enabled = true;
            txtMaGV.Enabled = true;
            txtMaMH.Enabled = true;
            txtMaPhong.Enabled = true;
            txtMaSV.Enabled = true;
            txtSTTTuan.Enabled = true;
            txtThu.Enabled = true;
            txtTietBatDau.Enabled = true;
            txtTietKetThuc.Enabled = true;

            btnThemBaiGiang.Enabled = false;
            btnSuaBG.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = false;
            cmbLocBG.Enabled = false;

            txtMaBG.ResetText();
            txtMaGV.ResetText();
            txtMaMH.ResetText();
            txtMaPhong.ResetText();
            txtMaSV.ResetText();
            txtSTTTuan.ResetText();
            txtThu.ResetText();
            txtTietBatDau.ResetText();
            txtTietKetThuc.ResetText();

            txtMaBG.Focus();
        }

        private void dataGridViewBG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewBG.CurrentCell.RowIndex;

            txtMaBG.Text = dataGridViewBG.Rows[r].Cells[0].Value.ToString();
            txtMaGV.Text = dataGridViewBG.Rows[r].Cells[1].Value.ToString();
            txtMaMH.Text = dataGridViewBG.Rows[r].Cells[2].Value.ToString();
            txtMaPhong.Text = dataGridViewBG.Rows[r].Cells[3].Value.ToString();
            txtMaSV.Text = dataGridViewBG.Rows[r].Cells[4].Value.ToString();
            txtSTTTuan.Text = dataGridViewBG.Rows[r].Cells[5].Value.ToString();
            txtThu.Text = dataGridViewBG.Rows[r].Cells[6].Value.ToString();
            txtTietBatDau.Text = dataGridViewBG.Rows[r].Cells[7].Value.ToString();
            txtTietKetThuc.Text = dataGridViewBG.Rows[r].Cells[8].Value.ToString();   
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSuaBG_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
