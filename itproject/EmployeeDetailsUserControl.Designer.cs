namespace itproject
{
    partial class EmployeeDetailsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailsUserControl));
            this.btnRgister = new System.Windows.Forms.Button();
            this.btnViewEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRgister
            // 
            this.btnRgister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRgister.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRgister.ForeColor = System.Drawing.Color.White;
            this.btnRgister.Location = new System.Drawing.Point(225, 46);
            this.btnRgister.Name = "btnRgister";
            this.btnRgister.Size = new System.Drawing.Size(222, 107);
            this.btnRgister.TabIndex = 0;
            this.btnRgister.Text = "Employee Registration";
            this.btnRgister.UseVisualStyleBackColor = false;
            this.btnRgister.Click += new System.EventHandler(this.BtnRgister_Click);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewEmp.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmp.ForeColor = System.Drawing.Color.White;
            this.btnViewEmp.Location = new System.Drawing.Point(225, 185);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(222, 107);
            this.btnViewEmp.TabIndex = 1;
            this.btnViewEmp.Text = "View Employee";
            this.btnViewEmp.UseVisualStyleBackColor = false;
            this.btnViewEmp.Click += new System.EventHandler(this.BtnViewEmp_Click);
            // 
            // EmployeeDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.btnRgister);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EmployeeDetailsUserControl";
            this.Size = new System.Drawing.Size(672, 337);
            this.Load += new System.EventHandler(this.EmployeeDetailsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnRgister;
        public System.Windows.Forms.Button btnViewEmp;
    }
}
