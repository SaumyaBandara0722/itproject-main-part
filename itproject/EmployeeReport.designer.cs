namespace itproject
{
    partial class EmployeeReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReport));
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itproject_newDataSet4 = new itproject.itproject_newDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.EmployeesTableAdapter = new itproject.itproject_newDataSet4TableAdapters.EmployeesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.itproject_newDataSet4;
            // 
            // itproject_newDataSet4
            // 
            this.itproject_newDataSet4.DataSetName = "itproject_newDataSet4";
            this.itproject_newDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSetEmployee";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "itproject.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(122, 184);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(812, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(205, 3);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(394, 22);
            this.textBoxDepartment.TabIndex = 1;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.MistyRose;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReport.Location = new System.Drawing.Point(605, 3);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(204, 37);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Generate";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Field";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::itproject.Properties.Resources.angryimg;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.38424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.73892F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReport, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDepartment, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(122, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 43);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::itproject.Properties.Resources.angryimg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EmployeeReport";
            this.Text = "EmployeeReport";
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private itproject_newDataSet4 itproject_newDataSet4;
        private itproject_newDataSet4TableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}