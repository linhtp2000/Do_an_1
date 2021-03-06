﻿using System;
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
    public partial class frmSinhvien : Form
    {
        StudentData dbSV = new StudentData();
        bool them;
        string err;
        public frmSinhvien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dataGridViewSV.DataSource = dbSV.Index();
                dataGridViewSV.AutoResizeColumns();

                txtMaSV.ResetText();
                txtTenSV.ResetText();

                txtMaSV.Enabled = false;
                txtTenSV.Enabled = false;

                btnThemSV.Enabled = true;
                btnSuaSV.Enabled = true;
                btnXacNhan.Enabled = false;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;

                dataGridViewSV_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewSV.CurrentCell.RowIndex;

            txtMaSV.Text = dataGridViewSV.Rows[r].Cells[0].Value.ToString();
            txtTenSV.Text = dataGridViewSV.Rows[r].Cells[1].Value.ToString();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet2.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.thoiKhoaBieuDataSet2.SinhVien);
            LoadData();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridViewSV.Enabled = false;

            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;

            btnThemSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            txtMaSV.ResetText();
            txtTenSV.ResetText();

            txtMaSV.Focus();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            them = false;
            //txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;

            dataGridViewSV.Enabled = true;
            dataGridViewSV_CellClick(null, null);


            btnThemSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            txtTenSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridViewSV.CurrentCell.RowIndex;

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    dbSV.Detele(ref err, txtMaSV.Text);
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
            if (txtMaSV.Text != "" && txtTenSV.Text != "")
            {
                if (them)
                {
                    try
                    {
                        //tìm xem nv đã có hay chưa

                        if (dbSV.Find(txtMaSV.Text) == null)
                        {
                            dbSV.Add(txtMaSV.Text, txtTenSV.Text, ref err);
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            DialogResult tl;
                            tl = MessageBox.Show("Sinh viên đã tồn tại. bạn có muốn cập nhật lại chi tiết sinh viên?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (tl == DialogResult.OK)
                            {
                                //nếu ok--> cập nhật lại nv 
                                dbSV.Update(txtMaSV.Text, txtTenSV.Text, ref err);
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
                    dbSV.Update(txtMaSV.Text, txtTenSV.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Điền đầy đủ thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;

            dataGridViewSV.Enabled = true;
            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnXacNhan.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridViewSV_CellClick(null, null);
            dataGridViewSV.Enabled = true;

            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;


            btnThemSV.Enabled = true;
            btnSuaSV.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXoa.Enabled = true;

            txtMaSV.ResetText();
            txtTenSV.ResetText();
        }
    }
}
