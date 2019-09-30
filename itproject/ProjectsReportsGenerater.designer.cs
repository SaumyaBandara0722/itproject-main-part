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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearchByAddedDate = new System.Windows.Forms.TextBox();
            this.projectReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Projects_TasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itproject_newDataSet1 = new itproject.itproject_newDataSet1();
            this.Projects_TasksTableAdapter = new itproject.itproject_newDataSet1TableAdapters.Projects_TasksTableAdapter();
            this.buttonGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_TasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(255, 29);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search By Added Date";
            // 
            // txtBoxSearchByAddedDate
            // 
            this.txtBoxSearchByAddedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchByAddedDate.Location = new System.Drawing.Point(293, 3);
            this.txtBoxSearchByAddedDate.Name = "txtBoxSearchByAddedDate";
            this.txtBoxSearchByAddedDate.Size = new System.Drawing.Size(641, 28);
            this.txtBoxSearchByAddedDate.TabIndex = 2;
            // 
            // projectReportsBindingSource
            // 
            this.projectReportsBindingSource.DataSource = typeof(itproject.ReportRelatedClasses.ProjectReports);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.94984F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.05016F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSearchByAddedDate, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(88, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(659, 33);
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
            this.reportViewer1.Size = new System.Drawing.Size(940, 463);
            this.reportViewer1.TabIndex = 7;
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
            // Projects_TasksTableAdapter
            // 
            this.Projects_TasksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(564, 120);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(192, 30);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // ProjectsReportsGenerater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 687);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectsReportsGenerater";
            this.Text = "ProjectsReportsGenerater";
            this.Load += new System.EventHandler(this.ProjectsReportsGenerater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_TasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearchByAddedDate;
        private System.Windows.Forms.BindingSource projectReportsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Projects_TasksBindingSource;
        private itproject_newDataSet1 itproject_newDataSet1;
        private itproject_newDataSet1TableAdapters.Projects_TasksTableAdapter Projects_TasksTableAdapter;
        private System.Windows.Forms.Button buttonGenerate;
    }
}