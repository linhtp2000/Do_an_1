
namespace TimeTable_GAs
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buổi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buổi,
            this.Hai,
            this.Ba,
            this.Tu,
            this.Nam,
            this.Sau,
            this.Bay});
            this.dataGridView1.Location = new System.Drawing.Point(63, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // Buổi
            // 
            this.Buổi.HeaderText = "Buổi";
            this.Buổi.MinimumWidth = 6;
            this.Buổi.Name = "Buổi";
            this.Buổi.Width = 125;
            // 
            // Hai
            // 
            this.Hai.HeaderText = "Hai";
            this.Hai.MinimumWidth = 6;
            this.Hai.Name = "Hai";
            this.Hai.Width = 125;
            // 
            // Ba
            // 
            this.Ba.HeaderText = "Ba";
            this.Ba.MinimumWidth = 6;
            this.Ba.Name = "Ba";
            this.Ba.Width = 125;
            // 
            // Tu
            // 
            this.Tu.HeaderText = "Tư";
            this.Tu.MinimumWidth = 6;
            this.Tu.Name = "Tu";
            this.Tu.Width = 125;
            // 
            // Nam
            // 
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.Width = 125;
            // 
            // Sau
            // 
            this.Sau.HeaderText = "Sáu";
            this.Sau.MinimumWidth = 6;
            this.Sau.Name = "Sau";
            this.Sau.Width = 125;
            // 
            // Bay
            // 
            this.Bay.HeaderText = "Bảy";
            this.Bay.MinimumWidth = 6;
            this.Bay.Name = "Bay";
            this.Bay.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 670);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buổi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bay;
    }
}