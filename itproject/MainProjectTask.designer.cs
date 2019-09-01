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
            this.SuspendLayout();
            // 
            // btnProjectMaintainer
            // 
            this.btnProjectMaintainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectMaintainer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProjectMaintainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjectMaintainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectMaintainer.ForeColor = System.Drawing.Color.White;
            this.btnProjectMaintainer.Location = new System.Drawing.Point(348, 203);
            this.btnProjectMaintainer.Name = "btnProjectMaintainer";
            this.btnProjectMaintainer.Size = new System.Drawing.Size(339, 98);
            this.btnProjectMaintainer.TabIndex = 0;
            this.btnProjectMaintainer.Text = "PROJECT MAINTAINER";
            this.btnProjectMaintainer.UseVisualStyleBackColor = false;
            this.btnProjectMaintainer.Click += new System.EventHandler(this.BtnADDPROJECTS_Click);
            // 
            // btnReportGenerator
            // 
            this.btnReportGenerator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportGenerator.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReportGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportGenerator.ForeColor = System.Drawing.Color.Black;
            this.btnReportGenerator.Location = new System.Drawing.Point(348, 350);
            this.btnReportGenerator.Name = "btnReportGenerator";
            this.btnReportGenerator.Size = new System.Drawing.Size(339, 98);
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
            this.Controls.Add(this.btnReportGenerator);
            this.Controls.Add(this.btnProjectMaintainer);
            this.Name = "MainProjectTask";
            this.Text = "MainProjectTask";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjectMaintainer;
        private System.Windows.Forms.Button btnReportGenerator;
    }
}