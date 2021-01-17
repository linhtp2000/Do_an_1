
namespace TimeTable_GAs
{
    partial class frmStudentList
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
            this.maNhomSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet2 = new TimeTable_GAs.ThoiKhoaBieuDataSet2();
            this.sinhVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhomSVDataGridViewTextBoxColumn,
            this.tenNhomSVDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.sinhVienBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(32, 113);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(493, 363);
            this.dvgStudentList.TabIndex = 1;
            // 
            // maNhomSVDataGridViewTextBoxColumn
            // 
            this.maNhomSVDataGridViewTextBoxColumn.DataPropertyName = "MaNhomSV";
            this.maNhomSVDataGridViewTextBoxColumn.HeaderText = "MaNhomSV";
            this.maNhomSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomSVDataGridViewTextBoxColumn.Name = "maNhomSVDataGridViewTextBoxColumn";
            this.maNhomSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNhomSVDataGridViewTextBoxColumn
            // 
            this.tenNhomSVDataGridViewTextBoxColumn.DataPropertyName = "TenNhomSV";
            this.tenNhomSVDataGridViewTextBoxColumn.HeaderText = "TenNhomSV";
            this.tenNhomSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomSVDataGridViewTextBoxColumn.Name = "tenNhomSVDataGridViewTextBoxColumn";
            this.tenNhomSVDataGridViewTextBoxColumn.Width = 125;
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
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÓM SINH VIÊN";
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(570, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgStudentList);
            this.Name = "frmStudentList";
            this.Text = "frmStudentList";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgStudentList;
        private ThoiKhoaBieuDataSet2 thoiKhoaBieuDataSet2;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}