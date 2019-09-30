namespace itproject
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblSelectedEmp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(252, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(216, 142);
            this.dgvEmployeeList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.Size = new System.Drawing.Size(631, 326);
            this.dgvEmployeeList.TabIndex = 7;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeeList_CellContentClick);
            this.dgvEmployeeList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployeeList_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(227, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(4, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(215, 34);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search Employee";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(246, 4);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(67, 22);
            this.txtId.TabIndex = 10;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // lblSelectedEmp
            // 
            this.lblSelectedEmp.AutoSize = true;
            this.lblSelectedEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedEmp.Location = new System.Drawing.Point(4, 0);
            this.lblSelectedEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedEmp.Name = "lblSelectedEmp";
            this.lblSelectedEmp.Size = new System.Drawing.Size(234, 36);
            this.lblSelectedEmp.TabIndex = 11;
            this.lblSelectedEmp.Text = "Selected Employee Id";
            this.lblSelectedEmp.Click += new System.EventHandler(this.LblSelectedEmp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "UPDATE SELECTED EMPLOYEE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.30655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.50529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.950673F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(216, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 34);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.65199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.34802F));
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedEmp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(216, 498);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 36);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.57447F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.27433F));
            this.tableLayoutPanel3.Controls.Add(this.btnPdf, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(216, 534);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(627, 57);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Location = new System.Drawing.Point(421, 4);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(177, 46);
            this.btnPdf.TabIndex = 16;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvEmployeeList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblSelectedEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPdf;
    }
}