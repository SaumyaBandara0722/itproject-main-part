using System;

namespace itproject
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.labelstockaddeddate = new System.Windows.Forms.Label();
            this.textstockpatternid = new System.Windows.Forms.TextBox();
            this.textstockpatternname = new System.Windows.Forms.TextBox();
            this.labelstockavailablequantity = new System.Windows.Forms.Label();
            this.textstockaddedquantity = new System.Windows.Forms.TextBox();
            this.labelstockid = new System.Windows.Forms.Label();
            this.labelstockaddedquantity = new System.Windows.Forms.Label();
            this.textstockavailablequantity = new System.Windows.Forms.TextBox();
            this.labelstockpatternname = new System.Windows.Forms.Label();
            this.textstocksearch = new System.Windows.Forms.TextBox();
            this.datagridviewstock = new System.Windows.Forms.DataGridView();
            this.buttonstockclear = new System.Windows.Forms.Button();
            this.buttonstockupdate = new System.Windows.Forms.Button();
            this.buttonstockdelete = new System.Windows.Forms.Button();
            this.buttonstockadd1 = new System.Windows.Forms.Button();
            this.buttonpattern2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelstocksearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.pictureboxstockclose = new System.Windows.Forms.PictureBox();
            this.btnmaximize = new System.Windows.Forms.PictureBox();
            this.dateTimestockaddeddate = new System.Windows.Forms.DateTimePicker();
            this.txtsnumber = new System.Windows.Forms.TextBox();
            this.labelSNo = new System.Windows.Forms.Label();
            this.labelstock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.buttonStockASPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewstock)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxstockclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelstockaddeddate
            // 
            this.labelstockaddeddate.AutoSize = true;
            this.labelstockaddeddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockaddeddate.ForeColor = System.Drawing.Color.White;
            this.labelstockaddeddate.Location = new System.Drawing.Point(29, 335);
            this.labelstockaddeddate.Name = "labelstockaddeddate";
            this.labelstockaddeddate.Size = new System.Drawing.Size(140, 29);
            this.labelstockaddeddate.TabIndex = 114;
            this.labelstockaddeddate.Text = "Added Date";
            // 
            // textstockpatternid
            // 
            this.textstockpatternid.BackColor = System.Drawing.Color.White;
            this.textstockpatternid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstockpatternid.Location = new System.Drawing.Point(296, 89);
            this.textstockpatternid.Name = "textstockpatternid";
            this.textstockpatternid.Size = new System.Drawing.Size(299, 32);
            this.textstockpatternid.TabIndex = 111;
            this.textstockpatternid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textstockpatternid_KeyPress);
            // 
            // textstockpatternname
            // 
            this.textstockpatternname.BackColor = System.Drawing.Color.White;
            this.textstockpatternname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstockpatternname.Location = new System.Drawing.Point(296, 148);
            this.textstockpatternname.Name = "textstockpatternname";
            this.textstockpatternname.Size = new System.Drawing.Size(299, 32);
            this.textstockpatternname.TabIndex = 110;
            this.textstockpatternname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textstockpatternname_KeyPress);
            // 
            // labelstockavailablequantity
            // 
            this.labelstockavailablequantity.AutoSize = true;
            this.labelstockavailablequantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockavailablequantity.ForeColor = System.Drawing.Color.White;
            this.labelstockavailablequantity.Location = new System.Drawing.Point(29, 273);
            this.labelstockavailablequantity.Name = "labelstockavailablequantity";
            this.labelstockavailablequantity.Size = new System.Drawing.Size(204, 29);
            this.labelstockavailablequantity.TabIndex = 109;
            this.labelstockavailablequantity.Text = "Available Quantity";
            // 
            // textstockaddedquantity
            // 
            this.textstockaddedquantity.BackColor = System.Drawing.Color.White;
            this.textstockaddedquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstockaddedquantity.Location = new System.Drawing.Point(296, 211);
            this.textstockaddedquantity.Name = "textstockaddedquantity";
            this.textstockaddedquantity.Size = new System.Drawing.Size(299, 32);
            this.textstockaddedquantity.TabIndex = 108;
            this.textstockaddedquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textstockaddedquantity_KeyPress);
            // 
            // labelstockid
            // 
            this.labelstockid.AutoSize = true;
            this.labelstockid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockid.ForeColor = System.Drawing.Color.White;
            this.labelstockid.Location = new System.Drawing.Point(29, 85);
            this.labelstockid.Name = "labelstockid";
            this.labelstockid.Size = new System.Drawing.Size(118, 29);
            this.labelstockid.TabIndex = 107;
            this.labelstockid.Text = "Pattern ID";
            // 
            // labelstockaddedquantity
            // 
            this.labelstockaddedquantity.AutoSize = true;
            this.labelstockaddedquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockaddedquantity.ForeColor = System.Drawing.Color.White;
            this.labelstockaddedquantity.Location = new System.Drawing.Point(29, 214);
            this.labelstockaddedquantity.Name = "labelstockaddedquantity";
            this.labelstockaddedquantity.Size = new System.Drawing.Size(177, 29);
            this.labelstockaddedquantity.TabIndex = 106;
            this.labelstockaddedquantity.Text = "Added Quantity";
            // 
            // textstockavailablequantity
            // 
            this.textstockavailablequantity.BackColor = System.Drawing.Color.White;
            this.textstockavailablequantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstockavailablequantity.Location = new System.Drawing.Point(296, 269);
            this.textstockavailablequantity.Name = "textstockavailablequantity";
            this.textstockavailablequantity.Size = new System.Drawing.Size(299, 32);
            this.textstockavailablequantity.TabIndex = 105;
            this.textstockavailablequantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textstockavailablequantity_KeyPress);
            // 
            // labelstockpatternname
            // 
            this.labelstockpatternname.AutoSize = true;
            this.labelstockpatternname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockpatternname.ForeColor = System.Drawing.Color.White;
            this.labelstockpatternname.Location = new System.Drawing.Point(29, 151);
            this.labelstockpatternname.Name = "labelstockpatternname";
            this.labelstockpatternname.Size = new System.Drawing.Size(160, 29);
            this.labelstockpatternname.TabIndex = 104;
            this.labelstockpatternname.Text = "Pattern Name";
            // 
            // textstocksearch
            // 
            this.textstocksearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textstocksearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstocksearch.Location = new System.Drawing.Point(1170, 200);
            this.textstocksearch.Name = "textstocksearch";
            this.textstocksearch.Size = new System.Drawing.Size(360, 30);
            this.textstocksearch.TabIndex = 103;
            this.textstocksearch.TextChanged += new System.EventHandler(this.Textstocksearch_TextChanged);
            // 
            // datagridviewstock
            // 
            this.datagridviewstock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridviewstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewstock.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewstock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewstock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewstock.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridviewstock.GridColor = System.Drawing.Color.White;
            this.datagridviewstock.Location = new System.Drawing.Point(878, 284);
            this.datagridviewstock.Name = "datagridviewstock";
            this.datagridviewstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewstock.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridviewstock.RowHeadersWidth = 21;
            this.datagridviewstock.RowTemplate.Height = 24;
            this.datagridviewstock.Size = new System.Drawing.Size(786, 522);
            this.datagridviewstock.TabIndex = 102;
            this.datagridviewstock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridviewstock_CellContentClick);
            this.datagridviewstock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Datagridviewstock_RowHeaderMouseClick);
            // 
            // buttonstockclear
            // 
            this.buttonstockclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(117)))));
            this.buttonstockclear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstockclear.ForeColor = System.Drawing.Color.White;
            this.buttonstockclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonstockclear.Location = new System.Drawing.Point(94, 9);
            this.buttonstockclear.Name = "buttonstockclear";
            this.buttonstockclear.Size = new System.Drawing.Size(139, 63);
            this.buttonstockclear.TabIndex = 101;
            this.buttonstockclear.Text = "Clear";
            this.buttonstockclear.UseVisualStyleBackColor = false;
            this.buttonstockclear.Click += new System.EventHandler(this.Buttonstockclear_Click);
            // 
            // buttonstockupdate
            // 
            this.buttonstockupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(117)))));
            this.buttonstockupdate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstockupdate.ForeColor = System.Drawing.Color.White;
            this.buttonstockupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonstockupdate.Location = new System.Drawing.Point(94, 8);
            this.buttonstockupdate.Name = "buttonstockupdate";
            this.buttonstockupdate.Size = new System.Drawing.Size(153, 63);
            this.buttonstockupdate.TabIndex = 100;
            this.buttonstockupdate.Text = "Update";
            this.buttonstockupdate.UseVisualStyleBackColor = false;
            this.buttonstockupdate.Click += new System.EventHandler(this.Buttonstockupdate_Click);
            // 
            // buttonstockdelete
            // 
            this.buttonstockdelete.BackColor = System.Drawing.Color.Red;
            this.buttonstockdelete.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstockdelete.ForeColor = System.Drawing.Color.White;
            this.buttonstockdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonstockdelete.Location = new System.Drawing.Point(94, 8);
            this.buttonstockdelete.Name = "buttonstockdelete";
            this.buttonstockdelete.Size = new System.Drawing.Size(139, 63);
            this.buttonstockdelete.TabIndex = 99;
            this.buttonstockdelete.Text = "Delete";
            this.buttonstockdelete.UseVisualStyleBackColor = false;
            this.buttonstockdelete.Click += new System.EventHandler(this.Buttonstockdelete_Click);
            // 
            // buttonstockadd1
            // 
            this.buttonstockadd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(117)))));
            this.buttonstockadd1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstockadd1.ForeColor = System.Drawing.Color.White;
            this.buttonstockadd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonstockadd1.Location = new System.Drawing.Point(94, 10);
            this.buttonstockadd1.Name = "buttonstockadd1";
            this.buttonstockadd1.Size = new System.Drawing.Size(153, 62);
            this.buttonstockadd1.TabIndex = 98;
            this.buttonstockadd1.Text = "Add";
            this.buttonstockadd1.UseVisualStyleBackColor = false;
            this.buttonstockadd1.Click += new System.EventHandler(this.Buttonstockadd1_Click);
            // 
            // buttonpattern2
            // 
            this.buttonpattern2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.buttonpattern2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpattern2.ForeColor = System.Drawing.Color.Black;
            this.buttonpattern2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonpattern2.Location = new System.Drawing.Point(111, 9);
            this.buttonpattern2.Name = "buttonpattern2";
            this.buttonpattern2.Size = new System.Drawing.Size(180, 79);
            this.buttonpattern2.TabIndex = 97;
            this.buttonpattern2.Text = "Patterns";
            this.buttonpattern2.UseVisualStyleBackColor = false;
            this.buttonpattern2.Click += new System.EventHandler(this.Buttonpattern2_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.buttonstockdelete);
            this.panel5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(488, 775);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 88);
            this.panel5.TabIndex = 173;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.buttonstockclear);
            this.panel4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(488, 666);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 103);
            this.panel4.TabIndex = 176;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.buttonstockupdate);
            this.panel3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(168, 775);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 81);
            this.panel3.TabIndex = 175;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.buttonstockadd1);
            this.panel6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(168, 666);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 75);
            this.panel6.TabIndex = 174;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.labelstocksearch);
            this.panel7.Location = new System.Drawing.Point(906, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 97);
            this.panel7.TabIndex = 177;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(31, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // labelstocksearch
            // 
            this.labelstocksearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelstocksearch.AutoSize = true;
            this.labelstocksearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelstocksearch.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstocksearch.ForeColor = System.Drawing.Color.White;
            this.labelstocksearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelstocksearch.Location = new System.Drawing.Point(91, 17);
            this.labelstocksearch.Name = "labelstocksearch";
            this.labelstocksearch.Size = new System.Drawing.Size(109, 50);
            this.labelstocksearch.TabIndex = 112;
            this.labelstocksearch.Text = "Search";
            this.labelstocksearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelstocksearch.Click += new System.EventHandler(this.Labelstocksearch_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.buttonpattern2);
            this.panel2.Location = new System.Drawing.Point(1006, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 99);
            this.panel2.TabIndex = 178;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnminimize);
            this.panel1.Controls.Add(this.pictureboxstockclose);
            this.panel1.Controls.Add(this.btnmaximize);
            this.panel1.Location = new System.Drawing.Point(1476, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 106);
            this.panel1.TabIndex = 179;
            // 
            // btnminimize
            // 
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(34, 18);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(53, 44);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimize.TabIndex = 128;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.Btnminimize_Click);
            // 
            // pictureboxstockclose
            // 
            this.pictureboxstockclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxstockclose.Image")));
            this.pictureboxstockclose.Location = new System.Drawing.Point(154, 18);
            this.pictureboxstockclose.Name = "pictureboxstockclose";
            this.pictureboxstockclose.Size = new System.Drawing.Size(50, 44);
            this.pictureboxstockclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxstockclose.TabIndex = 115;
            this.pictureboxstockclose.TabStop = false;
            this.pictureboxstockclose.Click += new System.EventHandler(this.Pictureboxstockclose_Click_1);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximize.Image")));
            this.btnmaximize.Location = new System.Drawing.Point(93, 18);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(55, 44);
            this.btnmaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximize.TabIndex = 129;
            this.btnmaximize.TabStop = false;
            this.btnmaximize.Click += new System.EventHandler(this.Btnmaximize_Click);
            // 
            // dateTimestockaddeddate
            // 
            this.dateTimestockaddeddate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimestockaddeddate.CustomFormat = "yyyy - MM - dd";
            this.dateTimestockaddeddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimestockaddeddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimestockaddeddate.Location = new System.Drawing.Point(296, 339);
            this.dateTimestockaddeddate.Name = "dateTimestockaddeddate";
            this.dateTimestockaddeddate.Size = new System.Drawing.Size(299, 32);
            this.dateTimestockaddeddate.TabIndex = 177;
            // 
            // txtsnumber
            // 
            this.txtsnumber.BackColor = System.Drawing.Color.White;
            this.txtsnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsnumber.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtsnumber.Location = new System.Drawing.Point(296, 24);
            this.txtsnumber.Name = "txtsnumber";
            this.txtsnumber.ReadOnly = true;
            this.txtsnumber.Size = new System.Drawing.Size(299, 32);
            this.txtsnumber.TabIndex = 182;
            // 
            // labelSNo
            // 
            this.labelSNo.AutoSize = true;
            this.labelSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSNo.ForeColor = System.Drawing.Color.White;
            this.labelSNo.Location = new System.Drawing.Point(29, 20);
            this.labelSNo.Name = "labelSNo";
            this.labelSNo.Size = new System.Drawing.Size(100, 29);
            this.labelSNo.TabIndex = 181;
            this.labelSNo.Text = "Number";
            // 
            // labelstock
            // 
            this.labelstock.AutoSize = true;
            this.labelstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstock.ForeColor = System.Drawing.Color.White;
            this.labelstock.Location = new System.Drawing.Point(152, 17);
            this.labelstock.Name = "labelstock";
            this.labelstock.Size = new System.Drawing.Size(423, 135);
            this.labelstock.TabIndex = 96;
            this.labelstock.Text = "Stocks";
            this.labelstock.Click += new System.EventHandler(this.Labelstock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(601, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 38);
            this.label3.TabIndex = 191;
            this.label3.Text = "**";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(601, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 38);
            this.label2.TabIndex = 190;
            this.label2.Text = "**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(601, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 38);
            this.label1.TabIndex = 189;
            this.label1.Text = "**";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(601, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 38);
            this.label4.TabIndex = 194;
            this.label4.Text = "**";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.txtsnumber);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.labelstockpatternname);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.textstockavailablequantity);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.labelstockaddedquantity);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.labelstockid);
            this.panel8.Controls.Add(this.textstockaddedquantity);
            this.panel8.Controls.Add(this.labelSNo);
            this.panel8.Controls.Add(this.labelstockavailablequantity);
            this.panel8.Controls.Add(this.dateTimestockaddeddate);
            this.panel8.Controls.Add(this.textstockpatternname);
            this.panel8.Controls.Add(this.textstockpatternid);
            this.panel8.Controls.Add(this.labelstockaddeddate);
            this.panel8.Location = new System.Drawing.Point(93, 222);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(732, 427);
            this.panel8.TabIndex = 195;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(718, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 99);
            this.button1.TabIndex = 196;
            this.button1.Text = "Export as a Excel Sheet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // buttonStockASPDF
            // 
            this.buttonStockASPDF.Location = new System.Drawing.Point(557, 99);
            this.buttonStockASPDF.Name = "buttonStockASPDF";
            this.buttonStockASPDF.Size = new System.Drawing.Size(130, 61);
            this.buttonStockASPDF.TabIndex = 197;
            this.buttonStockASPDF.Text = "Export as a PDF";
            this.buttonStockASPDF.UseVisualStyleBackColor = true;
            this.buttonStockASPDF.Click += new System.EventHandler(this.ButtonStockASPDF_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1724, 868);
            this.Controls.Add(this.buttonStockASPDF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textstocksearch);
            this.Controls.Add(this.datagridviewstock);
            this.Controls.Add(this.labelstock);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewstock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxstockclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.Label labelstockaddeddate;
        private System.Windows.Forms.TextBox textstockpatternid;
        private System.Windows.Forms.TextBox textstockpatternname;
        private System.Windows.Forms.Label labelstockavailablequantity;
        private System.Windows.Forms.TextBox textstockaddedquantity;
        private System.Windows.Forms.Label labelstockid;
        private System.Windows.Forms.Label labelstockaddedquantity;
        private System.Windows.Forms.TextBox textstockavailablequantity;
        private System.Windows.Forms.Label labelstockpatternname;
        private System.Windows.Forms.TextBox textstocksearch;
        private System.Windows.Forms.DataGridView datagridviewstock;
        private System.Windows.Forms.Button buttonstockclear;
        private System.Windows.Forms.Button buttonstockupdate;
        private System.Windows.Forms.Button buttonstockdelete;
        private System.Windows.Forms.Button buttonstockadd1;
        private System.Windows.Forms.Button buttonpattern2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelstocksearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnmaximize;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox pictureboxstockclose;
        private System.Windows.Forms.DateTimePicker dateTimestockaddeddate;
        private System.Windows.Forms.TextBox txtsnumber;
        private System.Windows.Forms.Label labelSNo;
        private System.Windows.Forms.Label labelstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button buttonStockASPDF;
    }
}