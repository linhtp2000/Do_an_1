
namespace TimeTable_GAs
{
    partial class frmLectureList
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
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet2 = new TimeTable_GAs.ThoiKhoaBieuDataSet2();
            this.sinhVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.thoiKhoaBieuDataSet6 = new TimeTable_GAs.ThoiKhoaBieuDataSet6();
            this.baiGiangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baiGiangTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet6TableAdapters.BaiGiangTableAdapter();
            this.maBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiGiangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBGDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.phongDataGridViewTextBoxColumn,
            this.monHocDataGridViewTextBoxColumn,
            this.giaoVienDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.baiGiangBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(59, 181);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(867, 363);
            this.dvgStudentList.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(93, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÓM SINH VIÊN";
            // 
            // thoiKhoaBieuDataSet6
            // 
            this.thoiKhoaBieuDataSet6.DataSetName = "ThoiKhoaBieuDataSet6";
            this.thoiKhoaBieuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baiGiangBindingSource
            // 
            this.baiGiangBindingSource.DataMember = "BaiGiang";
            this.baiGiangBindingSource.DataSource = this.thoiKhoaBieuDataSet6;
            // 
            // baiGiangTableAdapter
            // 
            this.baiGiangTableAdapter.ClearBeforeFill = true;
            // 
            // maBGDataGridViewTextBoxColumn
            // 
            this.maBGDataGridViewTextBoxColumn.DataPropertyName = "MaBG";
            this.maBGDataGridViewTextBoxColumn.HeaderText = "MaBG";
            this.maBGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maBGDataGridViewTextBoxColumn.Name = "maBGDataGridViewTextBoxColumn";
            this.maBGDataGridViewTextBoxColumn.Width = 125;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongDataGridViewTextBoxColumn
            // 
            this.phongDataGridViewTextBoxColumn.DataPropertyName = "Phong";
            this.phongDataGridViewTextBoxColumn.HeaderText = "Phong";
            this.phongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
            this.phongDataGridViewTextBoxColumn.Width = 125;
            // 
            // monHocDataGridViewTextBoxColumn
            // 
            this.monHocDataGridViewTextBoxColumn.DataPropertyName = "MonHoc";
            this.monHocDataGridViewTextBoxColumn.HeaderText = "MonHoc";
            this.monHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monHocDataGridViewTextBoxColumn.Name = "monHocDataGridViewTextBoxColumn";
            this.monHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaoVienDataGridViewTextBoxColumn
            // 
            this.giaoVienDataGridViewTextBoxColumn.DataPropertyName = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.HeaderText = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaoVienDataGridViewTextBoxColumn.Name = "giaoVienDataGridViewTextBoxColumn";
            this.giaoVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lop";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmLectureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 639);
            this.Controls.Add(this.dvgStudentList);
            this.Controls.Add(this.label1);
            this.Name = "frmLectureList";
            this.Text = "frmLectureList";
            this.Load += new System.EventHandler(this.frmLectureList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiGiangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgStudentList;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private ThoiKhoaBieuDataSet2 thoiKhoaBieuDataSet2;
        private ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Label label1;
        private ThoiKhoaBieuDataSet6 thoiKhoaBieuDataSet6;
        private System.Windows.Forms.BindingSource baiGiangBindingSource;
        private ThoiKhoaBieuDataSet6TableAdapters.BaiGiangTableAdapter baiGiangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
    }
}