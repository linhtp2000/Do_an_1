using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable_GAs.Model;
using TimeTable_GAs.Services;

namespace TimeTable_GAs
{
    public partial class Form2 : Form
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        private List<FlowLayoutPanel> listFlp = new List<FlowLayoutPanel>();
        private List<Label> listPhongLabel = new List<Label>();
        public Form2()
        {
            InitializeComponent();
        }
       
       
        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet.Lop' table.You can move, or remove it, as needed.
            // this.lopTableAdapter.Fill(this.thoiKhoaBieuDataSet.Lop);

            //var lstbg = db.BaiGiangs.ToList();
            //if (lstbg.Count != 0)
            //{
            //    foreach (BaiGiang bg in db.BaiGiangs.ToList())
            //    {
            //        db.BaiGiangs.Remove(bg);
            //        db.SaveChanges();
            //    }
            //    SapXep.dsBaiGiang.Clear();
            //}
            //SapXep sx = new SapXep();
            //SapXep.dsBaiGiang.Clear();
            //SapXep.dsBaiGiang = new List<BaiGiang>();
            //SapXep.SoBuoidayCuaGV.Clear();
            //SapXep.SoBuoidayCuaGV = new Dictionary<GiaoVien, List<BaiGiang>>();
            //SapXep.id = 0;
            //sx.SapXepTKB();
        }

        private void cmbChonLop_Click(object sender, EventArgs e)
        {

        }
        void LoadplTkb()
        {
            if (cmbXemTKB.Text !=null||cmbXemTKB.Text!="" ) { 
            string s = cmbXemTKB.SelectedValue.ToString();
            
                var dsbaigiang = db.BaiGiangs.Where(b => b.GiaoVien == s).ToList();
                //  List<BaiGiang> dsbaigiang = new List<BaiGiang>();
                dsbaigiang = SapXep.dsBaiGiang.FindAll(b => b.Lop == s).ToList();
                fplTkb.Controls.Clear();
                listFlp.Clear();
                for (int i = 0; i < 18; i++)
                {
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    fl.Name = $"flp{i}";
                    fl.Size = new Size(170, 140);
                    fl.BackColor = Color.White;
                    fl.BorderStyle = BorderStyle.FixedSingle;
                    fplTkb.Controls.Add(fl);

                    listFlp.Add(fl);

                }
                LoadTheoThu(s, "Hai", 0);
                LoadTheoThu(s, "Ba", 1);
                LoadTheoThu(s, "Tư", 2);
                LoadTheoThu(s, "Năm", 3);
                LoadTheoThu(s, "Sáu", 4);
                LoadTheoThu(s, "Bảy", 5);
            }
        }

        void LoadTheoThu(string s, string thu, int p)
        {
            List<BaiGiang> dstheothu = db.BaiGiangs.Where(b => b.GiaoVien == s && b.ThoiGian1.Thu == thu).ToList();
            // List<BaiGiang> dstheothu = SapXep.dsBaiGiang.FindAll(b => b.Lop == s && b.ThoiGian1.Thu == thu).ToList();

            for (int i = 0; i < dstheothu.Count - 1; i++)
            {
                for (int j = i + 1; j < dstheothu.Count; j++)
                {
                    int a = (int)dstheothu[i].ThoiGian1.TietBD;
                    if (dstheothu[i].ThoiGian1.Buoi == "Chiều")
                    {
                        a += 6;
                    }
                    int b = (int)dstheothu[j].ThoiGian1.TietBD;
                    if (dstheothu[j].ThoiGian1.Buoi == "Chiều")
                    {
                        b += 6;
                    }

                    if (a > b)
                    {
                        BaiGiang g = new BaiGiang();
                        g = dstheothu.Find(bg => bg.MaBG == dstheothu[i].MaBG) as BaiGiang;
                        dstheothu[i] = new BaiGiang();
                        dstheothu[i] = dstheothu.Find(bg => bg.MaBG == dstheothu[j].MaBG) as BaiGiang;
                        dstheothu[j] = new BaiGiang();
                        dstheothu[j] = g;
                        j--;
                    }
                }
            }
            if (dstheothu.Count > 3)
            {
                for (int i = 18; i < 24; i++)
                {
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    fl.Name = $"flp{i}";
                    fl.Size = new Size(170, 140);
                    fl.BackColor = Color.White;
                    fl.BorderStyle = BorderStyle.FixedSingle;
                    fplTkb.Controls.Add(fl);

                    listFlp.Add(fl);
                }
            }
            for (int i = 0; i < dstheothu.Count; i++)
            {

                LoadLabelMon(dstheothu[i], p);
                LoadLabelLop(dstheothu[i], p);
                LoadLabelPhong(dstheothu[i], p);
                LoadLabelTiet(dstheothu[i], p);

                p += 6;

            }
        }
        void LoadLabelMon(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblMon{index}";
            lb.Size = new Size(160, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = bg.MonHoc1.TenMon;
            listFlp[index].Controls.Add(lb);
        }
        //void LoadLabelBuoi(BaiGiang bg, int index)
        //{
        //    Label lb = new Label();
        //    lb.Name = $"lblBuoi{index}";
        //    lb.Size = new Size(160, 24);
        //    lb.AutoSize = false;
        //    lb.TextAlign = ContentAlignment.MiddleLeft;
        //    lb.Text = bg.ThoiGian1.Buoi + "-" + bg.ThoiGian1.Thu + "-" + bg.Phong1.TenPhong;
        //    listFlp[index].Controls.Add(lb);
        //}
        void LoadLabelLop(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblLop{index}";
            lb.Size = new Size(160, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = bg.Lop1.TenLop;
            listFlp[index].Controls.Add(lb);
        }
        void LoadLabelTiet(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblTiet{index}";
            lb.Size = new Size(160, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            if (bg.ThoiGian1.Buoi == "Chiều")
            {
                int x = (int)bg.ThoiGian1.TietBD + 6;
                int y = (int)(bg.ThoiGian1.TietKT + 6);
                lb.Text = "Tiết: " + x.ToString() + "-" + y.ToString();
            }
            else
            {
                lb.Text = "Tiết: " + bg.ThoiGian1.TietBD + "-" + bg.ThoiGian1.TietKT;
            }
            listFlp[index].Controls.Add(lb);
        }
        void LoadLabelPhong(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblPhong{index}";
            lb.Size = new Size(160, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = "Phòng: " + bg.Phong1.TenPhong;
            listFlp[index].Controls.Add(lb);
            //listPhongLabel[index].Controls.Add(lb);
        }
        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            //int index = cmbXemTKB.SelectedIndex;
            LoadplTkb();
        }

        private void cmbTKBLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbXemTKB_DropDown(object sender, EventArgs e)
        {

            //DataSet ds = new DataSet();
            //=db.Lops.fill
            cmbXemTKB.DataSource = db.GiaoViens.ToList();
            cmbXemTKB.ValueMember = "MaGV";
            cmbXemTKB.DisplayMember = "TenGV";
        }

        private void fplTkb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnAddClass_Click(object sender, EventArgs e)
        {
            frmClassList frm = new frmClassList();
            frm.Show();
        }

        private void mnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentList frm = new frmStudentList();
            frm.Show();
        }

        private void mnEditStudent_Click(object sender, EventArgs e)
        {
            frmSinhvien frm = new frmSinhvien();
            frm.Show();
        }

        private void mnAddSubject_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.Show();
        }

        private void mnEditSubject_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.Show();
        }


        private void mnEditTeacher_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.Show();
        }



        private void mnlClass_Click(object sender, EventArgs e)
        {
            frmClassList frm = new frmClassList();
            frm.Show();
        }

        private void mnlRoom_Click(object sender, EventArgs e)
        {
            frmRoomList frm = new frmRoomList();
            frm.Show();
        }

        private void mnlSubject_Click(object sender, EventArgs e)
        {
            frmSubjectList frm = new frmSubjectList();
            frm.Show();
        }

        private void mnlTeacher_Click(object sender, EventArgs e)
        {
            frmTeacherList frm = new frmTeacherList();
            frm.Show();
        }

        private void Menu_Enter(object sender, EventArgs e)
        {

        }

        private void mnEditRoom_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong();
            frm.Show();
        }

        private void mnSubject_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            frmBaiGiang frm = new frmBaiGiang();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
