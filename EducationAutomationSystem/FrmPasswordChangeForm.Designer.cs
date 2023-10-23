namespace EducationAutomationSystem
{
    partial class FrmPasswordChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordChangeForm));
            this.lblpasswordchangeform = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblakademisyentcno = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LblSecurityCode = new System.Windows.Forms.Label();
            this.lblguvenlikkodu = new System.Windows.Forms.Label();
            this.TxtSecurityCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpasswordchangeform
            // 
            this.lblpasswordchangeform.AutoSize = true;
            this.lblpasswordchangeform.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpasswordchangeform.Location = new System.Drawing.Point(73, 9);
            this.lblpasswordchangeform.Name = "lblpasswordchangeform";
            this.lblpasswordchangeform.Size = new System.Drawing.Size(477, 38);
            this.lblpasswordchangeform.TabIndex = 0;
            this.lblpasswordchangeform.Text = "PAROLA DEĞİŞİKLİĞİ FORMU";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(162, 85);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(240, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            // 
            // lblakademisyentcno
            // 
            this.lblakademisyentcno.AutoSize = true;
            this.lblakademisyentcno.Location = new System.Drawing.Point(12, 88);
            this.lblakademisyentcno.Name = "lblakademisyentcno";
            this.lblakademisyentcno.Size = new System.Drawing.Size(66, 18);
            this.lblakademisyentcno.TabIndex = 8;
            this.lblakademisyentcno.Text = "T.C. No:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(162, 150);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(240, 26);
            this.DtpBirthDate.TabIndex = 3;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(12, 154);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 15;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(162, 117);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(240, 26);
            this.TxtMail.TabIndex = 2;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(12, 120);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 22;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(369, 282);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(577, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 127;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Location = new System.Drawing.Point(118, 282);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(149, 43);
            this.BtnCheck.TabIndex = 5;
            this.BtnCheck.Text = "Kontrol Et";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // LblSecurityCode
            // 
            this.LblSecurityCode.AutoSize = true;
            this.LblSecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblSecurityCode.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecurityCode.Location = new System.Drawing.Point(157, 221);
            this.LblSecurityCode.Name = "LblSecurityCode";
            this.LblSecurityCode.Size = new System.Drawing.Size(133, 29);
            this.LblSecurityCode.TabIndex = 135;
            this.LblSecurityCode.Text = "00000000";
            // 
            // lblguvenlikkodu
            // 
            this.lblguvenlikkodu.AutoSize = true;
            this.lblguvenlikkodu.Location = new System.Drawing.Point(12, 185);
            this.lblguvenlikkodu.Name = "lblguvenlikkodu";
            this.lblguvenlikkodu.Size = new System.Drawing.Size(118, 18);
            this.lblguvenlikkodu.TabIndex = 134;
            this.lblguvenlikkodu.Text = "Güvenlik Kodu:";
            // 
            // TxtSecurityCode
            // 
            this.TxtSecurityCode.Location = new System.Drawing.Point(162, 182);
            this.TxtSecurityCode.MaxLength = 8;
            this.TxtSecurityCode.Name = "TxtSecurityCode";
            this.TxtSecurityCode.Size = new System.Drawing.Size(165, 26);
            this.TxtSecurityCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 131;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 132;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPasswordChangeForm
            // 
            this.AcceptButton = this.BtnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(637, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblSecurityCode);
            this.Controls.Add(this.lblguvenlikkodu);
            this.Controls.Add(this.TxtSecurityCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.lblbirthdate);
            this.Controls.Add(this.MskTRNumber);
            this.Controls.Add(this.lblakademisyentcno);
            this.Controls.Add(this.lblpasswordchangeform);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPasswordChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPasswordReminderForm";
            this.Load += new System.EventHandler(this.FrmPasswordChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpasswordchangeform;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.Label lblakademisyentcno;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label LblSecurityCode;
        private System.Windows.Forms.Label lblguvenlikkodu;
        private System.Windows.Forms.TextBox TxtSecurityCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}