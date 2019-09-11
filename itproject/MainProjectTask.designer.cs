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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportGenerator = new System.Windows.Forms.Button();
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
            this.btnProjectMaintainer.Location = new System.Drawing.Point(3, 3);
            this.btnProjectMaintainer.Name = "btnProjectMaintainer";
            this.btnProjectMaintainer.Size = new System.Drawing.Size(405, 107);
            this.btnProjectMaintainer.TabIndex = 0;
            this.btnProjectMaintainer.Text = "PROJECT MAINTAINER";
            this.btnProjectMaintainer.UseVisualStyleBackColor = false;
            this.btnProjectMaintainer.Click += new System.EventHandler(this.BtnADDPROJECTS_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnProjectMaintainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReportGenerator, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 203);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 226);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnReportGenerator
            // 
            this.btnReportGenerator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportGenerator.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReportGenerator.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnReportGenerator.Location = new System.Drawing.Point(3, 116);
            this.btnReportGenerator.Name = "btnReportGenerator";
            this.btnReportGenerator.Size = new System.Drawing.Size(405, 107);
            this.btnReportGenerator.TabIndex = 1;
            this.btnReportGenerator.Text = "REPORT GENERATOR";
            this.btnReportGenerator.UseVisualStyleBackColor = false;
            this.btnReportGenerator.Click += new System.EventHandler(this.Button2_Click);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReportGenerator;
    }
}