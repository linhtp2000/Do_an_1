
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet4 = new TimeTable_GAs.ThoiKhoaBieuDataSet4();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel54 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel63 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel45 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel36 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel27 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSoLuongSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.txtTenPH = new System.Windows.Forms.TextBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phongTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet4TableAdapters.PhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AutoGenerateColumns = false;
            this.dataGridViewPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dataGridViewPhong.DataSource = this.phongBindingSource;
            this.dataGridViewPhong.Location = new System.Drawing.Point(47, 60);
            this.dataGridViewPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 62;
            this.dataGridViewPhong.RowTemplate.Height = 28;
            this.dataGridViewPhong.Size = new System.Drawing.Size(500, 532);
            this.dataGridViewPhong.TabIndex = 28;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellClick);
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.Width = 113;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.Width = 118;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 110;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.thoiKhoaBieuDataSet4;
            // 
            // thoiKhoaBieuDataSet4
            // 
            this.thoiKhoaBieuDataSet4.DataSetName = "ThoiKhoaBieuDataSet4";
            this.thoiKhoaBieuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label10.Size = new System.Drawing.Size(0, 0);
            this.label10.TabIndex = 27;
            this.label10.Text = "9";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel54
            // 
            this.flowLayoutPanel54.Location = new System.Drawing.Point(1066, 1019);
            this.flowLayoutPanel54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel54.Name = "flowLayoutPanel54";
            this.flowLayoutPanel54.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel54.TabIndex = 19;
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
            this.groupBox2.Location = new System.Drawing.Point(431, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(550, 631);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel63
            // 
            this.flowLayoutPanel63.Location = new System.Drawing.Point(1249, 1019);
            this.flowLayoutPanel63.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel63.Name = "flowLayoutPanel63";
            this.flowLayoutPanel63.Size = new System.Drawing.Size(176, 105);
            this.flowLayoutPanel63.TabIndex = 19;
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
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(213, 455);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 52);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy Thêm/Sửa";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSoLuongSV
            // 
            this.txtSoLuongSV.Location = new System.Drawing.Point(140, 186);
            this.txtSoLuongSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(29, 464);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(125, 44);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Location = new System.Drawing.Point(213, 378);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(125, 44);
            this.btnXoaPhong.TabIndex = 9;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.Location = new System.Drawing.Point(29, 378);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnThemPhong.Location = new System.Drawing.Point(122, 298);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(125, 44);
            this.btnThemPhong.TabIndex = 7;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtTenPH
            // 
            this.txtTenPH.Location = new System.Drawing.Point(140, 138);
            this.txtTenPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.Size = new System.Drawing.Size(198, 26);
            this.txtTenPH.TabIndex = 4;
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(140, 90);
            this.txtMaPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label2.Location = new System.Drawing.Point(6, 52);
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
            this.groupBox1.Controls.Add(this.txtTenPH);
            this.groupBox1.Controls.Add(this.txtMaPH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(403, 581);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhong;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel54;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel63;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel45;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel36;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel27;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSoLuongSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.TextBox txtTenPH;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ThoiKhoaBieuDataSet4 thoiKhoaBieuDataSet4;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private ThoiKhoaBieuDataSet4TableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
    }
}