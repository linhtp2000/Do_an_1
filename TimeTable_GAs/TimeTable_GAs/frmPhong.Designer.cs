namespace TimeTable_GAs
{
    partial class frmPhong
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.cmbLocPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenPH = new System.Windows.Forms.TextBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSoLuongSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.flowLayoutPanel45 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel36 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel27 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel63 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel54 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(29, 464);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(125, 44);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.Location = new System.Drawing.Point(29, 378);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(125, 44);
            this.btnSuaPhong.TabIndex = 8;
            this.btnSuaPhong.Text = "Chỉnh sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Location = new System.Drawing.Point(122, 297);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(125, 44);
            this.btnThemPhong.TabIndex = 7;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // cmbLocPhong
            // 
            this.cmbLocPhong.FormattingEnabled = true;
            this.cmbLocPhong.Location = new System.Drawing.Point(162, 233);
            this.cmbLocPhong.Name = "cmbLocPhong";
            this.cmbLocPhong.Size = new System.Drawing.Size(161, 28);
            this.cmbLocPhong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lọc theo phòng học";
            // 
            // txtTenPH
            // 
            this.txtTenPH.Location = new System.Drawing.Point(140, 138);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.Size = new System.Drawing.Size(198, 26);
            this.txtTenPH.TabIndex = 4;
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(140, 90);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(198, 26);
            this.txtMaPH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên phòng học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtSoLuongSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.btnXoaPhong);
            this.groupBox1.Controls.Add(this.btnSuaPhong);
            this.groupBox1.Controls.Add(this.btnThemPhong);
            this.groupBox1.Controls.Add(this.cmbLocPhong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenPH);
            this.groupBox1.Controls.Add(this.txtMaPH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(403, 875);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(213, 455);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 53);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy Thêm/Sửa";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSoLuongSV
            // 
            this.txtSoLuongSV.Location = new System.Drawing.Point(140, 186);
            this.txtSoLuongSV.Name = "txtSoLuongSV";
            this.txtSoLuongSV.Size = new System.Drawing.Size(198, 26);
            this.txtSoLuongSV.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng SV:";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Location = new System.Drawing.Point(213, 378);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(125, 44);
            this.btnXoaPhong.TabIndex = 9;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // flowLayoutPanel45
            // 
            this.flowLayoutPanel45.Location = new System.Drawing.Point(884, 1019);
            this.flowLayoutPanel45.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel45.Name = "flowLayoutPanel45";
            this.flowLayoutPanel45.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel45.TabIndex = 19;
            // 
            // flowLayoutPanel36
            // 
            this.flowLayoutPanel36.Location = new System.Drawing.Point(702, 1019);
            this.flowLayoutPanel36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel36.Name = "flowLayoutPanel36";
            this.flowLayoutPanel36.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel36.TabIndex = 19;
            // 
            // flowLayoutPanel27
            // 
            this.flowLayoutPanel27.Location = new System.Drawing.Point(520, 1019);
            this.flowLayoutPanel27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel27.Name = "flowLayoutPanel27";
            this.flowLayoutPanel27.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel27.TabIndex = 19;
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.Location = new System.Drawing.Point(338, 1019);
            this.flowLayoutPanel18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel18.TabIndex = 19;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Location = new System.Drawing.Point(155, 1019);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel9.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPhong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.flowLayoutPanel63);
            this.groupBox2.Controls.Add(this.flowLayoutPanel54);
            this.groupBox2.Controls.Add(this.flowLayoutPanel45);
            this.groupBox2.Controls.Add(this.flowLayoutPanel36);
            this.groupBox2.Controls.Add(this.flowLayoutPanel27);
            this.groupBox2.Controls.Add(this.flowLayoutPanel18);
            this.groupBox2.Controls.Add(this.flowLayoutPanel9);
            this.groupBox2.Location = new System.Drawing.Point(447, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1445, 900);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 1019);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 0);
            this.label10.TabIndex = 27;
            this.label10.Text = "9";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel63
            // 
            this.flowLayoutPanel63.Location = new System.Drawing.Point(1249, 1019);
            this.flowLayoutPanel63.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel63.Name = "flowLayoutPanel63";
            this.flowLayoutPanel63.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel63.TabIndex = 19;
            // 
            // flowLayoutPanel54
            // 
            this.flowLayoutPanel54.Location = new System.Drawing.Point(1066, 1019);
            this.flowLayoutPanel54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel54.Name = "flowLayoutPanel54";
            this.flowLayoutPanel54.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel54.TabIndex = 19;
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Location = new System.Drawing.Point(47, 60);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 62;
            this.dataGridViewPhong.RowTemplate.Height = 28;
            this.dataGridViewPhong.Size = new System.Drawing.Size(1360, 532);
            this.dataGridViewPhong.TabIndex = 28;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellClick);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 944);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.ComboBox cmbLocPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenPH;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuongSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel45;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel36;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel27;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel63;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel54;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
    }
}