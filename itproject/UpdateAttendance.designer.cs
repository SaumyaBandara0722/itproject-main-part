namespace Employee_Management
{
    partial class UpdateAttendance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOutTime = new System.Windows.Forms.Label();
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.txtUpdateEmpID = new System.Windows.Forms.TextBox();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblInTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.lblLeftTme = new System.Windows.Forms.Label();
            this.lblArrivedTime = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOutTime);
            this.panel2.Controls.Add(this.lblLeftTime);
            this.panel2.Controls.Add(this.txtUpdateEmpID);
            this.panel2.Controls.Add(this.lblAttendanceId);
            this.panel2.Controls.Add(this.lblEmployeeId);
            this.panel2.Controls.Add(this.lblInTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.dateTimePickerUpdate);
            this.panel2.Controls.Add(this.lblLeftTme);
            this.panel2.Controls.Add(this.lblArrivedTime);
            this.panel2.Location = new System.Drawing.Point(129, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 350);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lblOutTime
            // 
            this.lblOutTime.AutoSize = true;
            this.lblOutTime.BackColor = System.Drawing.Color.DarkGray;
            this.lblOutTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTime.ForeColor = System.Drawing.Color.Black;
            this.lblOutTime.Location = new System.Drawing.Point(180, 191);
            this.lblOutTime.Name = "lblOutTime";
            this.lblOutTime.Size = new System.Drawing.Size(2, 20);
            this.lblOutTime.TabIndex = 15;
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.BackColor = System.Drawing.Color.Gray;
            this.lblLeftTime.Location = new System.Drawing.Point(182, 164);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(0, 13);
            this.lblLeftTime.TabIndex = 14;
            // 
            // txtUpdateEmpID
            // 
            this.txtUpdateEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmpID.Location = new System.Drawing.Point(185, 37);
            this.txtUpdateEmpID.Name = "txtUpdateEmpID";
            this.txtUpdateEmpID.Size = new System.Drawing.Size(200, 24);
            this.txtUpdateEmpID.TabIndex = 13;
            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.AutoSize = true;
            this.lblAttendanceId.Location = new System.Drawing.Point(94, 9);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(0, 13);
            this.lblAttendanceId.TabIndex = 12;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.White;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeId.Location = new System.Drawing.Point(47, 36);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.BackColor = System.Drawing.Color.DarkGray;
            this.lblInTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTime.ForeColor = System.Drawing.Color.Black;
            this.lblInTime.Location = new System.Drawing.Point(180, 135);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(2, 20);
            this.lblInTime.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(47, 89);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(37, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(434, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Enabled = false;
            this.dateTimePickerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(185, 87);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerUpdate.TabIndex = 7;
            // 
            // lblLeftTme
            // 
            this.lblLeftTme.AutoSize = true;
            this.lblLeftTme.BackColor = System.Drawing.Color.White;
            this.lblLeftTme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTme.ForeColor = System.Drawing.Color.Black;
            this.lblLeftTme.Location = new System.Drawing.Point(46, 191);
            this.lblLeftTme.Name = "lblLeftTme";
            this.lblLeftTme.Size = new System.Drawing.Size(73, 18);
            this.lblLeftTme.TabIndex = 4;
            this.lblLeftTme.Text = "Left Time:";
            // 
            // lblArrivedTime
            // 
            this.lblArrivedTime.AutoSize = true;
            this.lblArrivedTime.BackColor = System.Drawing.Color.White;
            this.lblArrivedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivedTime.ForeColor = System.Drawing.Color.Black;
            this.lblArrivedTime.Location = new System.Drawing.Point(46, 135);
            this.lblArrivedTime.Name = "lblArrivedTime";
            this.lblArrivedTime.Size = new System.Drawing.Size(94, 18);
            this.lblArrivedTime.TabIndex = 3;
            this.lblArrivedTime.Text = "Arrived Time:";
            // 
            // UpdateAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateAttendance";
            this.Text = "UpdateAttendance";
            this.Load += new System.EventHandler(this.UpdateAttendance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.Label lblLeftTme;
        private System.Windows.Forms.Label lblArrivedTime;
        private System.Windows.Forms.TextBox txtUpdateEmpID;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label lblLeftTime;
        private System.Windows.Forms.Label lblOutTime;
    }
}