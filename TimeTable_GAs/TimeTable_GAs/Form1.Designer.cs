namespace TimeTable_GAs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.cmbXemTKB = new System.Windows.Forms.ComboBox();
            this.btnXemTKB = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet = new TimeTable_GAs.ThoiKhoaBieuDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fplTkb = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSetTableAdapters.LopTableAdapter();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.cmbXemTKB);
            this.Menu.Controls.Add(this.btnXemTKB);
            this.Menu.Controls.Add(this.comboBox3);
            this.Menu.Controls.Add(this.label23);
            this.Menu.Controls.Add(this.comboBox2);
            this.Menu.Controls.Add(this.label22);
            this.Menu.Controls.Add(this.comboBox1);
            this.Menu.Controls.Add(this.label21);
            this.Menu.Controls.Add(this.cmbLop);
            this.Menu.Controls.Add(this.cmbPhong);
            this.Menu.Controls.Add(this.label20);
            this.Menu.Controls.Add(this.label19);
            this.Menu.Controls.Add(this.label18);
            this.Menu.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(12, 73);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(382, 900);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // cmbXemTKB
            // 
            this.cmbXemTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbXemTKB.FormattingEnabled = true;
            this.cmbXemTKB.Location = new System.Drawing.Point(142, 41);
            this.cmbXemTKB.Name = "cmbXemTKB";
            this.cmbXemTKB.Size = new System.Drawing.Size(229, 53);
            this.cmbXemTKB.TabIndex = 16;
            // 
            // btnXemTKB
            // 
            this.btnXemTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXemTKB.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTKB.Location = new System.Drawing.Point(16, 581);
            this.btnXemTKB.Name = "btnXemTKB";
            this.btnXemTKB.Size = new System.Drawing.Size(355, 49);
            this.btnXemTKB.TabIndex = 15;
            this.btnXemTKB.Text = "View TimeTable";
            this.btnXemTKB.UseVisualStyleBackColor = false;
            this.btnXemTKB.Click += new System.EventHandler(this.btnXemTKB_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(142, 470);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(229, 53);
            this.comboBox3.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 473);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 45);
            this.label23.TabIndex = 13;
            this.label23.Text = "Teacher:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 380);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 53);
            this.comboBox2.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 383);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 45);
            this.label22.TabIndex = 11;
            this.label22.Text = "Subject:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 53);
            this.comboBox1.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 45);
            this.label21.TabIndex = 9;
            this.label21.Text = "Student:";
            // 
            // cmbLop
            // 
            this.cmbLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(142, 126);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(229, 53);
            this.cmbLop.TabIndex = 8;
            // 
            // cmbPhong
            // 
            this.cmbPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(142, 208);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(229, 53);
            this.cmbPhong.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 216);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 45);
            this.label20.TabIndex = 6;
            this.label20.Text = "Room:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 45);
            this.label19.TabIndex = 4;
            this.label19.Text = "Class:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 45);
            this.label18.TabIndex = 2;
            this.label18.Text = "TimeTable:";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.thoiKhoaBieuDataSet;
            // 
            // thoiKhoaBieuDataSet
            // 
            this.thoiKhoaBieuDataSet.DataSetName = "ThoiKhoaBieuDataSet";
            this.thoiKhoaBieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpPhong);
            this.groupBox2.Controls.Add(this.fplTkb);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(412, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 921);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // fplTkb
            // 
            this.fplTkb.Location = new System.Drawing.Point(119, 91);
            this.fplTkb.Name = "fplTkb";
            this.fplTkb.Size = new System.Drawing.Size(1178, 827);
            this.fplTkb.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 68);
            this.panel1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1099, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 50);
            this.label3.TabIndex = 19;
            this.label3.Text = "Saturday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(903, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 50);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thusday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(707, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 50);
            this.label4.TabIndex = 20;
            this.label4.Text = "Friday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 50);
            this.label7.TabIndex = 17;
            this.label7.Text = "Monday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 50);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tuesday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 50);
            this.label6.TabIndex = 22;
            this.label6.Text = "Wednesday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // flpPhong
            // 
            this.flpPhong.Location = new System.Drawing.Point(6, 91);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(113, 827);
            this.flpPhong.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label21;
        private ThoiKhoaBieuDataSet thoiKhoaBieuDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private ThoiKhoaBieuDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXemTKB;
        private System.Windows.Forms.ComboBox cmbXemTKB;
        private System.Windows.Forms.FlowLayoutPanel fplTkb;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
    }
}

