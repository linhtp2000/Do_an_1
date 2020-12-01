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
    public partial class GiaoVien : Form
    {
        bool them;
        string err;
        TeacherData dbGV = new TeacherData();
        public GiaoVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dataGridViewGV.DataSource = dbGV.Index();
                dataGridViewGV.AutoResizeColumns();

                txtMaGV.ResetText();
                txtTenGV.ResetText();
                txtEmail.ResetText();

                btnThemGV.Enabled = true;
                btnSuaGV.Enabled = true;
                btnXacNhan.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;

                dataGridViewGV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void dataGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewGV.CurrentCell.RowIndex;

            txtMaGV.Text = dataGridViewGV.Rows[r].Cells[0].Value.ToString();
            txtTenGV.Text = dataGridViewGV.Rows[r].Cells[1].Value.ToString();
            txtEmail.Text = dataGridViewGV.Rows[r].Cells[2].Value.ToString();

        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridViewGV.Enabled = true;

            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            txtEmail.Enabled = true;

            btnThemGV.Enabled = false;
            btnSuaGV.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtEmail.ResetText();

            txtMaGV.Focus();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            them = false;
            dataGridViewGV.Enabled = true;
            dataGridViewGV_CellClick(null, null);


            btnThemGV.Enabled = false;
            btnSuaGV.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            txtTenGV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridViewGV.CurrentCell.RowIndex;

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    dbGV.Detele(ref err, txtMaGV.Text);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "" && txtTenGV.Text != "")
            {
                if (them)
                {
                    dbGV.Update(txtMaGV.Text, txtTenGV.Text, txtEmail.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã cập nhật xong!");
                    //try
                    //{
                    //    //tìm xem nv đã có hay chưa
                    //    if (dbNV.TimKiemNV(txtID.Text, ref err) == false)
                    //    {
                    //        dbNV.ThemNhanVien(txtHoTen.Text, cmbGioiTinh.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtCMND.Text, txtDienThoai.Text, cmbChucVu.Text, txtID.Text, txtMatKhau.Text, ref err);
                    //        LoadData();
                    //        MessageBox.Show("Đã thêm xong!");
                    //    }
                    //    else
                    //    {
                    //        DialogResult tl;
                    //        tl = MessageBox.Show("Nhân viên đã tồn tại. bạn có muốn cập nhật lại chi tiết nhân viên?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    //        if (tl == DialogResult.OK)
                    //        {
                    //            //nếu ok--> cập nhật lại nv 
                    //            dbNV.CapNhatNhanVien(txtHoTen.Text, cmbGioiTinh.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtCMND.Text, txtDienThoai.Text, cmbChucVu.Text, txtID.Text, txtMatKhau.Text, ref err);
                    //            LoadData();
                    //            MessageBox.Show("Đã cập nhật xong!");
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Không thực hiện việc thêm mẫu tin!");
                    //        }
                    //    }
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Không thêm được. Lỗi rồi!");
                    //}
                }         
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Điền đầy đủ thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            them = false;

            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            txtEmail.Enabled = true;

            btnThemGV.Enabled = true;
            btnSuaGV.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = true;

            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtEmail.ResetText();

        }
    }
}
