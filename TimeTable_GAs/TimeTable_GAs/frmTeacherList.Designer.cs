
namespace TimeTable_GAs
{
    partial class frmTeacherList
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
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet3 = new TimeTable_GAs.ThoiKhoaBieuDataSet3();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet2 = new TimeTable_GAs.ThoiKhoaBieuDataSet2();
            this.sinhVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.giaoVienTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet3TableAdapters.GiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.giaoVienBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(38, 110);
            this.dvgStudentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(706, 575);
            this.dvgStudentList.TabIndex = 3;
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.thoiKhoaBieuDataSet3;
            // 
            // thoiKhoaBieuDataSet3
            // 
            this.thoiKhoaBieuDataSet3.DataSetName = "ThoiKhoaBieuDataSet3";
            this.thoiKhoaBieuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 718);
            this.Controls.Add(this.dvgStudentList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTeacherList";
            this.Text = "frmTeacherList";
            this.Load += new System.EventHandler(this.frmTeacherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet3)).EndInit();
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
        private ThoiKhoaBieuDataSet3 thoiKhoaBieuDataSet3;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private ThoiKhoaBieuDataSet3TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}