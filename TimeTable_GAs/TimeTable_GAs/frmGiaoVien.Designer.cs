
namespace TimeTable_GAs
{
    partial class frmGiaoVien
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
            this.btnHuyGV = new System.Windows.Forms.Button();
            this.btnXacNhanGV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmailGV = new System.Windows.Forms.TextBox();
            this.btnXoaGiaoVien = new System.Windows.Forms.Button();
            this.btnSuaGiaoVien = new System.Windows.Forms.Button();
            this.btnThemGiaoVien = new System.Windows.Forms.Button();
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.thoiKhoaBieuDataSet3 = new TimeTable_GAs.ThoiKhoaBieuDataSet3();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet3TableAdapters.GiaoVienTableAdapter();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyGV
            // 
            this.btnHuyGV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuyGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyGV.Location = new System.Drawing.Point(238, 569);
            this.btnHuyGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyGV.Name = "btnHuyGV";
            this.btnHuyGV.Size = new System.Drawing.Size(141, 55);
            this.btnHuyGV.TabIndex = 54;
            this.btnHuyGV.Text = "Hủy";
            this.btnHuyGV.UseVisualStyleBackColor = false;
            this.btnHuyGV.Click += new System.EventHandler(this.btnHuyGV_Click);
            // 
            // btnXacNhanGV
            // 
            this.btnXacNhanGV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhanGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanGV.Location = new System.Drawing.Point(32, 569);
            this.btnXacNhanGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXacNhanGV.Name = "btnXacNhanGV";
            this.btnXacNhanGV.Size = new System.Drawing.Size(141, 55);
            this.btnXacNhanGV.TabIndex = 53;
            this.btnXacNhanGV.Text = "Xác nhận";
            this.btnXacNhanGV.UseVisualStyleBackColor = false;
            this.btnXacNhanGV.Click += new System.EventHandler(this.btnXacNhanGV_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Tên Giáo viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Mã Giáo viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giaoVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(447, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 661);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGV_CellClick);
            // 
            // txtEmailGV
            // 
            this.txtEmailGV.Location = new System.Drawing.Point(156, 221);
            this.txtEmailGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailGV.Name = "txtEmailGV";
            this.txtEmailGV.Size = new System.Drawing.Size(222, 26);
            this.txtEmailGV.TabIndex = 48;
            // 
            // btnXoaGiaoVien
            // 
            this.btnXoaGiaoVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGiaoVien.Location = new System.Drawing.Point(238, 461);
            this.btnXoaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaGiaoVien.Name = "btnXoaGiaoVien";
            this.btnXoaGiaoVien.Size = new System.Drawing.Size(141, 55);
            this.btnXoaGiaoVien.TabIndex = 47;
            this.btnXoaGiaoVien.Text = "Xóa";
            this.btnXoaGiaoVien.UseVisualStyleBackColor = false;
            this.btnXoaGiaoVien.Click += new System.EventHandler(this.btnXoaGiaoVien_Click);
            // 
            // btnSuaGiaoVien
            // 
            this.btnSuaGiaoVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGiaoVien.Location = new System.Drawing.Point(32, 461);
            this.btnSuaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaGiaoVien.Name = "btnSuaGiaoVien";
            this.btnSuaGiaoVien.Size = new System.Drawing.Size(141, 55);
            this.btnSuaGiaoVien.TabIndex = 46;
            this.btnSuaGiaoVien.Text = "Chỉnh sửa";
            this.btnSuaGiaoVien.UseVisualStyleBackColor = false;
            this.btnSuaGiaoVien.Click += new System.EventHandler(this.btnSuaGiaoVien_Click);
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGiaoVien.Location = new System.Drawing.Point(136, 360);
            this.btnThemGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(141, 55);
            this.btnThemGiaoVien.TabIndex = 45;
            this.btnThemGiaoVien.Text = "Thêm Giáo viên";
            this.btnThemGiaoVien.UseVisualStyleBackColor = false;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Location = new System.Drawing.Point(156, 161);
            this.txtTenGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(222, 26);
            this.txtTenGiaoVien.TabIndex = 44;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(156, 101);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(222, 26);
            this.txtMaGiaoVien.TabIndex = 43;
            // 
            // thoiKhoaBieuDataSet3
            // 
            this.thoiKhoaBieuDataSet3.DataSetName = "ThoiKhoaBieuDataSet3";
            this.thoiKhoaBieuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.thoiKhoaBieuDataSet3;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 742);
            this.Controls.Add(this.btnHuyGV);
            this.Controls.Add(this.btnXacNhanGV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmailGV);
            this.Controls.Add(this.btnXoaGiaoVien);
            this.Controls.Add(this.btnSuaGiaoVien);
            this.Controls.Add(this.btnThemGiaoVien);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyGV;
        private System.Windows.Forms.Button btnXacNhanGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmailGV;
        private System.Windows.Forms.Button btnXoaGiaoVien;
        private System.Windows.Forms.Button btnSuaGiaoVien;
        private System.Windows.Forms.Button btnThemGiaoVien;
        private System.Windows.Forms.TextBox txtTenGiaoVien;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private ThoiKhoaBieuDataSet3 thoiKhoaBieuDataSet3;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private ThoiKhoaBieuDataSet3TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}