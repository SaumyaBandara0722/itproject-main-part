namespace itproject
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.panelReport = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dateTimePickerSearchReport = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchReport = new System.Windows.Forms.TextBox();
            this.lblSearchByDateReport = new System.Windows.Forms.Label();
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.lblSearchByEmpIdReport = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReport.Controls.Add(this.btnViewAll);
            this.panelReport.Controls.Add(this.dateTimePickerSearchReport);
            this.panelReport.Controls.Add(this.dataGridViewReport);
            this.panelReport.Controls.Add(this.txtSearchReport);
            this.panelReport.Controls.Add(this.lblSearchByDateReport);
            this.panelReport.Controls.Add(this.btnSearchReport);
            this.panelReport.Controls.Add(this.lblSearchByEmpIdReport);
            this.panelReport.Location = new System.Drawing.Point(51, 95);
            this.panelReport.Margin = new System.Windows.Forms.Padding(4);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(967, 446);
            this.panelReport.TabIndex = 15;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(53, 386);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(848, 33);
            this.btnViewAll.TabIndex = 13;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerSearchReport
            // 
            this.dateTimePickerSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchReport.Location = new System.Drawing.Point(513, 50);
            this.dateTimePickerSearchReport.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerSearchReport.Name = "dateTimePickerSearchReport";
            this.dateTimePickerSearchReport.Size = new System.Drawing.Size(265, 29);
            this.dateTimePickerSearchReport.TabIndex = 12;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EmployeeId,
            this.ArrivedTime,
            this.LeftTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReport.Location = new System.Drawing.Point(53, 92);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.Size = new System.Drawing.Size(848, 265);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmpID";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
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
            // txtSearchReport
            // 
            this.txtSearchReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReport.ForeColor = System.Drawing.Color.Black;
            this.txtSearchReport.Location = new System.Drawing.Point(185, 48);
            this.txtSearchReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchReport.Multiline = true;
            this.txtSearchReport.Name = "txtSearchReport";
            this.txtSearchReport.Size = new System.Drawing.Size(225, 27);
            this.txtSearchReport.TabIndex = 8;
            // 
            // lblSearchByDateReport
            // 
            this.lblSearchByDateReport.AutoSize = true;
            this.lblSearchByDateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDateReport.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDateReport.Location = new System.Drawing.Point(448, 55);
            this.lblSearchByDateReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByDateReport.Name = "lblSearchByDateReport";
            this.lblSearchByDateReport.Size = new System.Drawing.Size(53, 24);
            this.lblSearchByDateReport.TabIndex = 11;
            this.lblSearchByDateReport.Text = "Date:";
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReport.Image")));
            this.btnSearchReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchReport.Location = new System.Drawing.Point(805, 48);
            this.btnSearchReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(96, 37);
            this.btnSearchReport.TabIndex = 9;
            this.btnSearchReport.UseVisualStyleBackColor = false;
            // 
            // lblSearchByEmpIdReport
            // 
            this.lblSearchByEmpIdReport.AutoSize = true;
            this.lblSearchByEmpIdReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByEmpIdReport.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpIdReport.Location = new System.Drawing.Point(49, 50);
            this.lblSearchByEmpIdReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByEmpIdReport.Name = "lblSearchByEmpIdReport";
            this.lblSearchByEmpIdReport.Size = new System.Drawing.Size(121, 24);
            this.lblSearchByEmpIdReport.TabIndex = 10;
            this.lblSearchByEmpIdReport.Text = "Employee Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1068, 636);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
        private System.Windows.Forms.TextBox txtSearchReport;
        private System.Windows.Forms.Label lblSearchByDateReport;
        private System.Windows.Forms.Button btnSearchReport;
        private System.Windows.Forms.Label lblSearchByEmpIdReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}