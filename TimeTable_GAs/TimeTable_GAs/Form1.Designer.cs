namespace TimeTable_GAs
{
    partial class Form1
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
            this.Menu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mnTeacher = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnlTeacher = new System.Windows.Forms.ToolStripTextBox();
            this.mnEditTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubject = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnlSubject = new System.Windows.Forms.ToolStripTextBox();
            this.mnEditSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStudent = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnAddStudent = new System.Windows.Forms.ToolStripTextBox();
            this.mnEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRoom = new System.Windows.Forms.MenuStrip();
            this.tool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnlRoom = new System.Windows.Forms.ToolStripTextBox();
            this.mnEditRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClass = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnlClass = new System.Windows.Forms.ToolStripTextBox();
            this.mnEditClass = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbXemTKB = new System.Windows.Forms.ComboBox();
            this.btnXemTKB = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thoiKhoaBieuDataSet = new TimeTable_GAs.ThoiKhoaBieuDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fplTkb = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new TimeTable_GAs.ThoiKhoaBieuDataSetTableAdapters.LopTableAdapter();
            this.thoiKhoaBieuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            this.mnTeacher.SuspendLayout();
            this.mnSubject.SuspendLayout();
            this.mnStudent.SuspendLayout();
            this.mnRoom.SuspendLayout();
            this.mnClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.fplTkb.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.mnTeacher);
            this.Menu.Controls.Add(this.mnSubject);
            this.Menu.Controls.Add(this.mnStudent);
            this.Menu.Controls.Add(this.mnRoom);
            this.Menu.Controls.Add(this.mnClass);
            this.Menu.Controls.Add(this.cmbXemTKB);
            this.Menu.Controls.Add(this.btnXemTKB);
            this.Menu.Controls.Add(this.label23);
            this.Menu.Controls.Add(this.label22);
            this.Menu.Controls.Add(this.label21);
            this.Menu.Controls.Add(this.label20);
            this.Menu.Controls.Add(this.label19);
            this.Menu.Controls.Add(this.label18);
            this.Menu.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(12, 65);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(382, 900);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Rearrange";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRearrange_Click);
            // 
            // mnTeacher
            // 
            this.mnTeacher.AllowItemReorder = true;
            this.mnTeacher.AutoSize = false;
            this.mnTeacher.BackColor = System.Drawing.Color.White;
            this.mnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnTeacher.Dock = System.Windows.Forms.DockStyle.None;
            this.mnTeacher.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.mnTeacher.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
            this.mnTeacher.Location = new System.Drawing.Point(142, 415);
            this.mnTeacher.Name = "mnTeacher";
            this.mnTeacher.Size = new System.Drawing.Size(229, 36);
            this.mnTeacher.TabIndex = 20;
            this.mnTeacher.Text = "menuStrip1";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.mnlTeacher,
            this.mnEditTeacher});
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(134, 32);
            this.toolStripMenuItem8.Text = "-- Select option --";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // mnlTeacher
            // 
            this.mnlTeacher.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlTeacher.Name = "mnlTeacher";
            this.mnlTeacher.Size = new System.Drawing.Size(100, 28);
            this.mnlTeacher.Text = "Teacher List";
            this.mnlTeacher.Click += new System.EventHandler(this.mnlTeacher_Click);
            // 
            // mnEditTeacher
            // 
            this.mnEditTeacher.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold);
            this.mnEditTeacher.Name = "mnEditTeacher";
            this.mnEditTeacher.Size = new System.Drawing.Size(224, 26);
            this.mnEditTeacher.Text = "Edit Teacher";
            this.mnEditTeacher.Click += new System.EventHandler(this.mnEditTeacher_Click);
            // 
            // mnSubject
            // 
            this.mnSubject.AllowItemReorder = true;
            this.mnSubject.AutoSize = false;
            this.mnSubject.BackColor = System.Drawing.Color.White;
            this.mnSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnSubject.Dock = System.Windows.Forms.DockStyle.None;
            this.mnSubject.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.mnSubject.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnSubject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.mnSubject.Location = new System.Drawing.Point(142, 340);
            this.mnSubject.Name = "mnSubject";
            this.mnSubject.Size = new System.Drawing.Size(229, 36);
            this.mnSubject.TabIndex = 19;
            this.mnSubject.Text = "menuStrip1";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.mnlSubject,
            this.mnEditSubject});
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(134, 32);
            this.toolStripMenuItem6.Text = "-- Select option --";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnlSubject
            // 
            this.mnlSubject.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlSubject.Name = "mnlSubject";
            this.mnlSubject.Size = new System.Drawing.Size(100, 28);
            this.mnlSubject.Text = "Subject List";
            this.mnlSubject.Click += new System.EventHandler(this.mnlSubject_Click);
            // 
            // mnEditSubject
            // 
            this.mnEditSubject.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold);
            this.mnEditSubject.Name = "mnEditSubject";
            this.mnEditSubject.Size = new System.Drawing.Size(224, 26);
            this.mnEditSubject.Text = "Edit Student";
            this.mnEditSubject.Click += new System.EventHandler(this.mnEditSubject_Click);
            // 
            // mnStudent
            // 
            this.mnStudent.AllowItemReorder = true;
            this.mnStudent.AutoSize = false;
            this.mnStudent.BackColor = System.Drawing.Color.White;
            this.mnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnStudent.Dock = System.Windows.Forms.DockStyle.None;
            this.mnStudent.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.mnStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.mnStudent.Location = new System.Drawing.Point(142, 265);
            this.mnStudent.Name = "mnStudent";
            this.mnStudent.Size = new System.Drawing.Size(229, 36);
            this.mnStudent.TabIndex = 18;
            this.mnStudent.Text = "menuStrip1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.mnAddStudent,
            this.mnEditStudent});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 32);
            this.toolStripMenuItem4.Text = "-- Select option --";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // mnAddStudent
            // 
            this.mnAddStudent.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnAddStudent.Name = "mnAddStudent";
            this.mnAddStudent.Size = new System.Drawing.Size(100, 28);
            this.mnAddStudent.Text = "Add Student";
            this.mnAddStudent.Click += new System.EventHandler(this.mnAddStudent_Click);
            // 
            // mnEditStudent
            // 
            this.mnEditStudent.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold);
            this.mnEditStudent.Name = "mnEditStudent";
            this.mnEditStudent.Size = new System.Drawing.Size(174, 26);
            this.mnEditStudent.Text = "Edit Student";
            this.mnEditStudent.Click += new System.EventHandler(this.mnEditStudent_Click);
            // 
            // mnRoom
            // 
            this.mnRoom.AllowItemReorder = true;
            this.mnRoom.AutoSize = false;
            this.mnRoom.BackColor = System.Drawing.Color.White;
            this.mnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnRoom.Dock = System.Windows.Forms.DockStyle.None;
            this.mnRoom.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.mnRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool});
            this.mnRoom.Location = new System.Drawing.Point(142, 191);
            this.mnRoom.Name = "mnRoom";
            this.mnRoom.Size = new System.Drawing.Size(229, 36);
            this.mnRoom.TabIndex = 17;
            this.mnRoom.Text = "menuStrip1";
            // 
            // tool
            // 
            this.tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.mnlRoom,
            this.mnEditRoom});
            this.tool.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(134, 32);
            this.tool.Text = "-- Select option --";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnlRoom
            // 
            this.mnlRoom.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlRoom.Name = "mnlRoom";
            this.mnlRoom.Size = new System.Drawing.Size(100, 28);
            this.mnlRoom.Text = "Room List";
            this.mnlRoom.Click += new System.EventHandler(this.mnlRoom_Click);
            // 
            // mnEditRoom
            // 
            this.mnEditRoom.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold);
            this.mnEditRoom.Name = "mnEditRoom";
            this.mnEditRoom.Size = new System.Drawing.Size(224, 26);
            this.mnEditRoom.Text = "Edit Room";
            // 
            // mnClass
            // 
            this.mnClass.AllowItemReorder = true;
            this.mnClass.AutoSize = false;
            this.mnClass.BackColor = System.Drawing.Color.White;
            this.mnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnClass.Dock = System.Windows.Forms.DockStyle.None;
            this.mnClass.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.mnClass.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnClass.Location = new System.Drawing.Point(142, 116);
            this.mnClass.Name = "mnClass";
            this.mnClass.Size = new System.Drawing.Size(229, 36);
            this.mnClass.TabIndex = 4;
            this.mnClass.Text = "menuStrip1";
            this.mnClass.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnlClass,
            this.mnEditClass});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 32);
            this.toolStripMenuItem1.Text = "-- Select option --";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnlClass
            // 
            this.mnlClass.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlClass.Name = "mnlClass";
            this.mnlClass.Size = new System.Drawing.Size(100, 28);
            this.mnlClass.Text = "Class List";
            this.mnlClass.Click += new System.EventHandler(this.mnlClass_Click);
            // 
            // mnEditClass
            // 
            this.mnEditClass.Font = new System.Drawing.Font("Vinhan", 9F, System.Drawing.FontStyle.Bold);
            this.mnEditClass.Name = "mnEditClass";
            this.mnEditClass.Size = new System.Drawing.Size(224, 26);
            this.mnEditClass.Text = "Edit Class";
            this.mnEditClass.Click += new System.EventHandler(this.mnEditClass_Click);
            // 
            // cmbXemTKB
            // 
            this.cmbXemTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbXemTKB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXemTKB.FormattingEnabled = true;
            this.cmbXemTKB.Location = new System.Drawing.Point(142, 41);
            this.cmbXemTKB.Name = "cmbXemTKB";
            this.cmbXemTKB.Size = new System.Drawing.Size(229, 36);
            this.cmbXemTKB.TabIndex = 16;
            this.cmbXemTKB.DropDown += new System.EventHandler(this.cmbXemTKB_DropDown);
            // 
            // btnXemTKB
            // 
            this.btnXemTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXemTKB.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTKB.Location = new System.Drawing.Point(16, 514);
            this.btnXemTKB.Name = "btnXemTKB";
            this.btnXemTKB.Size = new System.Drawing.Size(355, 49);
            this.btnXemTKB.TabIndex = 15;
            this.btnXemTKB.Text = "View TimeTable";
            this.btnXemTKB.UseVisualStyleBackColor = false;
            this.btnXemTKB.Click += new System.EventHandler(this.btnXemTKB_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 415);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 45);
            this.label23.TabIndex = 13;
            this.label23.Text = "Teacher:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 340);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 45);
            this.label22.TabIndex = 11;
            this.label22.Text = "Subject:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 265);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 45);
            this.label21.TabIndex = 9;
            this.label21.Text = "Student:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 45);
            this.label20.TabIndex = 6;
            this.label20.Text = "Room:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 45);
            this.label19.TabIndex = 4;
            this.label19.Text = "Class:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 45);
            this.label18.TabIndex = 2;
            this.label18.Text = "TimeTable:";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.thoiKhoaBieuDataSet;
            // 
            // thoiKhoaBieuDataSet
            // 
            this.thoiKhoaBieuDataSet.DataSetName = "ThoiKhoaBieuDataSet";
            this.thoiKhoaBieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fplTkb);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(412, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1423, 884);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // fplTkb
            // 
            this.fplTkb.Controls.Add(this.label2);
            this.fplTkb.Controls.Add(this.label9);
            this.fplTkb.Controls.Add(this.label10);
            this.fplTkb.Controls.Add(this.label1);
            this.fplTkb.Location = new System.Drawing.Point(6, 91);
            this.fplTkb.Name = "fplTkb";
            this.fplTkb.Size = new System.Drawing.Size(1411, 758);
            this.fplTkb.TabIndex = 60;
            this.fplTkb.Paint += new System.Windows.Forms.PaintEventHandler(this.fplTkb_Paint);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 184);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Location = new System.Drawing.Point(235, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 184);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Location = new System.Drawing.Point(467, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 184);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(699, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 184);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 76);
            this.panel1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1174, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 50);
            this.label3.TabIndex = 25;
            this.label3.Text = "Saturday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 50);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thusday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(940, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 50);
            this.label4.TabIndex = 26;
            this.label4.Text = "Friday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 50);
            this.label7.TabIndex = 24;
            this.label7.Text = "Monday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 50);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tuesday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 50);
            this.label6.TabIndex = 28;
            this.label6.Text = "Wednesday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // thoiKhoaBieuDataSetBindingSource
            // 
            this.thoiKhoaBieuDataSetBindingSource.DataSource = this.thoiKhoaBieuDataSet;
            this.thoiKhoaBieuDataSetBindingSource.Position = 0;
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.thoiKhoaBieuDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 1038);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.mnClass;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.mnTeacher.ResumeLayout(false);
            this.mnTeacher.PerformLayout();
            this.mnSubject.ResumeLayout(false);
            this.mnSubject.PerformLayout();
            this.mnStudent.ResumeLayout(false);
            this.mnStudent.PerformLayout();
            this.mnRoom.ResumeLayout(false);
            this.mnRoom.PerformLayout();
            this.mnClass.ResumeLayout(false);
            this.mnClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.fplTkb.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thoiKhoaBieuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private ThoiKhoaBieuDataSet thoiKhoaBieuDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private ThoiKhoaBieuDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemTKB;
        private System.Windows.Forms.ComboBox cmbXemTKB;
        private System.Windows.Forms.FlowLayoutPanel fplTkb;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private System.Windows.Forms.BindingSource thoiKhoaBieuDataSetBindingSource;
        private System.Windows.Forms.MenuStrip mnClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox mnlClass;
        private System.Windows.Forms.ToolStripMenuItem mnEditClass;
        private System.Windows.Forms.MenuStrip mnTeacher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox mnlTeacher;
        private System.Windows.Forms.ToolStripMenuItem mnEditTeacher;
        private System.Windows.Forms.MenuStrip mnSubject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox mnlSubject;
        private System.Windows.Forms.ToolStripMenuItem mnEditSubject;
        private System.Windows.Forms.MenuStrip mnStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox mnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem mnEditStudent;
        private System.Windows.Forms.MenuStrip mnRoom;
        private System.Windows.Forms.ToolStripMenuItem tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox mnlRoom;
        private System.Windows.Forms.ToolStripMenuItem mnEditRoom;
        private System.Windows.Forms.Button button1;
    }
}

