namespace EducationAutomationSystem.Notification
{
    partial class FrmEditNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditNotification));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.DtgNotification = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblduyuruduzenleformu = new System.Windows.Forms.Label();
            this.RchNotificationContent = new System.Windows.Forms.RichTextBox();
            this.TxtNotificationTitle = new System.Windows.Forms.TextBox();
            this.LblNotificationCount = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DtpNotificationDate = new System.Windows.Forms.DateTimePicker();
            this.lblduyurusayisi = new System.Windows.Forms.Label();
            this.lblduyuruicerik = new System.Windows.Forms.Label();
            this.lblduyurubasligi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(0, -28);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(48, 26);
            this.TxtID.TabIndex = 42;
            this.TxtID.Visible = false;
            // 
            // DtgNotification
            // 
            this.DtgNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgNotification.Location = new System.Drawing.Point(0, 379);
            this.DtgNotification.Name = "DtgNotification";
            this.DtgNotification.Size = new System.Drawing.Size(810, 153);
            this.DtgNotification.TabIndex = 41;
            this.DtgNotification.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgNotification_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(749, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 39;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblduyuruduzenleformu
            // 
            this.lblduyuruduzenleformu.AutoSize = true;
            this.lblduyuruduzenleformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyuruduzenleformu.Location = new System.Drawing.Point(230, 9);
            this.lblduyuruduzenleformu.Name = "lblduyuruduzenleformu";
            this.lblduyuruduzenleformu.Size = new System.Drawing.Size(363, 51);
            this.lblduyuruduzenleformu.TabIndex = 38;
            this.lblduyuruduzenleformu.Text = "DUYURU DÜZENLE";
            // 
            // RchNotificationContent
            // 
            this.RchNotificationContent.Location = new System.Drawing.Point(165, 126);
            this.RchNotificationContent.Name = "RchNotificationContent";
            this.RchNotificationContent.Size = new System.Drawing.Size(499, 187);
            this.RchNotificationContent.TabIndex = 33;
            this.RchNotificationContent.Text = "";
            // 
            // TxtNotificationTitle
            // 
            this.TxtNotificationTitle.Location = new System.Drawing.Point(165, 91);
            this.TxtNotificationTitle.Name = "TxtNotificationTitle";
            this.TxtNotificationTitle.Size = new System.Drawing.Size(499, 26);
            this.TxtNotificationTitle.TabIndex = 32;
            // 
            // LblNotificationCount
            // 
            this.LblNotificationCount.AutoSize = true;
            this.LblNotificationCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotificationCount.Location = new System.Drawing.Point(174, 331);
            this.LblNotificationCount.Name = "LblNotificationCount";
            this.LblNotificationCount.Size = new System.Drawing.Size(22, 23);
            this.LblNotificationCount.TabIndex = 46;
            this.LblNotificationCount.Text = "0";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(440, 323);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 44;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(264, 323);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 43;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // DtpNotificationDate
            // 
            this.DtpNotificationDate.Location = new System.Drawing.Point(3, 1);
            this.DtpNotificationDate.Name = "DtpNotificationDate";
            this.DtpNotificationDate.Size = new System.Drawing.Size(34, 26);
            this.DtpNotificationDate.TabIndex = 48;
            this.DtpNotificationDate.Visible = false;
            // 
            // lblduyurusayisi
            // 
            this.lblduyurusayisi.AutoSize = true;
            this.lblduyurusayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurusayisi.Location = new System.Drawing.Point(-1, 331);
            this.lblduyurusayisi.Name = "lblduyurusayisi";
            this.lblduyurusayisi.Size = new System.Drawing.Size(135, 23);
            this.lblduyurusayisi.TabIndex = 54;
            this.lblduyurusayisi.Text = "Duyuru Sayısı:";
            // 
            // lblduyuruicerik
            // 
            this.lblduyuruicerik.AutoSize = true;
            this.lblduyuruicerik.Location = new System.Drawing.Point(0, 129);
            this.lblduyuruicerik.Name = "lblduyuruicerik";
            this.lblduyuruicerik.Size = new System.Drawing.Size(55, 18);
            this.lblduyuruicerik.TabIndex = 53;
            this.lblduyuruicerik.Text = "İçerik:";
            // 
            // lblduyurubasligi
            // 
            this.lblduyurubasligi.AutoSize = true;
            this.lblduyurubasligi.Location = new System.Drawing.Point(0, 94);
            this.lblduyurubasligi.Name = "lblduyurubasligi";
            this.lblduyurubasligi.Size = new System.Drawing.Size(116, 18);
            this.lblduyurubasligi.TabIndex = 52;
            this.lblduyurubasligi.Text = "Duyuru Başlığı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 137;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmEditNotification
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(810, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblduyurusayisi);
            this.Controls.Add(this.lblduyuruicerik);
            this.Controls.Add(this.lblduyurubasligi);
            this.Controls.Add(this.DtpNotificationDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblNotificationCount);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DtgNotification);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblduyuruduzenleformu);
            this.Controls.Add(this.RchNotificationContent);
            this.Controls.Add(this.TxtNotificationTitle);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditNotification";
            this.Load += new System.EventHandler(this.FrmEditNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridView DtgNotification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblduyuruduzenleformu;
        private System.Windows.Forms.RichTextBox RchNotificationContent;
        private System.Windows.Forms.TextBox TxtNotificationTitle;
        private System.Windows.Forms.Label LblNotificationCount;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker DtpNotificationDate;
        private System.Windows.Forms.Label lblduyurusayisi;
        private System.Windows.Forms.Label lblduyuruicerik;
        private System.Windows.Forms.Label lblduyurubasligi;
        private System.Windows.Forms.Label label1;
    }
}