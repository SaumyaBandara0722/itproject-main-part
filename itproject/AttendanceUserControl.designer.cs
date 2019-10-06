namespace Employee_Management
{
    partial class AttendanceUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceUserControl1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Attendance = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSortByMonthYear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMonthReport = new System.Windows.Forms.TextBox();
            this.lblYearReport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDateReport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpIDReport = new System.Windows.Forms.TextBox();
            this.btnSortByEmployeeId = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEnterLeftTime = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblInTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblLeftTme = new System.Windows.Forms.Label();
            this.lblArrivedTime = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.lblSearchByEmpId = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AttendId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Attendance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Attendance);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 343);
            this.tabControl1.TabIndex = 16;
            // 
            // Attendance
            // 
            this.Attendance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Attendance.Controls.Add(this.panel1);
            this.Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.Location = new System.Drawing.Point(4, 27);
            this.Attendance.Name = "Attendance";
            this.Attendance.Padding = new System.Windows.Forms.Padding(3);
            this.Attendance.Size = new System.Drawing.Size(672, 312);
            this.Attendance.TabIndex = 0;
            this.Attendance.Text = "Attendance";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 273);
            this.panel1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSortByMonthYear);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblMonthReport);
            this.panel3.Controls.Add(this.lblYearReport);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(17, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 53);
            this.panel3.TabIndex = 28;
            // 
            // btnSortByMonthYear
            // 
            this.btnSortByMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByMonthYear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByMonthYear.ForeColor = System.Drawing.Color.White;
            this.btnSortByMonthYear.Location = new System.Drawing.Point(429, 10);
            this.btnSortByMonthYear.Name = "btnSortByMonthYear";
            this.btnSortByMonthYear.Size = new System.Drawing.Size(160, 33);
            this.btnSortByMonthYear.TabIndex = 29;
            this.btnSortByMonthYear.Text = "Generate Report";
            this.btnSortByMonthYear.UseVisualStyleBackColor = false;
            this.btnSortByMonthYear.Click += new System.EventHandler(this.BtnSortByMonthYear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Year:";
            // 
            // lblMonthReport
            // 
            this.lblMonthReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthReport.BackColor = System.Drawing.Color.White;
            this.lblMonthReport.Location = new System.Drawing.Point(286, 14);
            this.lblMonthReport.Name = "lblMonthReport";
            this.lblMonthReport.Size = new System.Drawing.Size(114, 26);
            this.lblMonthReport.TabIndex = 7;
            // 
            // lblYearReport
            // 
            this.lblYearReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYearReport.BackColor = System.Drawing.Color.White;
            this.lblYearReport.Location = new System.Drawing.Point(78, 14);
            this.lblYearReport.Name = "lblYearReport";
            this.lblYearReport.Size = new System.Drawing.Size(124, 26);
            this.lblYearReport.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(216, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Month:";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtDateReport);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.btnSortByDate);
            this.panel9.Location = new System.Drawing.Point(17, 109);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(605, 57);
            this.panel9.TabIndex = 27;
            // 
            // txtDateReport
            // 
            this.txtDateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateReport.BackColor = System.Drawing.Color.White;
            this.txtDateReport.Location = new System.Drawing.Point(147, 15);
            this.txtDateReport.Name = "txtDateReport";
            this.txtDateReport.Size = new System.Drawing.Size(214, 26);
            this.txtDateReport.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDate.ForeColor = System.Drawing.Color.White;
            this.btnSortByDate.Location = new System.Drawing.Point(429, 11);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(160, 33);
            this.btnSortByDate.TabIndex = 8;
            this.btnSortByDate.Text = "Generate Report";
            this.btnSortByDate.UseVisualStyleBackColor = false;
            this.btnSortByDate.Click += new System.EventHandler(this.BtnSortByDate_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.txtEmpIDReport);
            this.panel10.Controls.Add(this.btnSortByEmployeeId);
            this.panel10.Location = new System.Drawing.Point(17, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(605, 56);
            this.panel10.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "EmployeeID";
            // 
            // txtEmpIDReport
            // 
            this.txtEmpIDReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpIDReport.BackColor = System.Drawing.Color.White;
            this.txtEmpIDReport.Location = new System.Drawing.Point(147, 15);
            this.txtEmpIDReport.Name = "txtEmpIDReport";
            this.txtEmpIDReport.Size = new System.Drawing.Size(214, 26);
            this.txtEmpIDReport.TabIndex = 7;
            // 
            // btnSortByEmployeeId
            // 
            this.btnSortByEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByEmployeeId.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByEmployeeId.ForeColor = System.Drawing.Color.White;
            this.btnSortByEmployeeId.Location = new System.Drawing.Point(429, 10);
            this.btnSortByEmployeeId.Name = "btnSortByEmployeeId";
            this.btnSortByEmployeeId.Size = new System.Drawing.Size(160, 33);
            this.btnSortByEmployeeId.TabIndex = 5;
            this.btnSortByEmployeeId.Text = "Generate Report";
            this.btnSortByEmployeeId.UseVisualStyleBackColor = false;
            this.btnSortByEmployeeId.Click += new System.EventHandler(this.Button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert Attendance";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAttendanceId);
            this.panel2.Controls.Add(this.lblEmployeeId);
            this.panel2.Controls.Add(this.lblEnterLeftTime);
            this.panel2.Controls.Add(this.txtEmployeeId);
            this.panel2.Controls.Add(this.lblInTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblLeftTme);
            this.panel2.Controls.Add(this.lblArrivedTime);
            this.panel2.Location = new System.Drawing.Point(118, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 269);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.AutoSize = true;
            this.lblAttendanceId.Location = new System.Drawing.Point(94, 9);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(0, 18);
            this.lblAttendanceId.TabIndex = 12;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.White;
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeId.Location = new System.Drawing.Point(47, 36);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblEnterLeftTime
            // 
            this.lblEnterLeftTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterLeftTime.AutoSize = true;
            this.lblEnterLeftTime.ForeColor = System.Drawing.Color.Black;
            this.lblEnterLeftTime.Location = new System.Drawing.Point(182, 165);
            this.lblEnterLeftTime.Name = "lblEnterLeftTime";
            this.lblEnterLeftTime.Size = new System.Drawing.Size(130, 18);
            this.lblEnterLeftTime.TabIndex = 11;
            this.lblEnterLeftTime.Text = "Enter left time later";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Location = new System.Drawing.Point(185, 30);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 24);
            this.txtEmployeeId.TabIndex = 6;
            // 
            // lblInTime
            // 
            this.lblInTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInTime.AutoSize = true;
            this.lblInTime.BackColor = System.Drawing.Color.DarkGray;
            this.lblInTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInTime.ForeColor = System.Drawing.Color.Black;
            this.lblInTime.Location = new System.Drawing.Point(182, 121);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(2, 20);
            this.lblInTime.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(47, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(57, 220);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(335, 33);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblLeftTme
            // 
            this.lblLeftTme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeftTme.AutoSize = true;
            this.lblLeftTme.BackColor = System.Drawing.Color.White;
            this.lblLeftTme.ForeColor = System.Drawing.Color.Black;
            this.lblLeftTme.Location = new System.Drawing.Point(46, 165);
            this.lblLeftTme.Name = "lblLeftTme";
            this.lblLeftTme.Size = new System.Drawing.Size(73, 18);
            this.lblLeftTme.TabIndex = 4;
            this.lblLeftTme.Text = "Left Time:";
            // 
            // lblArrivedTime
            // 
            this.lblArrivedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArrivedTime.AutoSize = true;
            this.lblArrivedTime.BackColor = System.Drawing.Color.White;
            this.lblArrivedTime.ForeColor = System.Drawing.Color.Black;
            this.lblArrivedTime.Location = new System.Drawing.Point(46, 121);
            this.lblArrivedTime.Name = "lblArrivedTime";
            this.lblArrivedTime.Size = new System.Drawing.Size(94, 18);
            this.lblArrivedTime.TabIndex = 3;
            this.lblArrivedTime.Text = "Arrived Time:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.dateTimePickerSearch);
            this.tabPage3.Controls.Add(this.lblSearchByDate);
            this.tabPage3.Controls.Add(this.lblSearchByEmpId);
            this.tabPage3.Controls.Add(this.btnViewAll);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.dataGridView);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Attendanace";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(368, 17);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerSearch.TabIndex = 15;
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDate.Location = new System.Drawing.Point(319, 21);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(43, 18);
            this.lblSearchByDate.TabIndex = 14;
            this.lblSearchByDate.Text = "Date:";
            // 
            // lblSearchByEmpId
            // 
            this.lblSearchByEmpId.AutoSize = true;
            this.lblSearchByEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpId.Location = new System.Drawing.Point(20, 17);
            this.lblSearchByEmpId.Name = "lblSearchByEmpId";
            this.lblSearchByEmpId.Size = new System.Drawing.Size(93, 18);
            this.lblSearchByEmpId.TabIndex = 13;
            this.lblSearchByEmpId.Text = "Employee Id:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(13, 262);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(646, 34);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(119, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendId,
            this.EmpId,
            this.Date,
            this.ArrivedTime,
            this.LeftTime,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(13, 51);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Size = new System.Drawing.Size(646, 196);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AttendId
            // 
            this.AttendId.DataPropertyName = "AttendID";
            this.AttendId.HeaderText = "AttendId";
            this.AttendId.Name = "AttendId";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpID";
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ArrivedTime
            // 
            this.ArrivedTime.DataPropertyName = "inTime";
            this.ArrivedTime.HeaderText = "Arrived Time";
            this.ArrivedTime.Name = "ArrivedTime";
            this.ArrivedTime.ReadOnly = true;
            // 
            // LeftTime
            // 
            this.LeftTime.DataPropertyName = "outTime";
            this.LeftTime.HeaderText = "Left Time";
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(587, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AttendanceUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AttendanceUserControl1";
            this.Size = new System.Drawing.Size(683, 508);
            this.Load += new System.EventHandler(this.AttendanceUserControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.Attendance.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Attendance;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEnterLeftTime;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblLeftTme;
        private System.Windows.Forms.Label lblArrivedTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.Label lblSearchByEmpId;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSortByEmployeeId;
        private System.Windows.Forms.TextBox lblMonthReport;
        private System.Windows.Forms.TextBox txtDateReport;
        private System.Windows.Forms.TextBox lblYearReport;
        private System.Windows.Forms.TextBox txtEmpIDReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSortByMonthYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
