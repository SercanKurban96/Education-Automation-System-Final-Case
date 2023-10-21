namespace EducationAutomationSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PctAdministrator = new System.Windows.Forms.PictureBox();
            this.PctTeacher = new System.Windows.Forms.PictureBox();
            this.PctStudent = new System.Windows.Forms.PictureBox();
            this.lblyonetici = new System.Windows.Forms.Label();
            this.lblakademisyen = new System.Windows.Forms.Label();
            this.lblogrenci = new System.Windows.Forms.Label();
            this.PctExit = new System.Windows.Forms.PictureBox();
            this.lblegitimotomasyonugirispanelleri = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbllogineos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PctAdministrator
            // 
            this.PctAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctAdministrator.Image = ((System.Drawing.Image)(resources.GetObject("PctAdministrator.Image")));
            this.PctAdministrator.Location = new System.Drawing.Point(110, 154);
            this.PctAdministrator.Name = "PctAdministrator";
            this.PctAdministrator.Size = new System.Drawing.Size(125, 115);
            this.PctAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAdministrator.TabIndex = 0;
            this.PctAdministrator.TabStop = false;
            this.PctAdministrator.Click += new System.EventHandler(this.PctAdministrator_Click);
            // 
            // PctTeacher
            // 
            this.PctTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctTeacher.Image = ((System.Drawing.Image)(resources.GetObject("PctTeacher.Image")));
            this.PctTeacher.Location = new System.Drawing.Point(310, 154);
            this.PctTeacher.Name = "PctTeacher";
            this.PctTeacher.Size = new System.Drawing.Size(125, 115);
            this.PctTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTeacher.TabIndex = 1;
            this.PctTeacher.TabStop = false;
            this.PctTeacher.Click += new System.EventHandler(this.PctTeacher_Click);
            // 
            // PctStudent
            // 
            this.PctStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctStudent.Image = ((System.Drawing.Image)(resources.GetObject("PctStudent.Image")));
            this.PctStudent.Location = new System.Drawing.Point(510, 154);
            this.PctStudent.Name = "PctStudent";
            this.PctStudent.Size = new System.Drawing.Size(125, 115);
            this.PctStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStudent.TabIndex = 2;
            this.PctStudent.TabStop = false;
            this.PctStudent.Click += new System.EventHandler(this.PctStudent_Click);
            // 
            // lblyonetici
            // 
            this.lblyonetici.AutoSize = true;
            this.lblyonetici.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyonetici.ForeColor = System.Drawing.Color.Red;
            this.lblyonetici.Location = new System.Drawing.Point(123, 284);
            this.lblyonetici.Name = "lblyonetici";
            this.lblyonetici.Size = new System.Drawing.Size(107, 27);
            this.lblyonetici.TabIndex = 3;
            this.lblyonetici.Text = "Yönetici";
            // 
            // lblakademisyen
            // 
            this.lblakademisyen.AutoSize = true;
            this.lblakademisyen.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblakademisyen.Location = new System.Drawing.Point(294, 284);
            this.lblakademisyen.Name = "lblakademisyen";
            this.lblakademisyen.Size = new System.Drawing.Size(164, 27);
            this.lblakademisyen.TabIndex = 4;
            this.lblakademisyen.Text = "Akademisyen";
            // 
            // lblogrenci
            // 
            this.lblogrenci.AutoSize = true;
            this.lblogrenci.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblogrenci.Location = new System.Drawing.Point(521, 284);
            this.lblogrenci.Name = "lblogrenci";
            this.lblogrenci.Size = new System.Drawing.Size(102, 27);
            this.lblogrenci.TabIndex = 5;
            this.lblogrenci.Text = "Öğrenci";
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(686, 2);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 7;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // lblegitimotomasyonugirispanelleri
            // 
            this.lblegitimotomasyonugirispanelleri.AutoSize = true;
            this.lblegitimotomasyonugirispanelleri.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblegitimotomasyonugirispanelleri.Location = new System.Drawing.Point(55, 9);
            this.lblegitimotomasyonugirispanelleri.Name = "lblegitimotomasyonugirispanelleri";
            this.lblegitimotomasyonugirispanelleri.Size = new System.Drawing.Size(585, 56);
            this.lblegitimotomasyonugirispanelleri.TabIndex = 8;
            this.lblegitimotomasyonugirispanelleri.Text = "Eğitim Otomasyonu Giriş Panelleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(642, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lbllogineos
            // 
            this.lbllogineos.AutoSize = true;
            this.lbllogineos.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllogineos.Location = new System.Drawing.Point(160, 343);
            this.lbllogineos.Name = "lbllogineos";
            this.lbllogineos.Size = new System.Drawing.Size(313, 27);
            this.lbllogineos.TabIndex = 11;
            this.lbllogineos.Text = "Eğitim Otomasyon Sistemi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(746, 402);
            this.Controls.Add(this.lbllogineos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblegitimotomasyonugirispanelleri);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.lblogrenci);
            this.Controls.Add(this.lblakademisyen);
            this.Controls.Add(this.lblyonetici);
            this.Controls.Add(this.PctStudent);
            this.Controls.Add(this.PctTeacher);
            this.Controls.Add(this.PctAdministrator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctAdministrator;
        private System.Windows.Forms.PictureBox PctTeacher;
        private System.Windows.Forms.PictureBox PctStudent;
        private System.Windows.Forms.Label lblyonetici;
        private System.Windows.Forms.Label lblakademisyen;
        private System.Windows.Forms.Label lblogrenci;
        private System.Windows.Forms.PictureBox PctExit;
        private System.Windows.Forms.Label lblegitimotomasyonugirispanelleri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbllogineos;
        private System.Windows.Forms.Timer timer1;
    }
}

