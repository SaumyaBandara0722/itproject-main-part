﻿namespace itproject
{
    partial class EmployeeRegistration
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
            this.lblJoinedDate = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lbladd = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBdy = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.lblempName = new System.Windows.Forms.Label();
            this.txtempId = new System.Windows.Forms.TextBox();
            this.lblempId = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.txtBdy = new System.Windows.Forms.DateTimePicker();
            this.txtJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddNewDep = new System.Windows.Forms.Button();
            this.txtEnterDep = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJoinedDate
            // 
            this.lblJoinedDate.AutoSize = true;
            this.lblJoinedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblJoinedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblJoinedDate.Location = new System.Drawing.Point(4, 471);
            this.lblJoinedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoinedDate.Name = "lblJoinedDate";
            this.lblJoinedDate.Size = new System.Drawing.Size(142, 29);
            this.lblJoinedDate.TabIndex = 41;
            this.lblJoinedDate.Text = "Joined Date";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(4, 319);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 62);
            this.button3.TabIndex = 40;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(4, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 55);
            this.button2.TabIndex = 39;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 62);
            this.button1.TabIndex = 38;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 419);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(341, 24);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.ComboBox2_SelectedValueChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGender.Location = new System.Drawing.Point(4, 168);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(94, 29);
            this.lblGender.TabIndex = 36;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.LblGender_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(218, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 24);
            this.comboBox1.TabIndex = 35;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdd.Location = new System.Drawing.Point(218, 228);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(341, 63);
            this.txtAdd.TabIndex = 34;
            this.txtAdd.TextChanged += new System.EventHandler(this.TxtAdd_TextChanged);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.Transparent;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbladd.Location = new System.Drawing.Point(4, 224);
            this.lbladd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(102, 29);
            this.lbladd.TabIndex = 33;
            this.lbladd.Text = "Address";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtNum.Location = new System.Drawing.Point(218, 307);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(341, 22);
            this.txtNum.TabIndex = 32;
            this.txtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNum.Location = new System.Drawing.Point(4, 303);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(176, 29);
            this.lblNum.TabIndex = 31;
            this.lblNum.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(218, 363);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(341, 22);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmail.Location = new System.Drawing.Point(4, 359);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(169, 29);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email Address";
            // 
            // lblBdy
            // 
            this.lblBdy.AutoSize = true;
            this.lblBdy.BackColor = System.Drawing.Color.Transparent;
            this.lblBdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblBdy.Location = new System.Drawing.Point(4, 112);
            this.lblBdy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBdy.Name = "lblBdy";
            this.lblBdy.Size = new System.Drawing.Size(144, 29);
            this.lblBdy.TabIndex = 27;
            this.lblBdy.Text = "Date of Birth";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDept.Location = new System.Drawing.Point(4, 415);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(138, 29);
            this.lblDept.TabIndex = 26;
            this.lblDept.Text = "Department";
            // 
            // txtempName
            // 
            this.txtempName.BackColor = System.Drawing.SystemColors.Window;
            this.txtempName.Location = new System.Drawing.Point(218, 60);
            this.txtempName.Margin = new System.Windows.Forms.Padding(4);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(341, 22);
            this.txtempName.TabIndex = 25;
            this.txtempName.TextChanged += new System.EventHandler(this.b);
            // 
            // lblempName
            // 
            this.lblempName.AutoSize = true;
            this.lblempName.BackColor = System.Drawing.Color.Transparent;
            this.lblempName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempName.Location = new System.Drawing.Point(4, 56);
            this.lblempName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblempName.Name = "lblempName";
            this.lblempName.Size = new System.Drawing.Size(193, 29);
            this.lblempName.TabIndex = 24;
            this.lblempName.Text = "Employee Name";
            // 
            // txtempId
            // 
            this.txtempId.BackColor = System.Drawing.SystemColors.Window;
            this.txtempId.Location = new System.Drawing.Point(218, 4);
            this.txtempId.Margin = new System.Windows.Forms.Padding(4);
            this.txtempId.Name = "txtempId";
            this.txtempId.ReadOnly = true;
            this.txtempId.Size = new System.Drawing.Size(341, 22);
            this.txtempId.TabIndex = 23;
            // 
            // lblempId
            // 
            this.lblempId.AutoSize = true;
            this.lblempId.BackColor = System.Drawing.Color.Transparent;
            this.lblempId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblempId.Location = new System.Drawing.Point(4, 0);
            this.lblempId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblempId.Name = "lblempId";
            this.lblempId.Size = new System.Drawing.Size(151, 29);
            this.lblempId.TabIndex = 22;
            this.lblempId.Text = "Employee ID";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.BackColor = System.Drawing.Color.Transparent;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSal.Location = new System.Drawing.Point(4, 527);
            this.lblSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(145, 29);
            this.lblSal.TabIndex = 43;
            this.lblSal.Text = "Basic Salary";
            this.lblSal.Click += new System.EventHandler(this.LblSal_Click);
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(218, 531);
            this.txtSal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(341, 22);
            this.txtSal.TabIndex = 44;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(603, 55);
            this.dataGridViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 51;
            this.dataGridViewDetails.Size = new System.Drawing.Size(540, 142);
            this.dataGridViewDetails.TabIndex = 45;
            this.dataGridViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetails_CellContentClick);
            this.dataGridViewDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewDetails_RowHeaderMouseClick);
            // 
            // txtBdy
            // 
            this.txtBdy.Location = new System.Drawing.Point(218, 116);
            this.txtBdy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBdy.Name = "txtBdy";
            this.txtBdy.Size = new System.Drawing.Size(341, 22);
            this.txtBdy.TabIndex = 46;
            // 
            // txtJoinedDate
            // 
            this.txtJoinedDate.Location = new System.Drawing.Point(218, 475);
            this.txtJoinedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtJoinedDate.Name = "txtJoinedDate";
            this.txtJoinedDate.Size = new System.Drawing.Size(341, 22);
            this.txtJoinedDate.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::itproject.Properties.Resources.angryimg;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0283F));
            this.tableLayoutPanel1.Controls.Add(this.lblempId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtJoinedDate, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtSal, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtempId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSal, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtBdy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblempName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtempName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJoinedDate, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblBdy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGender, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbladd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtAdd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDept, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblNum, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 587);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::itproject.Properties.Resources.angryimg;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddNewDep);
            this.groupBox1.Controls.Add(this.txtEnterDep);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 170);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Department";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Salmon;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(97, 121);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAddNewDep
            // 
            this.btnAddNewDep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewDep.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDep.Location = new System.Drawing.Point(97, 85);
            this.btnAddNewDep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewDep.Name = "btnAddNewDep";
            this.btnAddNewDep.Size = new System.Drawing.Size(100, 28);
            this.btnAddNewDep.TabIndex = 1;
            this.btnAddNewDep.Text = "ADD";
            this.btnAddNewDep.UseVisualStyleBackColor = false;
            this.btnAddNewDep.Click += new System.EventHandler(this.BtnAddNewDep_Click);
            // 
            // txtEnterDep
            // 
            this.txtEnterDep.Location = new System.Drawing.Point(57, 42);
            this.txtEnterDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterDep.Name = "txtEnterDep";
            this.txtEnterDep.Size = new System.Drawing.Size(180, 22);
            this.txtEnterDep.TabIndex = 0;
            this.txtEnterDep.TextChanged += new System.EventHandler(this.TxtEnterDep_TextChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.BackgroundImage = global::itproject.Properties.Resources.angryimg;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(725, 222);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.82353F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.35294F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33923F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.18879F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(308, 417);
            this.tableLayoutPanel5.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::itproject.Properties.Resources.angryimg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 690);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblJoinedDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBdy;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblempName;
        private System.Windows.Forms.Label lblempId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSal;
        public System.Windows.Forms.DataGridView dataGridViewDetails;
        public System.Windows.Forms.TextBox txtempId;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtempName;
        public System.Windows.Forms.TextBox txtSal;
        public System.Windows.Forms.DateTimePicker txtBdy;
        public System.Windows.Forms.DateTimePicker txtJoinedDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddNewDep;
        private System.Windows.Forms.TextBox txtEnterDep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}