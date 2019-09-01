namespace itproject
{
    partial class orders
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
            this.odate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.oupdate = new System.Windows.Forms.Button();
            this.oadd = new System.Windows.Forms.Button();
            this.odelete = new System.Windows.Forms.Button();
            this.oclear = new System.Windows.Forms.Button();
            this.ogride = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.osearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogride)).BeginInit();
            this.SuspendLayout();
            // 
            // odate
            // 
            this.odate.Location = new System.Drawing.Point(141, 219);
            this.odate.Name = "odate";
            this.odate.Size = new System.Drawing.Size(207, 22);
            this.odate.TabIndex = 0;
            this.odate.ValueChanged += new System.EventHandler(this.Odate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1080, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(863, 160);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(207, 22);
            this.pid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Date";
            // 
            // qua
            // 
            this.qua.Location = new System.Drawing.Point(1167, 160);
            this.qua.Name = "qua";
            this.qua.Size = new System.Drawing.Size(207, 22);
            this.qua.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Number";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(495, 160);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(207, 22);
            this.cid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer ID";
            // 
            // oid
            // 
            this.oid.Location = new System.Drawing.Point(160, 160);
            this.oid.Name = "oid";
            this.oid.ReadOnly = true;
            this.oid.Size = new System.Drawing.Size(207, 22);
            this.oid.TabIndex = 10;
            this.oid.TextChanged += new System.EventHandler(this.Oid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pattern Number";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expected Date";
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(638, 221);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(207, 22);
            this.edate.TabIndex = 12;
            // 
            // oupdate
            // 
            this.oupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oupdate.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oupdate.Location = new System.Drawing.Point(1187, 207);
            this.oupdate.Name = "oupdate";
            this.oupdate.Size = new System.Drawing.Size(170, 50);
            this.oupdate.TabIndex = 13;
            this.oupdate.Text = "Update";
            this.oupdate.UseVisualStyleBackColor = true;
            this.oupdate.Click += new System.EventHandler(this.Oupdate_Click);
            // 
            // oadd
            // 
            this.oadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oadd.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oadd.Location = new System.Drawing.Point(981, 656);
            this.oadd.Name = "oadd";
            this.oadd.Size = new System.Drawing.Size(170, 50);
            this.oadd.TabIndex = 14;
            this.oadd.Text = "Add";
            this.oadd.UseVisualStyleBackColor = true;
            this.oadd.Click += new System.EventHandler(this.Oadd_Click);
            // 
            // odelete
            // 
            this.odelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.odelete.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odelete.Location = new System.Drawing.Point(1187, 656);
            this.odelete.Name = "odelete";
            this.odelete.Size = new System.Drawing.Size(170, 50);
            this.odelete.TabIndex = 15;
            this.odelete.Text = "Delete";
            this.odelete.UseVisualStyleBackColor = true;
            this.odelete.Click += new System.EventHandler(this.Odelete_Click);
            // 
            // oclear
            // 
            this.oclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oclear.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oclear.Location = new System.Drawing.Point(981, 205);
            this.oclear.Name = "oclear";
            this.oclear.Size = new System.Drawing.Size(170, 50);
            this.oclear.TabIndex = 16;
            this.oclear.Text = "Clear";
            this.oclear.UseVisualStyleBackColor = true;
            this.oclear.Click += new System.EventHandler(this.Oclear_Click);
            // 
            // ogride
            // 
            this.ogride.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogride.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogride.Location = new System.Drawing.Point(12, 275);
            this.ogride.Name = "ogride";
            this.ogride.RowHeadersWidth = 51;
            this.ogride.RowTemplate.Height = 24;
            this.ogride.Size = new System.Drawing.Size(1362, 363);
            this.ogride.TabIndex = 17;
            this.ogride.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ogride_CellContentClick);
            this.ogride.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Ogride_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 44);
            this.label7.TabIndex = 18;
            this.label7.Text = "Order Placement";
            // 
            // osearch
            // 
            this.osearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.osearch.Location = new System.Drawing.Point(991, 81);
            this.osearch.Name = "osearch";
            this.osearch.Size = new System.Drawing.Size(349, 22);
            this.osearch.TabIndex = 20;
            this.osearch.TextChanged += new System.EventHandler(this.Osearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(859, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 718);
            this.Controls.Add(this.osearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ogride);
            this.Controls.Add(this.oclear);
            this.Controls.Add(this.odelete);
            this.Controls.Add(this.oadd);
            this.Controls.Add(this.oupdate);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odate);
            this.MinimumSize = new System.Drawing.Size(1400, 760);
            this.Name = "orders";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogride)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker odate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker edate;
        private System.Windows.Forms.Button oupdate;
        private System.Windows.Forms.Button oadd;
        private System.Windows.Forms.Button odelete;
        private System.Windows.Forms.Button oclear;
        private System.Windows.Forms.DataGridView ogride;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox osearch;
        private System.Windows.Forms.Label label8;
    }
}