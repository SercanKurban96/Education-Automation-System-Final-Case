namespace EducationAutomationSystem.Notification
{
    partial class FrmAddNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNotification));
            this.lblduyurubasligi = new System.Windows.Forms.Label();
            this.TxtNotificationTitle = new System.Windows.Forms.TextBox();
            this.RchNotificationContent = new System.Windows.Forms.RichTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblduyuruicerik = new System.Windows.Forms.Label();
            this.lblduyuruolusturformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblNotificationCount = new System.Windows.Forms.Label();
            this.lblduyurusayisi = new System.Windows.Forms.Label();
            this.DtpNotificationDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblduyurubasligi
            // 
            this.lblduyurubasligi.AutoSize = true;
            this.lblduyurubasligi.Location = new System.Drawing.Point(24, 90);
            this.lblduyurubasligi.Name = "lblduyurubasligi";
            this.lblduyurubasligi.Size = new System.Drawing.Size(116, 18);
            this.lblduyurubasligi.TabIndex = 1;
            this.lblduyurubasligi.Text = "Duyuru Başlığı:";
            // 
            // TxtNotificationTitle
            // 
            this.TxtNotificationTitle.Location = new System.Drawing.Point(166, 87);
            this.TxtNotificationTitle.Name = "TxtNotificationTitle";
            this.TxtNotificationTitle.Size = new System.Drawing.Size(499, 26);
            this.TxtNotificationTitle.TabIndex = 1;
            // 
            // RchNotificationContent
            // 
            this.RchNotificationContent.Location = new System.Drawing.Point(166, 122);
            this.RchNotificationContent.Name = "RchNotificationContent";
            this.RchNotificationContent.Size = new System.Drawing.Size(499, 187);
            this.RchNotificationContent.TabIndex = 2;
            this.RchNotificationContent.Text = "";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(432, 315);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(256, 315);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Oluştur";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblduyuruicerik
            // 
            this.lblduyuruicerik.AutoSize = true;
            this.lblduyuruicerik.Location = new System.Drawing.Point(24, 125);
            this.lblduyuruicerik.Name = "lblduyuruicerik";
            this.lblduyuruicerik.Size = new System.Drawing.Size(55, 18);
            this.lblduyuruicerik.TabIndex = 8;
            this.lblduyuruicerik.Text = "İçerik:";
            // 
            // lblduyuruolusturformu
            // 
            this.lblduyuruolusturformu.AutoSize = true;
            this.lblduyuruolusturformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyuruolusturformu.Location = new System.Drawing.Point(224, 5);
            this.lblduyuruolusturformu.Name = "lblduyuruolusturformu";
            this.lblduyuruolusturformu.Size = new System.Drawing.Size(357, 51);
            this.lblduyuruolusturformu.TabIndex = 18;
            this.lblduyuruolusturformu.Text = "DUYURU OLUŞTUR";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(749, 3);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 19;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(693, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(43, 26);
            this.TxtID.TabIndex = 33;
            this.TxtID.Visible = false;
            // 
            // LblNotificationCount
            // 
            this.LblNotificationCount.AutoSize = true;
            this.LblNotificationCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotificationCount.Location = new System.Drawing.Point(177, 327);
            this.LblNotificationCount.Name = "LblNotificationCount";
            this.LblNotificationCount.Size = new System.Drawing.Size(22, 23);
            this.LblNotificationCount.TabIndex = 35;
            this.LblNotificationCount.Text = "0";
            // 
            // lblduyurusayisi
            // 
            this.lblduyurusayisi.AutoSize = true;
            this.lblduyurusayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurusayisi.Location = new System.Drawing.Point(-3, 327);
            this.lblduyurusayisi.Name = "lblduyurusayisi";
            this.lblduyurusayisi.Size = new System.Drawing.Size(135, 23);
            this.lblduyurusayisi.TabIndex = 34;
            this.lblduyurusayisi.Text = "Duyuru Sayısı:";
            // 
            // DtpNotificationDate
            // 
            this.DtpNotificationDate.Location = new System.Drawing.Point(75, 5);
            this.DtpNotificationDate.Name = "DtpNotificationDate";
            this.DtpNotificationDate.Size = new System.Drawing.Size(34, 26);
            this.DtpNotificationDate.TabIndex = 36;
            this.DtpNotificationDate.Visible = false;
            // 
            // FrmAddNotification
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(810, 378);
            this.Controls.Add(this.DtpNotificationDate);
            this.Controls.Add(this.LblNotificationCount);
            this.Controls.Add(this.lblduyurusayisi);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblduyuruolusturformu);
            this.Controls.Add(this.lblduyuruicerik);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.RchNotificationContent);
            this.Controls.Add(this.TxtNotificationTitle);
            this.Controls.Add(this.lblduyurubasligi);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNotification";
            this.Load += new System.EventHandler(this.FrmAddNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblduyurubasligi;
        private System.Windows.Forms.TextBox TxtNotificationTitle;
        private System.Windows.Forms.RichTextBox RchNotificationContent;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblduyuruicerik;
        private System.Windows.Forms.Label lblduyuruolusturformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblNotificationCount;
        private System.Windows.Forms.Label lblduyurusayisi;
        private System.Windows.Forms.DateTimePicker DtpNotificationDate;
    }
}