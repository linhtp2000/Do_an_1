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
    public partial class Phong : Form
    {
        RoomData dbPhong = new RoomData();
        bool them;
        string err;
        public Phong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dataGridViewPhong.DataSource = dbPhong.Index();
                dataGridViewPhong.AutoResizeColumns();

                txtMaPH.ResetText();
                txtTenPH.ResetText();
                txtSoLuongSV.ResetText();


                btnThemPhong.Enabled = true;
                btnSuaPhong.Enabled = true;
                btnXacNhan.Enabled = true;
                btnXoaPhong.Enabled = true;
                btnHuy.Enabled = false;

               dataGridViewPhong_CellClick(null, null);
               
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewPhong.CurrentCell.RowIndex;

            txtMaPH.Text = dataGridViewPhong.Rows[r].Cells[0].Value.ToString();
            txtTenPH.Text = dataGridViewPhong.Rows[r].Cells[1].Value.ToString();
            txtSoLuongSV.Text = dataGridViewPhong.Rows[r].Cells[2].Value.ToString();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            them = true;
            dataGridViewPhong.Enabled = true;
         
            txtMaPH.Enabled = true;
            txtTenPH.Enabled = true;
            txtSoLuongSV.Enabled = true;

            btnThemPhong.Enabled = false;
            btnSuaPhong.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoaPhong.Enabled = false;
            btnHuy.Enabled = true;

            txtMaPH.ResetText();
            txtTenPH.ResetText();
            txtSoLuongSV.ResetText();

            txtMaPH.Focus();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            them = false;
            dataGridViewPhong.Enabled = true;
            dataGridViewPhong_CellClick(null, null);


            btnThemPhong.Enabled = false;
            btnSuaPhong.Enabled = false;
            btnXacNhan.Enabled = true;
            btnXoaPhong.Enabled = false;
            btnHuy.Enabled = true;

            txtTenPH.Focus();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridViewPhong.CurrentCell.RowIndex;

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {

                    dbPhong.Detele(ref err, txtMaPH.Text);
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
            if (txtMaPH.Text != "" && txtTenPH.Text != "" && txtSoLuongSV.Text != null)
            {
                if (them)
                {
                    //dbPhong.Add(txtMaPH.Text, txtTenPH.Text,Int32.Parse(txtSoLuongSV.Text), ref err);
                    //LoadData();
                    //MessageBox.Show("Đã cập nhật xong!");
                    try
                    {
                        //tìm xem nv đã có hay chưa
                        if (dbPhong.Find(txtMaPH.Text) == null)
                        {
                            dbPhong.Add(txtMaPH.Text, txtTenPH.Text, Int32.Parse(txtSoLuongSV.Text), ref err);
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
                                dbPhong.Update(txtMaPH.Text, txtTenPH.Text, Int32.Parse(txtSoLuongSV.Text), ref err);
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
                    dbPhong.Update(txtMaPH.Text, txtTenPH.Text, Int32.Parse(txtSoLuongSV.Text), ref err);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridViewPhong_CellClick(null, null);

            txtMaPH.Enabled = true;
            txtTenPH.Enabled = true;
            txtSoLuongSV.Enabled = true;

            btnThemPhong.Enabled = true;
            btnSuaPhong.Enabled = true;
            btnXacNhan.Enabled = true;
            btnXoaPhong.Enabled = true;

            txtMaPH.ResetText();
            txtTenPH.ResetText();
            txtSoLuongSV.ResetText();
            
        }
    }
}
