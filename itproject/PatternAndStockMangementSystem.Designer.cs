﻿namespace itproject
{
    partial class PatternAndStockMangementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternAndStockMangementSystem));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonstock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonpattern = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnmaximize = new System.Windows.Forms.PictureBox();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.pictureboxpatternclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpatternclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.buttonstock);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(485, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 304);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(97, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // buttonstock
            // 
            this.buttonstock.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstock.ForeColor = System.Drawing.Color.White;
            this.buttonstock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonstock.Location = new System.Drawing.Point(10, 178);
            this.buttonstock.Name = "buttonstock";
            this.buttonstock.Size = new System.Drawing.Size(331, 100);
            this.buttonstock.TabIndex = 0;
            this.buttonstock.Text = "Stocks";
            this.buttonstock.UseVisualStyleBackColor = false;
            this.buttonstock.Click += new System.EventHandler(this.Buttonstock_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.buttonpattern);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(67, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 304);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonpattern
            // 
            this.buttonpattern.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonpattern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonpattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpattern.ForeColor = System.Drawing.Color.White;
            this.buttonpattern.Location = new System.Drawing.Point(10, 178);
            this.buttonpattern.Name = "buttonpattern";
            this.buttonpattern.Size = new System.Drawing.Size(338, 93);
            this.buttonpattern.TabIndex = 1;
            this.buttonpattern.Text = "Patterns";
            this.buttonpattern.UseVisualStyleBackColor = false;
            this.buttonpattern.Click += new System.EventHandler(this.Buttonpattern_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnmaximize);
            this.panel5.Controls.Add(this.btnminimize);
            this.panel5.Controls.Add(this.pictureboxpatternclose);
            this.panel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(758, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 98);
            this.panel5.TabIndex = 176;
            // 
            // btnmaximize
            // 
            this.btnmaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximize.Image")));
            this.btnmaximize.Location = new System.Drawing.Point(70, 23);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(55, 51);
            this.btnmaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximize.TabIndex = 129;
            this.btnmaximize.TabStop = false;
            this.btnmaximize.Click += new System.EventHandler(this.Btnmaximize_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(14, 23);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(50, 51);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimize.TabIndex = 128;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.Btnminimize_Click);
            // 
            // pictureboxpatternclose
            // 
            this.pictureboxpatternclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxpatternclose.Image")));
            this.pictureboxpatternclose.Location = new System.Drawing.Point(131, 23);
            this.pictureboxpatternclose.Name = "pictureboxpatternclose";
            this.pictureboxpatternclose.Size = new System.Drawing.Size(49, 51);
            this.pictureboxpatternclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxpatternclose.TabIndex = 108;
            this.pictureboxpatternclose.TabStop = false;
            this.pictureboxpatternclose.Click += new System.EventHandler(this.Pictureboxpatternclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::itproject.Properties.Resources.angryimg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 776);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 177;
            this.pictureBox1.TabStop = false;
            // 
            // PatternAndStockMangementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 776);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.Name = "PatternAndStockMangementSystem";
            this.Text = "PatternAndStockMangementSystem";
            this.Load += new System.EventHandler(this.PatternAndStockMangementSystem_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpatternclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonstock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonpattern;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnmaximize;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox pictureboxpatternclose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}