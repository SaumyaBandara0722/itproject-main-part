namespace itproject
{
    partial class LoanUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanUserControl));
            this.loansTableAdapter = new itproject.itprojectDataSetTableAdapters.LoansTableAdapter();
            this.itprojectDataSet = new itproject.itprojectDataSet();
            this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxInstallment = new System.Windows.Forms.TextBox();
            this.labelInstallment = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
            // 
            // itprojectDataSet
            // 
            this.itprojectDataSet.DataSetName = "itprojectDataSet";
            this.itprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loansBindingSource
            // 
            this.loansBindingSource.DataMember = "Loans";
            this.loansBindingSource.DataSource = this.itprojectDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Process the Loan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxInstallment
            // 
            this.textBoxInstallment.Location = new System.Drawing.Point(303, 255);
            this.textBoxInstallment.Name = "textBoxInstallment";
            this.textBoxInstallment.Size = new System.Drawing.Size(228, 22);
            this.textBoxInstallment.TabIndex = 10;
            // 
            // labelInstallment
            // 
            this.labelInstallment.AutoSize = true;
            this.labelInstallment.Location = new System.Drawing.Point(62, 255);
            this.labelInstallment.Name = "labelInstallment";
            this.labelInstallment.Size = new System.Drawing.Size(75, 17);
            this.labelInstallment.TabIndex = 9;
            this.labelInstallment.Text = "Installment";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(303, 199);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(303, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Loans";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Give a Loan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxInstallment);
            this.groupBox1.Controls.Add(this.labelInstallment);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labelEndDate);
            this.groupBox1.Controls.Add(this.labelStartDate);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.labelAmount);
            this.groupBox1.Controls.Add(this.textBoxEmployeeID);
            this.groupBox1.Controls.Add(this.labelEmployeeID);
            this.groupBox1.Location = new System.Drawing.Point(90, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply Loan";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(62, 204);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(67, 17);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "End Date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(62, 148);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(72, 17);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "Start Date";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(303, 98);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(228, 22);
            this.textBoxAmount.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(62, 98);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(303, 42);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(228, 22);
            this.textBoxEmployeeID.TabIndex = 1;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(62, 42);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 235);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 496);
            this.tabControl1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Processing the Loan";
            // 
            // LoanUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoanUserControl";
            this.Size = new System.Drawing.Size(1217, 747);
            ((System.ComponentModel.ISupportInitialize)(this.itprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private itprojectDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
        private itprojectDataSet itprojectDataSet;
        private System.Windows.Forms.BindingSource loansBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxInstallment;
        private System.Windows.Forms.Label labelInstallment;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
