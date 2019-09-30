namespace itproject
{
    partial class MainProjectTask
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
            this.btnProjectMaintainer = new System.Windows.Forms.Button();
            this.btnReportGenerator = new System.Windows.Forms.Button();
            this.btnViewProjects = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProjectMaintainer
            // 
            this.btnProjectMaintainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProjectMaintainer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProjectMaintainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjectMaintainer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectMaintainer.ForeColor = System.Drawing.Color.White;
            this.btnProjectMaintainer.Location = new System.Drawing.Point(3, 13);
            this.btnProjectMaintainer.Name = "btnProjectMaintainer";
            this.btnProjectMaintainer.Size = new System.Drawing.Size(194, 107);
            this.btnProjectMaintainer.TabIndex = 0;
            this.btnProjectMaintainer.Text = "PROJECT MAINTAINER";
            this.btnProjectMaintainer.UseVisualStyleBackColor = false;
            this.btnProjectMaintainer.Click += new System.EventHandler(this.BtnADDPROJECTS_Click);
            // 
            // btnReportGenerator
            // 
            this.btnReportGenerator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportGenerator.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReportGenerator.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnReportGenerator.Location = new System.Drawing.Point(3, 280);
            this.btnReportGenerator.Name = "btnReportGenerator";
            this.btnReportGenerator.Size = new System.Drawing.Size(194, 107);
            this.btnReportGenerator.TabIndex = 1;
            this.btnReportGenerator.Text = "REPORT GENERATOR";
            this.btnReportGenerator.UseVisualStyleBackColor = false;
            this.btnReportGenerator.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnViewProjects
            // 
            this.btnViewProjects.BackColor = System.Drawing.Color.YellowGreen;
            this.btnViewProjects.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProjects.Location = new System.Drawing.Point(3, 137);
            this.btnViewProjects.Name = "btnViewProjects";
            this.btnViewProjects.Size = new System.Drawing.Size(194, 107);
            this.btnViewProjects.TabIndex = 2;
            this.btnViewProjects.Text = "View Projects";
            this.btnViewProjects.UseVisualStyleBackColor = false;
            this.btnViewProjects.Click += new System.EventHandler(this.btnViewProjects_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnProjectMaintainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReportGenerator, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnViewProjects, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(411, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 399);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainProjectTask";
            this.Text = "MainProjectTask";
            this.Load += new System.EventHandler(this.MainProjectTask_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjectMaintainer;
        private System.Windows.Forms.Button btnReportGenerator;
        private System.Windows.Forms.Button btnViewProjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}