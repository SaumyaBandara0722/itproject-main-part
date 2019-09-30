namespace itproject
{
    partial class PayRollReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.itproject_newDataSetPayRoll = new itproject.itproject_newDataSetPayRoll();
            this.PayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PayrollTableAdapter = new itproject.itproject_newDataSetPayRollTableAdapters.PayrollTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSetPayRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPayRoll";
            reportDataSource1.Value = this.PayrollBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "itproject.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(733, 326);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // itproject_newDataSetPayRoll
            // 
            this.itproject_newDataSetPayRoll.DataSetName = "itproject_newDataSetPayRoll";
            this.itproject_newDataSetPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PayrollBindingSource
            // 
            this.PayrollBindingSource.DataMember = "Payroll";
            this.PayrollBindingSource.DataSource = this.itproject_newDataSetPayRoll;
            // 
            // PayrollTableAdapter
            // 
            this.PayrollTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(466, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // PayRollReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayRollReportForm";
            this.Text = "PayRollReportForm";
            this.Load += new System.EventHandler(this.PayRollReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSetPayRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PayrollBindingSource;
        private itproject_newDataSetPayRoll itproject_newDataSetPayRoll;
        private itproject_newDataSetPayRollTableAdapters.PayrollTableAdapter PayrollTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerate;
    }
}