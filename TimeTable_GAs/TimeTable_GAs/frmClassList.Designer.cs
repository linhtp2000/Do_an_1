
namespace TimeTable_GAs
{
    partial class frmClassList
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
            this.dvgStudentList = new System.Windows.Forms.DataGridView();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet5 = new TimeTable_GAs.ThoiKhoaBieuDataSet5();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet2 = new TimeTable_GAs.ThoiKhoaBieuDataSet2();
            this.sinhVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet5TableAdapters.LopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.sinhVienDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.lopBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(32, 90);
            this.dvgStudentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(652, 454);
            this.dvgStudentList.TabIndex = 3;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "SiSo";
            this.siSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            this.siSoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienDataGridViewTextBoxColumn
            // 
            this.sinhVienDataGridViewTextBoxColumn.DataPropertyName = "SinhVien";
            this.sinhVienDataGridViewTextBoxColumn.HeaderText = "SinhVien";
            this.sinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinhVienDataGridViewTextBoxColumn.Name = "sinhVienDataGridViewTextBoxColumn";
            this.sinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.thoiKhoaBieuDataSet5;
            // 
            // thoiKhoaBieuDataSet5
            // 
            this.thoiKhoaBieuDataSet5.DataSetName = "ThoiKhoaBieuDataSet5";
            this.thoiKhoaBieuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.thoiKhoaBieuDataSet2;
            // 
            // thoiKhoaBieuDataSet2
            // 
            this.thoiKhoaBieuDataSet2.DataSetName = "ThoiKhoaBieuDataSet2";
            this.thoiKhoaBieuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH LỚP HỌC";
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // frmClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 562);
            this.Controls.Add(this.dvgStudentList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClassList";
            this.Text = "frmClassList";
            this.Load += new System.EventHandler(this.frmClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgStudentList;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private ThoiKhoaBieuDataSet2 thoiKhoaBieuDataSet2;
        private ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Label label1;
        private ThoiKhoaBieuDataSet5 thoiKhoaBieuDataSet5;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private ThoiKhoaBieuDataSet5TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienDataGridViewTextBoxColumn;
    }
}