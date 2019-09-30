namespace itproject
{
    partial class ProjectsReportsGenerater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsReportsGenerater));
            this.Projects_TasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itproject_newDataSet1 = new itproject.itproject_newDataSet1();
            this.projectReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Projects_TasksTableAdapter = new itproject.itproject_newDataSet1TableAdapters.Projects_TasksTableAdapter();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_TasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Projects_TasksBindingSource
            // 
            this.Projects_TasksBindingSource.DataMember = "Projects_Tasks";
            this.Projects_TasksBindingSource.DataSource = this.itproject_newDataSet1;
            // 
            // itproject_newDataSet1
            // 
            this.itproject_newDataSet1.DataSetName = "itproject_newDataSet1";
            this.itproject_newDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectReportsBindingSource
            // 
            this.projectReportsBindingSource.DataSource = typeof(itproject.ReportRelatedClasses.ProjectReports);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(189, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ProjectTaskDataSet";
            reportDataSource1.Value = this.Projects_TasksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "itproject.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(82, 175);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1025, 463);
            this.reportViewer1.TabIndex = 7;
            // 
            // Projects_TasksTableAdapter
            // 
            this.Projects_TasksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(915, 99);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(192, 30);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "From";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "To";
            // 
            // ProjectsReportsGenerater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 687);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ProjectsReportsGenerater";
            this.Text = "ProjectsReportsGenerater";
            this.Load += new System.EventHandler(this.ProjectsReportsGenerater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Projects_TasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource projectReportsBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Projects_TasksBindingSource;
        private itproject_newDataSet1 itproject_newDataSet1;
        private itproject_newDataSet1TableAdapters.Projects_TasksTableAdapter Projects_TasksTableAdapter;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}