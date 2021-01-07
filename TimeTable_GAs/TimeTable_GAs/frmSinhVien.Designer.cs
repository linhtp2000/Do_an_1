namespace TimeTable_GAs
{
    partial class frmSinhvien
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
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.flowLayoutPanel45 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel36 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel27 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel63 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel54 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(32, 411);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(125, 44);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSV.Location = new System.Drawing.Point(32, 324);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(125, 44);
            this.btnSuaSV.TabIndex = 8;
            this.btnSuaSV.Text = "Chỉnh sửa";
            this.btnSuaSV.UseVisualStyleBackColor = false;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSV.Location = new System.Drawing.Point(125, 243);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(125, 44);
            this.btnThemSV.TabIndex = 7;
            this.btnThemSV.Text = "Thêm Môn";
            this.btnThemSV.UseVisualStyleBackColor = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(140, 138);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(198, 26);
            this.txtTenSV.TabIndex = 4;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(140, 90);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(198, 26);
            this.txtMaSV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sinh viên:";
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
            // dataGridViewSV
            // 
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Location = new System.Drawing.Point(47, 60);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 62;
            this.dataGridViewSV.RowTemplate.Height = 28;
            this.dataGridViewSV.Size = new System.Drawing.Size(1360, 532);
            this.dataGridViewSV.TabIndex = 28;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSuaSV);
            this.groupBox1.Controls.Add(this.btnThemSV);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
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
            this.btnHuy.Location = new System.Drawing.Point(213, 407);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 53);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy Thêm/Sửa";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(216, 324);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 44);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.groupBox2.Controls.Add(this.dataGridViewSV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.flowLayoutPanel63);
            this.groupBox2.Controls.Add(this.flowLayoutPanel54);
            this.groupBox2.Controls.Add(this.flowLayoutPanel45);
            this.groupBox2.Controls.Add(this.flowLayoutPanel36);
            this.groupBox2.Controls.Add(this.flowLayoutPanel27);
            this.groupBox2.Controls.Add(this.flowLayoutPanel18);
            this.groupBox2.Controls.Add(this.flowLayoutPanel9);
            this.groupBox2.Location = new System.Drawing.Point(453, 67);
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
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 944);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
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
    }
}