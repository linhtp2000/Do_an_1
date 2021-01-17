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
    public partial class frmGiaoVien : Form
    {
        bool them;
        string err;
        TeacherData dbGV = new TeacherData();
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dataGridView1.DataSource = dbGV.Index();
                dataGridView1.AutoResizeColumns();

                txtMaGiaoVien.ResetText();
                txtTenGiaoVien.ResetText();
                txtEmailGV.ResetText();

                txtMaGiaoVien.Enabled = false;
                txtTenGiaoVien.Enabled = false;
                txtEmailGV.Enabled = false;

                btnThemGiaoVien.Enabled = true;
                btnSuaGiaoVien.Enabled = true;
                btnXacNhanGV.Enabled = true;
                btnXoaGiaoVien.Enabled = true;
                btnHuyGV.Enabled = false;

                dataGridViewGV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void dataGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            txtMaGiaoVien.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenGiaoVien.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtEmailGV.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridView1.Enabled = false;

            txtMaGiaoVien.Enabled = true;
            txtTenGiaoVien.Enabled = true;
            txtEmailGV.Enabled = true;

            btnThemGiaoVien.Enabled = false;
            btnSuaGiaoVien.Enabled = false;
            btnXacNhanGV.Enabled = true;
            btnXoaGiaoVien.Enabled = false;
            btnHuyGV.Enabled = true;

            txtMaGiaoVien.ResetText();
            txtTenGiaoVien.ResetText();
            txtEmailGV.ResetText();

            txtMaGiaoVien.Focus();
        }

        private void btnSuaGiaoVien_Click(object sender, EventArgs e)
        {
            them = false;
            txtTenGiaoVien.Enabled = true;
            txtEmailGV.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridViewGV_CellClick(null, null);


            btnThemGiaoVien.Enabled = false;
            btnSuaGiaoVien.Enabled = false;
            btnXacNhanGV.Enabled = true;
            btnXoaGiaoVien.Enabled = false;
            btnHuyGV.Enabled = true;

            txtTenGiaoVien.Focus();
        }

        private void btnXoaGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    dbGV.Detele(ref err, txtMaGiaoVien.Text);
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

        private void btnXacNhanGV_Click(object sender, EventArgs e)
        {
            if (txtMaGiaoVien.Text != "" && txtTenGiaoVien.Text != "")
            {
                if (them)
                {
                    //dbPhong.Add(txtMaPH.Text, txtTenPH.Text,Int32.Parse(txtSoLuongSV.Text), ref err);
                    //LoadData();
                    //MessageBox.Show("Đã cập nhật xong!");
                    try
                    {
                        //tìm xem nv đã có hay chưa
                        if (dbGV.Find(txtMaGiaoVien.Text) == null)
                        {
                            dbGV.Add(txtMaGiaoVien.Text, txtTenGiaoVien.Text, txtEmailGV.Text, ref err);
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            DialogResult tl;
                            tl = MessageBox.Show("Phòng đã tồn tại. bạn có muốn cập nhật lại chi tiết phòng?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (tl == DialogResult.OK)
                            {
                                //nếu ok--> cập nhật lại nv 
                                dbGV.Update(txtMaGiaoVien.Text, txtTenGiaoVien.Text, txtEmailGV.Text, ref err);
                                LoadData();
                                MessageBox.Show("Đã cập nhật xong!");
                            }
                            else
                            {
                                MessageBox.Show("Không thực hiện việc thêm mẫu tin!");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else
                {
                    dbGV.Update(txtMaGiaoVien.Text, txtTenGiaoVien.Text, txtEmailGV.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã cập nhật xong!");
                }

            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Điền đầy đủ thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void btnHuyGV_Click(object sender, EventArgs e)
        {
            dataGridViewGV_CellClick(null, null);
            dataGridView1.Enabled = true;

            txtMaGiaoVien.Enabled = true;
            txtTenGiaoVien.Enabled = true;
            txtEmailGV.Enabled = true;

            btnThemGiaoVien.Enabled = true;
            btnSuaGiaoVien.Enabled = true;
            btnXacNhanGV.Enabled = true;
            btnXoaGiaoVien.Enabled = true;

            txtMaGiaoVien.ResetText();
            txtTenGiaoVien.ResetText();
            txtEmailGV.ResetText();

        }
    }
}
