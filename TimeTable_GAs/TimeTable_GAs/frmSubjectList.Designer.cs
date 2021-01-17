
namespace TimeTable_GAs
{
    partial class frmSubjectList
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
            this.thoiKhoaBieuDataSet7 = new TimeTable_GAs.ThoiKhoaBieuDataSet7();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet7TableAdapters.MonHocTableAdapter();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soTCDataGridViewTextBoxColumn,
            this.sinhVienDataGridViewTextBoxColumn,
            this.giaoVienDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.monHocBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(58, 72);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(712, 363);
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
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÓM SINH VIÊN";
            // 
            // thoiKhoaBieuDataSet7
            // 
            this.thoiKhoaBieuDataSet7.DataSetName = "ThoiKhoaBieuDataSet7";
            this.thoiKhoaBieuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.thoiKhoaBieuDataSet7;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTCDataGridViewTextBoxColumn
            // 
            this.soTCDataGridViewTextBoxColumn.DataPropertyName = "SoTC";
            this.soTCDataGridViewTextBoxColumn.HeaderText = "SoTC";
            this.soTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTCDataGridViewTextBoxColumn.Name = "soTCDataGridViewTextBoxColumn";
            this.soTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienDataGridViewTextBoxColumn
            // 
            this.sinhVienDataGridViewTextBoxColumn.DataPropertyName = "SinhVien";
            this.sinhVienDataGridViewTextBoxColumn.HeaderText = "SinhVien";
            this.sinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinhVienDataGridViewTextBoxColumn.Name = "sinhVienDataGridViewTextBoxColumn";
            this.sinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaoVienDataGridViewTextBoxColumn
            // 
            this.giaoVienDataGridViewTextBoxColumn.DataPropertyName = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.HeaderText = "GiaoVien";
            this.giaoVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaoVienDataGridViewTextBoxColumn.Name = "giaoVienDataGridViewTextBoxColumn";
            this.giaoVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmSubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgStudentList);
            this.Controls.Add(this.label1);
            this.Name = "frmSubjectList";
            this.Text = "frmSubjectList";
            this.Load += new System.EventHandler(this.frmSubjectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgStudentList;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private ThoiKhoaBieuDataSet2 thoiKhoaBieuDataSet2;
        private ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Label label1;
        private ThoiKhoaBieuDataSet7 thoiKhoaBieuDataSet7;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private ThoiKhoaBieuDataSet7TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaoVienDataGridViewTextBoxColumn;
    }
}