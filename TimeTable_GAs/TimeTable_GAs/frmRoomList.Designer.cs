﻿
namespace TimeTable_GAs
{
    partial class frmRoomList
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
            this.thoiKhoaBieuDataSet4 = new TimeTable_GAs.ThoiKhoaBieuDataSet4();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSet4TableAdapters.PhongTableAdapter();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudentList
            // 
            this.dvgStudentList.AutoGenerateColumns = false;
            this.dvgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dvgStudentList.DataSource = this.phongBindingSource;
            this.dvgStudentList.Location = new System.Drawing.Point(31, 65);
            this.dvgStudentList.Name = "dvgStudentList";
            this.dvgStudentList.RowHeadersWidth = 51;
            this.dvgStudentList.RowTemplate.Height = 24;
            this.dvgStudentList.Size = new System.Drawing.Size(538, 364);
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
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÓM SINH VIÊN";
            // 
            // thoiKhoaBieuDataSet4
            // 
            this.thoiKhoaBieuDataSet4.DataSetName = "ThoiKhoaBieuDataSet4";
            this.thoiKhoaBieuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.thoiKhoaBieuDataSet4;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 458);
            this.Controls.Add(this.dvgStudentList);
            this.Controls.Add(this.label1);
            this.Name = "frmRoomList";
            this.Text = "frmRoomList";
            this.Load += new System.EventHandler(this.frmRoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgStudentList;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private ThoiKhoaBieuDataSet2 thoiKhoaBieuDataSet2;
        private ThoiKhoaBieuDataSet2TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Label label1;
        private ThoiKhoaBieuDataSet4 thoiKhoaBieuDataSet4;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private ThoiKhoaBieuDataSet4TableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
    }
}