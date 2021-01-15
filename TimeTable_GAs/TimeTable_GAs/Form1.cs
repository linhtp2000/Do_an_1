﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<BaiGiang> test = new List<BaiGiang>();
            SapXep tkb = new SapXep();
            tkb.SapXepTKB();
            foreach (BaiGiang bg in SapXep.dsBaiGiang)
            {

                if (bg.Lop == null || bg.MonHoc == null || bg.Phong == null || bg.ThoiGian == null)
                {
                    test.Add(bg);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
