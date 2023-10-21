﻿namespace EducationAutomationSystem.Forms.Student
{
    partial class FrmStudentApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentApplication));
            this.lbluygulamalarformu = new System.Windows.Forms.Label();
            this.lblhesapmakinesi = new System.Windows.Forms.Label();
            this.PctCalculator = new System.Windows.Forms.PictureBox();
            this.lblmuzikdinle = new System.Windows.Forms.Label();
            this.PctMusic = new System.Windows.Forms.PictureBox();
            this.lblradyo = new System.Windows.Forms.Label();
            this.PctRadio = new System.Windows.Forms.PictureBox();
            this.lblgazeteler = new System.Windows.Forms.Label();
            this.PctNewspaper = new System.Windows.Forms.PictureBox();
            this.PctExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNewspaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluygulamalarformu
            // 
            this.lbluygulamalarformu.AutoSize = true;
            this.lbluygulamalarformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluygulamalarformu.Location = new System.Drawing.Point(246, 9);
            this.lbluygulamalarformu.Name = "lbluygulamalarformu";
            this.lbluygulamalarformu.Size = new System.Drawing.Size(303, 51);
            this.lbluygulamalarformu.TabIndex = 40;
            this.lbluygulamalarformu.Text = "UYGULAMALAR";
            // 
            // lblhesapmakinesi
            // 
            this.lblhesapmakinesi.AutoSize = true;
            this.lblhesapmakinesi.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhesapmakinesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblhesapmakinesi.Location = new System.Drawing.Point(608, 479);
            this.lblhesapmakinesi.Name = "lblhesapmakinesi";
            this.lblhesapmakinesi.Size = new System.Drawing.Size(210, 29);
            this.lblhesapmakinesi.TabIndex = 39;
            this.lblhesapmakinesi.Text = "Hesap Makinesi";
            // 
            // PctCalculator
            // 
            this.PctCalculator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctCalculator.Image = ((System.Drawing.Image)(resources.GetObject("PctCalculator.Image")));
            this.PctCalculator.Location = new System.Drawing.Point(596, 322);
            this.PctCalculator.Name = "PctCalculator";
            this.PctCalculator.Size = new System.Drawing.Size(184, 139);
            this.PctCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctCalculator.TabIndex = 38;
            this.PctCalculator.TabStop = false;
            this.PctCalculator.Click += new System.EventHandler(this.PctCalculator_Click);
            // 
            // lblmuzikdinle
            // 
            this.lblmuzikdinle.AutoSize = true;
            this.lblmuzikdinle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmuzikdinle.ForeColor = System.Drawing.Color.Blue;
            this.lblmuzikdinle.Location = new System.Drawing.Point(49, 479);
            this.lblmuzikdinle.Name = "lblmuzikdinle";
            this.lblmuzikdinle.Size = new System.Drawing.Size(164, 29);
            this.lblmuzikdinle.TabIndex = 37;
            this.lblmuzikdinle.Text = "Müzik Dinle";
            // 
            // PctMusic
            // 
            this.PctMusic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMusic.Image = ((System.Drawing.Image)(resources.GetObject("PctMusic.Image")));
            this.PctMusic.Location = new System.Drawing.Point(50, 322);
            this.PctMusic.Name = "PctMusic";
            this.PctMusic.Size = new System.Drawing.Size(184, 139);
            this.PctMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMusic.TabIndex = 36;
            this.PctMusic.TabStop = false;
            this.PctMusic.Click += new System.EventHandler(this.PctMusic_Click);
            // 
            // lblradyo
            // 
            this.lblradyo.AutoSize = true;
            this.lblradyo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblradyo.ForeColor = System.Drawing.Color.Green;
            this.lblradyo.Location = new System.Drawing.Point(644, 258);
            this.lblradyo.Name = "lblradyo";
            this.lblradyo.Size = new System.Drawing.Size(90, 29);
            this.lblradyo.TabIndex = 35;
            this.lblradyo.Text = "Radyo";
            // 
            // PctRadio
            // 
            this.PctRadio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctRadio.Image = ((System.Drawing.Image)(resources.GetObject("PctRadio.Image")));
            this.PctRadio.Location = new System.Drawing.Point(596, 101);
            this.PctRadio.Name = "PctRadio";
            this.PctRadio.Size = new System.Drawing.Size(184, 139);
            this.PctRadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctRadio.TabIndex = 34;
            this.PctRadio.TabStop = false;
            this.PctRadio.Click += new System.EventHandler(this.PctRadio_Click);
            // 
            // lblgazeteler
            // 
            this.lblgazeteler.AutoSize = true;
            this.lblgazeteler.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgazeteler.Location = new System.Drawing.Point(59, 262);
            this.lblgazeteler.Name = "lblgazeteler";
            this.lblgazeteler.Size = new System.Drawing.Size(131, 29);
            this.lblgazeteler.TabIndex = 33;
            this.lblgazeteler.Text = "Gazeteler";
            // 
            // PctNewspaper
            // 
            this.PctNewspaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctNewspaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctNewspaper.Image = ((System.Drawing.Image)(resources.GetObject("PctNewspaper.Image")));
            this.PctNewspaper.Location = new System.Drawing.Point(50, 101);
            this.PctNewspaper.Name = "PctNewspaper";
            this.PctNewspaper.Size = new System.Drawing.Size(184, 139);
            this.PctNewspaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctNewspaper.TabIndex = 32;
            this.PctNewspaper.TabStop = false;
            this.PctNewspaper.Click += new System.EventHandler(this.PctNewspaper_Click);
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(785, 1);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 41;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // FrmStudentApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(845, 526);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.lbluygulamalarformu);
            this.Controls.Add(this.lblhesapmakinesi);
            this.Controls.Add(this.PctCalculator);
            this.Controls.Add(this.lblmuzikdinle);
            this.Controls.Add(this.PctMusic);
            this.Controls.Add(this.lblradyo);
            this.Controls.Add(this.PctRadio);
            this.Controls.Add(this.lblgazeteler);
            this.Controls.Add(this.PctNewspaper);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentApplication";
            this.Load += new System.EventHandler(this.FrmStudentApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNewspaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluygulamalarformu;
        private System.Windows.Forms.Label lblhesapmakinesi;
        private System.Windows.Forms.PictureBox PctCalculator;
        private System.Windows.Forms.Label lblmuzikdinle;
        private System.Windows.Forms.PictureBox PctMusic;
        private System.Windows.Forms.Label lblradyo;
        private System.Windows.Forms.PictureBox PctRadio;
        private System.Windows.Forms.Label lblgazeteler;
        private System.Windows.Forms.PictureBox PctNewspaper;
        private System.Windows.Forms.PictureBox PctExit;
    }
}