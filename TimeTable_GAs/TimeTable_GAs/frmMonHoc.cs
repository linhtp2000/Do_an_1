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
    public partial class frmMonHoc : Form
    {
        CourseData db = new CourseData();
        bool them;
        string err;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dataGridViewMon.DataSource = db.Index();
                dataGridViewMon.AutoResizeColumns();

                txtMaMon.ResetText();
                txtGV.ResetText();
                txtNhomSV.ResetText();
                txtSoTC.ResetText();
                txtTenMon.ResetText();

                txtMaMon.Enabled = false;
                txtGV.Enabled = false;
                txtNhomSV.Enabled = false;
                txtSoTC.Enabled = false;
                txtTenMon.Enabled = false;

                btnThemMon.Enabled = true;
                btnSuaMon.Enabled = true;
                btnXacNhan.Enabled = false;
                btnXoaMon.Enabled = true;
                btnHuy.Enabled = false;

                dataGridViewMon_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void dataGridViewMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewMon.CurrentCell.RowIndex;

            txtMaMon.Text = dataGridViewMon.Rows[r].Cells[0].Value.ToString();
            txtTenMon.Text = dataGridViewMon.Rows[r].Cells[1].Value.ToString();
            txtSoTC.Text = dataGridViewMon.Rows[r].Cells[2].Value.ToString();
            txtNhomSV.Text = dataGridViewMon.Rows[r].Cells[3].Value.ToString();
            txtGV.Text = dataGridViewMon.Rows[r].Cells[4].Value.ToString();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet7.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.thoiKhoaBieuDataSet7.MonHoc);
            LoadData();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridViewMon.Enabled = false;


            txtMaMon.Enabled = true;
            txtGV.Enabled = true;
            txtNhomSV.Enabled = true;
            txtSoTC.Enabled = true;
            txtTenMon.Enabled = true;

            btnThemMon.Enabled = false;
            btnSuaMon.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoaMon.Enabled = false;
            btnHuy.Enabled = true;

            txtMaMon.ResetText();
            txtGV.ResetText();
            txtNhomSV.ResetText();
            txtSoTC.ResetText();
            txtTenMon.ResetText();

            txtMaMon.Focus();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridViewMon.CurrentCell.RowIndex;

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    db.Detele(ref err, txtMaMon.Text);
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

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            them = false;

            txtGV.Enabled = true;
            txtNhomSV.Enabled = true;
            txtSoTC.Enabled = true;
            txtTenMon.Enabled = true;

            dataGridViewMon.Enabled = true;
            dataGridViewMon_CellClick(null, null);


            btnThemMon.Enabled = false;
            btnSuaMon.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoaMon.Enabled = false;
            btnHuy.Enabled = true;

            txtMaMon.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text != "" && txtTenMon.Text != "" && txtSoTC.Text != null && txtNhomSV.Text != null && txtGV.Text != null)
            {
                if (them)
                {
                    //dbPhong.Add(txtMaPH.Text, txtTenPH.Text,Int32.Parse(txtSoLuongSV.Text), ref err);
                    //LoadData();
                    //MessageBox.Show("Đã cập nhật xong!");
                    try
                    {
                        //tìm xem nv đã có hay chưa
                        if (db.Find(txtMaMon.Text) == null)
                        {
                            db.Add(txtMaMon.Text, txtTenMon.Text, Int32.Parse(txtSoTC.Text), txtNhomSV.Text, txtGV.Text, ref err);
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            DialogResult tl;
                            tl = MessageBox.Show("Môn đã tồn tại. bạn có muốn cập nhật lại chi tiết môn học?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (tl == DialogResult.OK)
                            {
                                //nếu ok--> cập nhật lại nv 
                                db.Update(txtMaMon.Text, txtTenMon.Text, Int32.Parse(txtSoTC.Text), txtNhomSV.Text, txtGV.Text, ref err);
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
                    db.Update(txtMaMon.Text, txtTenMon.Text, Int32.Parse(txtSoTC.Text), txtNhomSV.Text, txtGV.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã cập nhật xong!");
                }
            }
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Điền đầy đủ thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            txtMaMon.Enabled = false;
            txtGV.Enabled = false;
            txtNhomSV.Enabled = false;
            txtSoTC.Enabled = false;
            txtTenMon.Enabled = false;

            dataGridViewMon.Enabled = true;
            btnThemMon.Enabled = true;
            btnSuaMon.Enabled = true;
            btnXacNhan.Enabled = false;
            btnXoaMon.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            dataGridViewMon_CellClick(null, null);
            dataGridViewMon.Enabled = true;

            txtGV.Enabled = true;
            txtNhomSV.Enabled = true;
            txtSoTC.Enabled = true;
            txtTenMon.Enabled = true;

            btnThemMon.Enabled = true;
            btnSuaMon.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXoaMon.Enabled = true;


            txtMaMon.ResetText();
            txtGV.ResetText();
            txtNhomSV.ResetText();
            txtSoTC.ResetText();
            txtTenMon.ResetText();
        }
    }
}
