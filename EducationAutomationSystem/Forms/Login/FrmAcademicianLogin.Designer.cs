namespace EducationAutomationSystem
{
    partial class FrmAcademicianLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademicianLogin));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblakademisyengirispaneli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LnkLblClear = new System.Windows.Forms.LinkLabel();
            this.LnkLblLogin = new System.Windows.Forms.LinkLabel();
            this.LblSecurityCode = new System.Windows.Forms.Label();
            this.lblguvenlikkodu = new System.Windows.Forms.Label();
            this.TxtSecurityCode = new System.Windows.Forms.TextBox();
            this.lblparola = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lbltcno = new System.Windows.Forms.Label();
            this.ChkShowHidePassword = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(512, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 10;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblakademisyengirispaneli
            // 
            this.lblakademisyengirispaneli.AutoSize = true;
            this.lblakademisyengirispaneli.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyengirispaneli.Location = new System.Drawing.Point(76, 41);
            this.lblakademisyengirispaneli.Name = "lblakademisyengirispaneli";
            this.lblakademisyengirispaneli.Size = new System.Drawing.Size(404, 31);
            this.lblakademisyengirispaneli.TabIndex = 30;
            this.lblakademisyengirispaneli.Text = "AKADEMİSYEN GİRİŞ PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // LnkLblClear
            // 
            this.LnkLblClear.AutoSize = true;
            this.LnkLblClear.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblClear.LinkColor = System.Drawing.Color.Black;
            this.LnkLblClear.Location = new System.Drawing.Point(312, 334);
            this.LnkLblClear.Name = "LnkLblClear";
            this.LnkLblClear.Size = new System.Drawing.Size(81, 18);
            this.LnkLblClear.TabIndex = 28;
            this.LnkLblClear.TabStop = true;
            this.LnkLblClear.Text = "TEMİZLE";
            this.LnkLblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblClear_LinkClicked);
            // 
            // LnkLblLogin
            // 
            this.LnkLblLogin.AutoSize = true;
            this.LnkLblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblLogin.LinkColor = System.Drawing.Color.Black;
            this.LnkLblLogin.Location = new System.Drawing.Point(155, 334);
            this.LnkLblLogin.Name = "LnkLblLogin";
            this.LnkLblLogin.Size = new System.Drawing.Size(90, 18);
            this.LnkLblLogin.TabIndex = 27;
            this.LnkLblLogin.TabStop = true;
            this.LnkLblLogin.Text = "GİRİŞ YAP";
            this.LnkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblLogin_LinkClicked);
            // 
            // LblSecurityCode
            // 
            this.LblSecurityCode.AutoSize = true;
            this.LblSecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblSecurityCode.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecurityCode.Location = new System.Drawing.Point(144, 239);
            this.LblSecurityCode.Name = "LblSecurityCode";
            this.LblSecurityCode.Size = new System.Drawing.Size(133, 29);
            this.LblSecurityCode.TabIndex = 26;
            this.LblSecurityCode.Text = "00000000";
            // 
            // lblguvenlikkodu
            // 
            this.lblguvenlikkodu.AutoSize = true;
            this.lblguvenlikkodu.Location = new System.Drawing.Point(25, 203);
            this.lblguvenlikkodu.Name = "lblguvenlikkodu";
            this.lblguvenlikkodu.Size = new System.Drawing.Size(118, 18);
            this.lblguvenlikkodu.TabIndex = 25;
            this.lblguvenlikkodu.Text = "Güvenlik Kodu:";
            // 
            // TxtSecurityCode
            // 
            this.TxtSecurityCode.Location = new System.Drawing.Point(149, 200);
            this.TxtSecurityCode.MaxLength = 8;
            this.TxtSecurityCode.Name = "TxtSecurityCode";
            this.TxtSecurityCode.Size = new System.Drawing.Size(165, 26);
            this.TxtSecurityCode.TabIndex = 22;
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(25, 143);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(58, 18);
            this.lblparola.TabIndex = 24;
            this.lblparola.Text = "Parola:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(149, 108);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(165, 26);
            this.MskTRNumber.TabIndex = 20;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(149, 140);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtPassword.TabIndex = 21;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(25, 111);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(116, 18);
            this.lbltcno.TabIndex = 23;
            this.lbltcno.Text = "T.C. Kimlik No:";
            // 
            // ChkShowHidePassword
            // 
            this.ChkShowHidePassword.AutoSize = true;
            this.ChkShowHidePassword.Location = new System.Drawing.Point(149, 172);
            this.ChkShowHidePassword.Name = "ChkShowHidePassword";
            this.ChkShowHidePassword.Size = new System.Drawing.Size(137, 22);
            this.ChkShowHidePassword.TabIndex = 31;
            this.ChkShowHidePassword.Text = "Parolayı Göster";
            this.ChkShowHidePassword.UseVisualStyleBackColor = true;
            this.ChkShowHidePassword.CheckedChanged += new System.EventHandler(this.ChkShowHidePassword_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAcademicianLogin
            // 
            this.AcceptButton = this.LnkLblLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.LnkLblClear;
            this.ClientSize = new System.Drawing.Size(571, 377);
            this.Controls.Add(this.ChkShowHidePassword);
            this.Controls.Add(this.lblakademisyengirispaneli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LnkLblClear);
            this.Controls.Add(this.LnkLblLogin);
            this.Controls.Add(this.LblSecurityCode);
            this.Controls.Add(this.lblguvenlikkodu);
            this.Controls.Add(this.TxtSecurityCode);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.MskTRNumber);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.lbltcno);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAcademicianLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTeacherLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblakademisyengirispaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LnkLblClear;
        private System.Windows.Forms.LinkLabel LnkLblLogin;
        private System.Windows.Forms.Label LblSecurityCode;
        private System.Windows.Forms.Label lblguvenlikkodu;
        private System.Windows.Forms.TextBox TxtSecurityCode;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.CheckBox ChkShowHidePassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}