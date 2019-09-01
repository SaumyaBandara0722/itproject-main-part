namespace itproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.buttonStocks = new System.Windows.Forms.Button();
            this.buttonProjectsAndTasks = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.buttonLeaveManagement = new System.Windows.Forms.Button();
            this.buttonLeaveRequestPortal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeDetailsUserControl1 = new itproject.EmployeeDetailsUserControl();
            this.loanUserControl1 = new itproject.LoanUserControl();
            this.patternAndStockManagement1 = new itproject.PatternAndStockManagement();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DimGray;
            this.sidePanel.Controls.Add(this.buttonLoan);
            this.sidePanel.Controls.Add(this.buttonStocks);
            this.sidePanel.Controls.Add(this.buttonProjectsAndTasks);
            this.sidePanel.Controls.Add(this.buttonCustomers);
            this.sidePanel.Controls.Add(this.buttonPayroll);
            this.sidePanel.Controls.Add(this.buttonLeaveManagement);
            this.sidePanel.Controls.Add(this.buttonLeaveRequestPortal);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.buttonEmployees);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(335, 878);
            this.sidePanel.TabIndex = 0;
            // 
            // buttonLoan
            // 
            this.buttonLoan.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoan.Image")));
            this.buttonLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoan.Location = new System.Drawing.Point(21, 802);
            this.buttonLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoan.Name = "buttonLoan";
            this.buttonLoan.Size = new System.Drawing.Size(285, 74);
            this.buttonLoan.TabIndex = 10;
            this.buttonLoan.Text = "Loan";
            this.buttonLoan.UseVisualStyleBackColor = true;
            this.buttonLoan.Click += new System.EventHandler(this.ButtonLoan_Click);
            // 
            // buttonStocks
            // 
            this.buttonStocks.Image = ((System.Drawing.Image)(resources.GetObject("buttonStocks.Image")));
            this.buttonStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStocks.Location = new System.Drawing.Point(21, 718);
            this.buttonStocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStocks.Name = "buttonStocks";
            this.buttonStocks.Size = new System.Drawing.Size(285, 74);
            this.buttonStocks.TabIndex = 9;
            this.buttonStocks.Text = "Stocks";
            this.buttonStocks.UseVisualStyleBackColor = true;
            this.buttonStocks.Click += new System.EventHandler(this.ButtonStocks_Click);
            // 
            // buttonProjectsAndTasks
            // 
            this.buttonProjectsAndTasks.Image = ((System.Drawing.Image)(resources.GetObject("buttonProjectsAndTasks.Image")));
            this.buttonProjectsAndTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectsAndTasks.Location = new System.Drawing.Point(23, 626);
            this.buttonProjectsAndTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProjectsAndTasks.Name = "buttonProjectsAndTasks";
            this.buttonProjectsAndTasks.Size = new System.Drawing.Size(285, 74);
            this.buttonProjectsAndTasks.TabIndex = 4;
            this.buttonProjectsAndTasks.Text = "Projects and Tasks";
            this.buttonProjectsAndTasks.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomers.Image")));
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(23, 526);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(285, 74);
            this.buttonCustomers.TabIndex = 8;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.Image = ((System.Drawing.Image)(resources.GetObject("buttonPayroll.Image")));
            this.buttonPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.Location = new System.Drawing.Point(23, 423);
            this.buttonPayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(285, 74);
            this.buttonPayroll.TabIndex = 7;
            this.buttonPayroll.Text = "Payroll";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            // 
            // buttonLeaveManagement
            // 
            this.buttonLeaveManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeaveManagement.Image")));
            this.buttonLeaveManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeaveManagement.Location = new System.Drawing.Point(21, 320);
            this.buttonLeaveManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeaveManagement.Name = "buttonLeaveManagement";
            this.buttonLeaveManagement.Size = new System.Drawing.Size(285, 74);
            this.buttonLeaveManagement.TabIndex = 6;
            this.buttonLeaveManagement.Text = "Leave Management";
            this.buttonLeaveManagement.UseVisualStyleBackColor = true;
            // 
            // buttonLeaveRequestPortal
            // 
            this.buttonLeaveRequestPortal.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeaveRequestPortal.Image")));
            this.buttonLeaveRequestPortal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeaveRequestPortal.Location = new System.Drawing.Point(23, 234);
            this.buttonLeaveRequestPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeaveRequestPortal.Name = "buttonLeaveRequestPortal";
            this.buttonLeaveRequestPortal.Size = new System.Drawing.Size(285, 74);
            this.buttonLeaveRequestPortal.TabIndex = 5;
            this.buttonLeaveRequestPortal.Text = "Leave Request Portal";
            this.buttonLeaveRequestPortal.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(23, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Time and Attendance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(23, 26);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(285, 74);
            this.buttonEmployees.TabIndex = 3;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.ButtonEmployees_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(335, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1337, 10);
            this.topPanel.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightBlue;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Location = new System.Drawing.Point(351, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(165, 217);
            this.logoPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // employeeDetailsUserControl1
            // 
            this.employeeDetailsUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeDetailsUserControl1.BackgroundImage")));
            this.employeeDetailsUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeeDetailsUserControl1.ForeColor = System.Drawing.Color.White;
            this.employeeDetailsUserControl1.Location = new System.Drawing.Point(553, 286);
            this.employeeDetailsUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.employeeDetailsUserControl1.Name = "employeeDetailsUserControl1";
            this.employeeDetailsUserControl1.Size = new System.Drawing.Size(896, 415);
            this.employeeDetailsUserControl1.TabIndex = 3;
            // 
            // loanUserControl1
            // 
            this.loanUserControl1.Location = new System.Drawing.Point(369, 26);
            this.loanUserControl1.Name = "loanUserControl1";
            this.loanUserControl1.Size = new System.Drawing.Size(1217, 747);
            this.loanUserControl1.TabIndex = 4;
            // 
            // patternAndStockManagement1
            // 
            this.patternAndStockManagement1.Location = new System.Drawing.Point(341, 190);
            this.patternAndStockManagement1.Name = "patternAndStockManagement1";
            this.patternAndStockManagement1.Size = new System.Drawing.Size(1043, 567);
            this.patternAndStockManagement1.TabIndex = 5;
            this.patternAndStockManagement1.Load += new System.EventHandler(this.PatternAndStockManagement1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 878);
            this.Controls.Add(this.patternAndStockManagement1);
            this.Controls.Add(this.loanUserControl1);
            this.Controls.Add(this.employeeDetailsUserControl1);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonStocks;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonProjectsAndTasks;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.Button buttonLeaveManagement;
        private System.Windows.Forms.Button buttonLeaveRequestPortal;
        private System.Windows.Forms.Button button2;
        private EmployeeDetailsUserControl employeeDetailsUserControl1;
        private System.Windows.Forms.Button buttonLoan;
        private LoanUserControl loanUserControl1;
        private PatternAndStockManagement patternAndStockManagement1;
        //  private LoanUserControl1 loanUserControl11;
    }
}

