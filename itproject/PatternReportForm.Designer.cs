namespace itproject
{
    partial class PatternReportForm
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
            this.PatternsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itproject_newDataSetPatternReport = new itproject.itproject_newDataSetPatternReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PatternsTableAdapter = new itproject.itproject_newDataSetPatternReportTableAdapters.PatternsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatternsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSetPatternReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatternsBindingSource
            // 
            this.PatternsBindingSource.DataMember = "Patterns";
            this.PatternsBindingSource.DataSource = this.itproject_newDataSetPatternReport;
            // 
            // itproject_newDataSetPatternReport
            // 
            this.itproject_newDataSetPatternReport.DataSetName = "itproject_newDataSetPatternReport";
            this.itproject_newDataSetPatternReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPatternReport";
            reportDataSource1.Value = this.PatternsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "itproject.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // PatternsTableAdapter
            // 
            this.PatternsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::itproject.Properties.Resources.angryimg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PatternReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatternReportForm";
            this.Text = "PatternReportForm";
            this.Load += new System.EventHandler(this.PatternReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatternsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itproject_newDataSetPatternReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PatternsBindingSource;
        private itproject_newDataSetPatternReport itproject_newDataSetPatternReport;
        private itproject_newDataSetPatternReportTableAdapters.PatternsTableAdapter PatternsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}