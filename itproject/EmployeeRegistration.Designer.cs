namespace itproject
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
            this.txtJoinedDate = new System.Windows.Forms.TextBox();
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
            this.txtBdy = new System.Windows.Forms.TextBox();
            this.lblBdy = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.lblempName = new System.Windows.Forms.Label();
            this.txtempId = new System.Windows.Forms.TextBox();
            this.lblempId = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJoinedDate
            // 
            this.txtJoinedDate.Location = new System.Drawing.Point(183, 392);
            this.txtJoinedDate.Name = "txtJoinedDate";
            this.txtJoinedDate.Size = new System.Drawing.Size(288, 20);
            this.txtJoinedDate.TabIndex = 42;
            // 
            // lblJoinedDate
            // 
            this.lblJoinedDate.AutoSize = true;
            this.lblJoinedDate.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinedDate.Location = new System.Drawing.Point(18, 389);
            this.lblJoinedDate.Name = "lblJoinedDate";
            this.lblJoinedDate.Size = new System.Drawing.Size(96, 23);
            this.lblJoinedDate.TabIndex = 41;
            this.lblJoinedDate.Text = "Joined Date";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(558, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 60);
            this.button3.TabIndex = 40;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 61);
            this.button2.TabIndex = 39;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 65);
            this.button1.TabIndex = 38;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Embroidery",
            "Iron and Warehouse",
            "Line"});
            this.comboBox2.Location = new System.Drawing.Point(183, 349);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(18, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 23);
            this.lblGender.TabIndex = 36;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.LblGender_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(183, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdd.Location = new System.Drawing.Point(183, 188);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(288, 52);
            this.txtAdd.TabIndex = 34;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(18, 190);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(67, 23);
            this.lbladd.TabIndex = 33;
            this.lbladd.Text = "Address";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtNum.Location = new System.Drawing.Point(183, 262);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(288, 20);
            this.txtNum.TabIndex = 32;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(18, 259);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(121, 23);
            this.lblNum.TabIndex = 31;
            this.lblNum.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(183, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 302);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 23);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email Address";
            // 
            // txtBdy
            // 
            this.txtBdy.BackColor = System.Drawing.SystemColors.Window;
            this.txtBdy.Location = new System.Drawing.Point(183, 103);
            this.txtBdy.Name = "txtBdy";
            this.txtBdy.Size = new System.Drawing.Size(288, 20);
            this.txtBdy.TabIndex = 28;
            // 
            // lblBdy
            // 
            this.lblBdy.AutoSize = true;
            this.lblBdy.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdy.Location = new System.Drawing.Point(18, 100);
            this.lblBdy.Name = "lblBdy";
            this.lblBdy.Size = new System.Drawing.Size(107, 23);
            this.lblBdy.TabIndex = 27;
            this.lblBdy.Text = "Date of Birth";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(18, 347);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(98, 23);
            this.lblDept.TabIndex = 26;
            this.lblDept.Text = "Department";
            // 
            // txtempName
            // 
            this.txtempName.BackColor = System.Drawing.SystemColors.Window;
            this.txtempName.Location = new System.Drawing.Point(183, 61);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(288, 20);
            this.txtempName.TabIndex = 25;
            // 
            // lblempName
            // 
            this.lblempName.AutoSize = true;
            this.lblempName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempName.Location = new System.Drawing.Point(18, 58);
            this.lblempName.Name = "lblempName";
            this.lblempName.Size = new System.Drawing.Size(130, 23);
            this.lblempName.TabIndex = 24;
            this.lblempName.Text = "Employee Name";
            // 
            // txtempId
            // 
            this.txtempId.BackColor = System.Drawing.SystemColors.Window;
            this.txtempId.Location = new System.Drawing.Point(183, 18);
            this.txtempId.Name = "txtempId";
            this.txtempId.ReadOnly = true;
            this.txtempId.Size = new System.Drawing.Size(288, 20);
            this.txtempId.TabIndex = 23;
            // 
            // lblempId
            // 
            this.lblempId.AutoSize = true;
            this.lblempId.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblempId.Location = new System.Drawing.Point(18, 18);
            this.lblempId.Name = "lblempId";
            this.lblempId.Size = new System.Drawing.Size(104, 23);
            this.lblempId.TabIndex = 22;
            this.lblempId.Text = "Employee ID";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(18, 434);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(102, 23);
            this.lblSal.TabIndex = 43;
            this.lblSal.Text = "Basic Salary";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(183, 437);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(288, 20);
            this.txtSal.TabIndex = 44;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(477, 18);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(405, 115);
            this.dataGridViewDetails.TabIndex = 45;
            this.dataGridViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDetails_CellContentClick);
            this.dataGridViewDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewDetails_RowHeaderMouseClick);
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 501);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtJoinedDate);
            this.Controls.Add(this.lblJoinedDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBdy);
            this.Controls.Add(this.lblBdy);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtempName);
            this.Controls.Add(this.lblempName);
            this.Controls.Add(this.txtempId);
            this.Controls.Add(this.lblempId);
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtJoinedDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBdy;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.TextBox txtempId;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
    }
}