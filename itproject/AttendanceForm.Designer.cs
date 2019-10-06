namespace itproject
{
    partial class AttendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.lblSearchByEmpId = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.AttendId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Attendance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(899, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Attendanace";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(491, 21);
            this.dateTimePickerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(265, 29);
            this.dateTimePickerSearch.TabIndex = 15;
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDate.Location = new System.Drawing.Point(425, 26);
            this.lblSearchByDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(53, 24);
            this.lblSearchByDate.TabIndex = 14;
            this.lblSearchByDate.Text = "Date:";
            // 
            // lblSearchByEmpId
            // 
            this.lblSearchByEmpId.AutoSize = true;
            this.lblSearchByEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpId.Location = new System.Drawing.Point(27, 21);
            this.lblSearchByEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByEmpId.Name = "lblSearchByEmpId";
            this.lblSearchByEmpId.Size = new System.Drawing.Size(121, 24);
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
            this.btnViewAll.Location = new System.Drawing.Point(17, 322);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(861, 42);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(159, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 27);
            this.txtSearch.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendId,
            this.EmpId,
            this.ArrivedTime,
            this.LeftTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(17, 63);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Size = new System.Drawing.Size(861, 241);
            this.dataGridView.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(783, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 37);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Attendance);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(73, 234);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 422);
            this.tabControl1.TabIndex = 18;
            // 
            // Attendance
            // 
            this.Attendance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Attendance.Controls.Add(this.panel1);
            this.Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.Location = new System.Drawing.Point(4, 33);
            this.Attendance.Margin = new System.Windows.Forms.Padding(4);
            this.Attendance.Name = "Attendance";
            this.Attendance.Padding = new System.Windows.Forms.Padding(4);
            this.Attendance.Size = new System.Drawing.Size(899, 385);
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
            this.panel1.Location = new System.Drawing.Point(8, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 336);
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
            this.panel3.Location = new System.Drawing.Point(23, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 65);
            this.panel3.TabIndex = 28;
            // 
            // btnSortByMonthYear
            // 
            this.btnSortByMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByMonthYear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByMonthYear.ForeColor = System.Drawing.Color.White;
            this.btnSortByMonthYear.Location = new System.Drawing.Point(572, 12);
            this.btnSortByMonthYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortByMonthYear.Name = "btnSortByMonthYear";
            this.btnSortByMonthYear.Size = new System.Drawing.Size(213, 41);
            this.btnSortByMonthYear.TabIndex = 29;
            this.btnSortByMonthYear.Text = "Generate Report";
            this.btnSortByMonthYear.UseVisualStyleBackColor = false;
            this.btnSortByMonthYear.Click += new System.EventHandler(this.btnSortByMonthYear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Year:";
            // 
            // lblMonthReport
            // 
            this.lblMonthReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthReport.BackColor = System.Drawing.Color.White;
            this.lblMonthReport.Location = new System.Drawing.Point(381, 17);
            this.lblMonthReport.Margin = new System.Windows.Forms.Padding(4);
            this.lblMonthReport.Name = "lblMonthReport";
            this.lblMonthReport.Size = new System.Drawing.Size(151, 30);
            this.lblMonthReport.TabIndex = 7;
            // 
            // lblYearReport
            // 
            this.lblYearReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYearReport.BackColor = System.Drawing.Color.White;
            this.lblYearReport.Location = new System.Drawing.Point(104, 17);
            this.lblYearReport.Margin = new System.Windows.Forms.Padding(4);
            this.lblYearReport.Name = "lblYearReport";
            this.lblYearReport.Size = new System.Drawing.Size(164, 30);
            this.lblYearReport.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(288, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
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
            this.panel9.Location = new System.Drawing.Point(23, 134);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(806, 70);
            this.panel9.TabIndex = 27;
            // 
            // txtDateReport
            // 
            this.txtDateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateReport.BackColor = System.Drawing.Color.White;
            this.txtDateReport.Location = new System.Drawing.Point(196, 18);
            this.txtDateReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateReport.Name = "txtDateReport";
            this.txtDateReport.Size = new System.Drawing.Size(284, 30);
            this.txtDateReport.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDate.ForeColor = System.Drawing.Color.White;
            this.btnSortByDate.Location = new System.Drawing.Point(572, 14);
            this.btnSortByDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(213, 41);
            this.btnSortByDate.TabIndex = 8;
            this.btnSortByDate.Text = "Generate Report";
            this.btnSortByDate.UseVisualStyleBackColor = false;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
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
            this.panel10.Location = new System.Drawing.Point(23, 44);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(806, 68);
            this.panel10.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "EmployeeID";
            // 
            // txtEmpIDReport
            // 
            this.txtEmpIDReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpIDReport.BackColor = System.Drawing.Color.White;
            this.txtEmpIDReport.Location = new System.Drawing.Point(196, 18);
            this.txtEmpIDReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpIDReport.Name = "txtEmpIDReport";
            this.txtEmpIDReport.Size = new System.Drawing.Size(284, 30);
            this.txtEmpIDReport.TabIndex = 7;
            // 
            // btnSortByEmployeeId
            // 
            this.btnSortByEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByEmployeeId.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSortByEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByEmployeeId.ForeColor = System.Drawing.Color.White;
            this.btnSortByEmployeeId.Location = new System.Drawing.Point(572, 12);
            this.btnSortByEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortByEmployeeId.Name = "btnSortByEmployeeId";
            this.btnSortByEmployeeId.Size = new System.Drawing.Size(213, 41);
            this.btnSortByEmployeeId.TabIndex = 5;
            this.btnSortByEmployeeId.Text = "Generate Report";
            this.btnSortByEmployeeId.UseVisualStyleBackColor = false;
            this.btnSortByEmployeeId.Click += new System.EventHandler(this.btnSortByEmployeeId_Click);
            // 
            // AttendId
            // 
            this.AttendId.DataPropertyName = "AttendID";
            this.AttendId.HeaderText = "AttendId";
            this.AttendId.MinimumWidth = 6;
            this.AttendId.Name = "AttendId";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpID";
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // ArrivedTime
            // 
            this.ArrivedTime.DataPropertyName = "inTime";
            this.ArrivedTime.HeaderText = "Arrived Time";
            this.ArrivedTime.MinimumWidth = 6;
            this.ArrivedTime.Name = "ArrivedTime";
            this.ArrivedTime.ReadOnly = true;
            // 
            // LeftTime
            // 
            this.LeftTime.DataPropertyName = "outTime";
            this.LeftTime.HeaderText = "Left Time";
            this.LeftTime.MinimumWidth = 6;
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Attendance.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.Label lblSearchByEmpId;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Attendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSortByMonthYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lblMonthReport;
        private System.Windows.Forms.TextBox lblYearReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDateReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpIDReport;
        private System.Windows.Forms.Button btnSortByEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
    }
}