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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsReportsGenerater));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearchByAddedDate = new System.Windows.Forms.TextBox();
            this.dataGridViewForReports = new System.Windows.Forms.DataGridView();
            this.DOWNLOAD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForReports)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).BeginInit();
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
            this.txtBoxSearchByAddedDate.TextChanged += new System.EventHandler(this.TxtBoxSearchByAddedDate_TextChanged);
            // 
            // dataGridViewForReports
            // 
            this.dataGridViewForReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForReports.AutoGenerateColumns = false;
            this.dataGridViewForReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForReports.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewForReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn,
            this.deadlineDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.DOWNLOAD});
            this.dataGridViewForReports.DataSource = this.projectReportsBindingSource;
            this.dataGridViewForReports.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewForReports.Name = "dataGridViewForReports";
            this.dataGridViewForReports.RowHeadersWidth = 51;
            this.dataGridViewForReports.RowTemplate.Height = 24;
            this.dataGridViewForReports.Size = new System.Drawing.Size(931, 425);
            this.dataGridViewForReports.TabIndex = 3;
            this.dataGridViewForReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // DOWNLOAD
            // 
            this.DOWNLOAD.DataPropertyName = "Status";
            this.DOWNLOAD.HeaderText = "Reports";
            this.DOWNLOAD.MinimumWidth = 6;
            this.DOWNLOAD.Name = "DOWNLOAD";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewForReports, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(88, 152);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 431);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            // 
            // deadlineDateDataGridViewTextBoxColumn
            // 
            this.deadlineDateDataGridViewTextBoxColumn.DataPropertyName = "DeadlineDate";
            this.deadlineDateDataGridViewTextBoxColumn.HeaderText = "DeadlineDate";
            this.deadlineDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deadlineDateDataGridViewTextBoxColumn.Name = "deadlineDateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // projectReportsBindingSource
            // 
            this.projectReportsBindingSource.DataSource = typeof(itproject.ReportRelatedClasses.ProjectReports);
            // 
            // ProjectsReportsGenerater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 687);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectsReportsGenerater";
            this.Text = "ProjectsReportsGenerater";
            this.Load += new System.EventHandler(this.ProjectsReportsGenerater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForReports)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearchByAddedDate;
        private System.Windows.Forms.DataGridView dataGridViewForReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DOWNLOAD;
        private System.Windows.Forms.BindingSource projectReportsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}