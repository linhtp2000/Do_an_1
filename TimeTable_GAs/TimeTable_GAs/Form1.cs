using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable_GAs.Services;
using TimeTable_GAs.Model;

namespace TimeTable_GAs
{
    public partial class Form1 : Form
    {
        public ThoiKhoaBieuEntities db = new ThoiKhoaBieuEntities();
        private List<FlowLayoutPanel> listFlp = new List<FlowLayoutPanel>();
        private List<Label> listPhongLabel = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
       // TODO: This line of code loads data into the 'thoiKhoaBieuDataSet.Lop' table.You can move, or remove it, as needed.
             //this.lopTableAdapter.Fill(this.thoiKhoaBieuDataSet.Lop);
            List<BaiGiang> test = new List<BaiGiang>();
            SapXep tkb = new SapXep();
            tkb.SapXepTKB();
            List<BaiGiang> x = SapXep.dsBaiGiang;
            List<BaiGiang> y = SapXep.test;
            LoadplTkb();

        }

        private void cmbChonLop_Click(object sender, EventArgs e)
        {
            
        }
        void LoadplTkb()
        {
            string s = /*cmbTKBLop.ValueMember;*/"1";
            var dsbaigaing = SapXep.dsBaiGiang.FindAll(b => b.Lop == s).ToList();
           
            fplTkb.Controls.Clear();
            listFlp.Clear();
            for (int i = 0; i < dsbaigaing.Count; i++)
            {
                LoadLabelPhong(dsbaigaing[i], i);
            }
                for (int i=0;i<dsbaigaing.Count;i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = $"flp{i}";
                fl.Size = new Size(190, 90);
                fl.BackColor = Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fplTkb.Controls.Add(fl);

                listFlp.Add(fl);
                LoadLabelMon(dsbaigaing[i], i);
                LoadLabelGV(dsbaigaing[i],i );
                LoadLabelBuoi(dsbaigaing[i], i);
                LoadLabelTiet(dsbaigaing[i],i );
            }
          //  var mon = db.BaiGiangs.Where(b => b.Lop == s).Select(b=>b.MonHoc).ToList();
          


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
        void LoadLabelBuoi(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblBuoi{index}";
            lb.Size = new Size(160, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = bg.ThoiGian1.Buoi+"-"+bg.ThoiGian1.Thu;
            listFlp[index].Controls.Add(lb);
        }
        void LoadLabelGV(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblGV{index}";
            lb.Size = new Size(169, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = bg.GiaoVien1.TenGV;
            listFlp[index].Controls.Add(lb);
        }
        void LoadLabelTiet(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblTiet{index}";
            lb.Size = new Size(169, 24);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = "Tiết: " + bg.ThoiGian1.TietBD + "-" + bg.ThoiGian1.TietKT;
            listFlp[index].Controls.Add(lb);
        }
        void LoadLabelPhong(BaiGiang bg, int index)
        {
            Label lb = new Label();
            lb.Name = $"lblPhong{index}";
            lb.Size = new Size(111, 90);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Text = bg.Phong1.TenPhong;
            flpPhong.Controls.Add(lb);
            //listPhongLabel[index].Controls.Add(lb);
        }
        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            LoadplTkb();
        }

        private void cmbTKBLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
