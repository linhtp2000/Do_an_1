//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using TimeTable_GAs.Data;

//namespace TimeTable_GAs
//{
//    bool them;
//    string err;
//    public partial class MonHoc : Form
//    {
//         dbMon = new dbMon();
//        public MonHoc()
//        {
//            InitializeComponent();
//        }
//        CourseData dbMon = new CourseData();
//        public LoadData()
//        {
//            try
//            {
//                dataGridViewMon.DataSource = dbMon.Index();
//                dataGridViewMon.AutoResizeColumns();

//                txtMaMH.ResetText();
//                txtTenMH.ResetText();
              

//                btnThemMon.Enabled = true;
//                btnSuaMon.Enabled = true;
//                btnXacNhan.Enabled = true;
//                btnXoa.Enabled = true;
//                btnHuy.Enabled = false;

//                dataGridViewMon_CellClick(null, null);   
//            }
//            catch
//            {
//                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
//            }
//        }

//        private void MonHoc_Load(object sender, EventArgs e)
//        {
//            LoadData();
//        }

//        private void btnThemMon_Click(object sender, EventArgs e)
//        {
//            them = true;
//            dataGridViewMon.Enabled = true;

//            txtMaMH.Enabled = true;
//            txtTenMH.Enabled = true;
          
//            btnThemMon.Enabled = false;
//            btnSuaMon.Enabled = false;
//            btnXacNhan.Enabled = true;
//            btnXoa.Enabled = false;
//            btnHuy.Enabled = true;

//            txtMaMH.ResetText();
//            txtTenMH.ResetText();         

//            txtMaMH.Focus();
//        }

//        private void btnSuaMon_Click(object sender, EventArgs e)
//        {
//            them = false;
//            dataGridViewMon.Enabled = true;
//            dataGridViewMon_CellClick(null, null);


//            btnThemMon.Enabled = false;
//            btnSuaMon.Enabled = false;
//            btnXacNhan.Enabled = true;
//            btnXoa.Enabled = false;
//            btnHuy.Enabled = true;

//            txtTenMH.Focus();
//        }

//        private void btnXoa_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                int r = dataGridViewMon.CurrentCell.RowIndex;

//                DialogResult traloi;
//                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
//                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                if (traloi == DialogResult.Yes)
//                {

//                    dbMon.Detele(ref err, txtMaMH.Text);
//                    LoadData();
//                    MessageBox.Show("Đã xóa xong!");
//                }
//                else
//                {
//                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
//                }
//            }
//            catch
//            {
//                MessageBox.Show("Không xóa được. Lỗi rồi!");
//            }
//        }

//        private void btnXacNhan_Click(object sender, EventArgs e)
//        {

//            if (txtMaMH.Text != "" && txtTenMH.Text != "")
//            {
//                if (them)
//                {
//                    dbMon.Update(txtMaMH.Text, txtTenMH.Text, ref err);
//                    LoadData();
//                    MessageBox.Show("Đã cập nhật xong!");
//                    //try
//                    //{
//                    //    //tìm xem nv đã có hay chưa
//                    //    if (dbNV.TimKiemNV(txtID.Text, ref err) == false)
//                    //    {
//                    //        dbNV.ThemNhanVien(txtHoTen.Text, cmbGioiTinh.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtCMND.Text, txtDienThoai.Text, cmbChucVu.Text, txtID.Text, txtMatKhau.Text, ref err);
//                    //        LoadData();
//                    //        MessageBox.Show("Đã thêm xong!");
//                    //    }
//                    //    else
//                    //    {
//                    //        DialogResult tl;
//                    //        tl = MessageBox.Show("Nhân viên đã tồn tại. bạn có muốn cập nhật lại chi tiết nhân viên?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
//                    //        if (tl == DialogResult.OK)
//                    //        {
//                    //            //nếu ok--> cập nhật lại nv 
//                    //            dbNV.CapNhatNhanVien(txtHoTen.Text, cmbGioiTinh.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtCMND.Text, txtDienThoai.Text, cmbChucVu.Text, txtID.Text, txtMatKhau.Text, ref err);
//                    //            LoadData();
//                    //            MessageBox.Show("Đã cập nhật xong!");
//                    //        }
//                    //        else
//                    //        {
//                    //            MessageBox.Show("Không thực hiện việc thêm mẫu tin!");
//                    //        }
//                    //    }
//                    //}
//                    //catch
//                    //{
//                    //    MessageBox.Show("Không thêm được. Lỗi rồi!");
//                    //}
//                }
//            }
//            else
//            {
//                DialogResult tl;
//                tl = MessageBox.Show("Điền đầy đủ thông tin", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
//            }
//        }

//        private void btnHuy_Click(object sender, EventArgs e)
//        {
//            them = false;

//            txtMaMH.Enabled = true;
//            txtTenMH.Enabled = true;
           

//            btnThemMon.Enabled = true;
//            btnSuaMon.Enabled = true;
//            btnXacNhan.Enabled = true;
//            btnXoa.Enabled = true;

//            txtMaMH.ResetText();
//            txtTenMH.ResetText();        

//        }

//        private void dataGridViewMon_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int r = dataGridViewMon.CurrentCell.RowIndex;

//            txtMaMH.Text = dataGridViewMon.Rows[r].Cells[0].Value.ToString();
//            txtTenMH.Text = dataGridViewMon.Rows[r].Cells[1].Value.ToString();          
//        }
//    }
//}
