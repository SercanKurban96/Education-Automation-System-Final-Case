namespace EducationAutomationSystem
{
    partial class FrmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogin));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lbltcno = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblparola = new System.Windows.Forms.Label();
            this.lblguvenlikkodu = new System.Windows.Forms.Label();
            this.TxtSecurityCode = new System.Windows.Forms.TextBox();
            this.LblSecurityCode = new System.Windows.Forms.Label();
            this.LnkLblLogin = new System.Windows.Forms.LinkLabel();
            this.LnkLblClear = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblyoneticigirispaneli = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.ChkShowHidePassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(513, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 8;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(39, 105);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(116, 18);
            this.lbltcno.TabIndex = 9;
            this.lbltcno.Text = "T.C. Kimlik No:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(162, 166);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            //this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(162, 102);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(165, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            //this.MskTRNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTRNumber_MaskInputRejected);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(39, 169);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(58, 18);
            this.lblparola.TabIndex = 12;
            this.lblparola.Text = "Parola:";
            // 
            // lblguvenlikkodu
            // 
            this.lblguvenlikkodu.AutoSize = true;
            this.lblguvenlikkodu.Location = new System.Drawing.Point(39, 230);
            this.lblguvenlikkodu.Name = "lblguvenlikkodu";
            this.lblguvenlikkodu.Size = new System.Drawing.Size(118, 18);
            this.lblguvenlikkodu.TabIndex = 14;
            this.lblguvenlikkodu.Text = "Güvenlik Kodu:";
            // 
            // TxtSecurityCode
            // 
            this.TxtSecurityCode.Location = new System.Drawing.Point(162, 227);
            this.TxtSecurityCode.MaxLength = 8;
            this.TxtSecurityCode.Name = "TxtSecurityCode";
            this.TxtSecurityCode.Size = new System.Drawing.Size(165, 26);
            this.TxtSecurityCode.TabIndex = 4;
            // 
            // LblSecurityCode
            // 
            this.LblSecurityCode.AutoSize = true;
            this.LblSecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblSecurityCode.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecurityCode.Location = new System.Drawing.Point(157, 266);
            this.LblSecurityCode.Name = "LblSecurityCode";
            this.LblSecurityCode.Size = new System.Drawing.Size(133, 29);
            this.LblSecurityCode.TabIndex = 15;
            this.LblSecurityCode.Text = "00000000";
            // 
            // LnkLblLogin
            // 
            this.LnkLblLogin.AutoSize = true;
            this.LnkLblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblLogin.LinkColor = System.Drawing.Color.Black;
            this.LnkLblLogin.Location = new System.Drawing.Point(164, 322);
            this.LnkLblLogin.Name = "LnkLblLogin";
            this.LnkLblLogin.Size = new System.Drawing.Size(90, 18);
            this.LnkLblLogin.TabIndex = 5;
            this.LnkLblLogin.TabStop = true;
            this.LnkLblLogin.Text = "GİRİŞ YAP";
            this.LnkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblLogin_LinkClicked);
            // 
            // LnkLblClear
            // 
            this.LnkLblClear.AutoSize = true;
            this.LnkLblClear.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblClear.LinkColor = System.Drawing.Color.Black;
            this.LnkLblClear.Location = new System.Drawing.Point(321, 322);
            this.LnkLblClear.Name = "LnkLblClear";
            this.LnkLblClear.Size = new System.Drawing.Size(81, 18);
            this.LnkLblClear.TabIndex = 6;
            this.LnkLblClear.TabStop = true;
            this.LnkLblClear.Text = "TEMİZLE";
            this.LnkLblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblClear_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblyoneticigirispaneli
            // 
            this.lblyoneticigirispaneli.AutoSize = true;
            this.lblyoneticigirispaneli.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticigirispaneli.Location = new System.Drawing.Point(116, 35);
            this.lblyoneticigirispaneli.Name = "lblyoneticigirispaneli";
            this.lblyoneticigirispaneli.Size = new System.Drawing.Size(336, 31);
            this.lblyoneticigirispaneli.TabIndex = 19;
            this.lblyoneticigirispaneli.Text = "YÖNETİCİ GİRİŞ PANELİ";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(39, 137);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(101, 18);
            this.lblkullaniciadi.TabIndex = 21;
            this.lblkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(162, 134);
            this.TxtUsername.MaxLength = 8;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(165, 26);
            this.TxtUsername.TabIndex = 2;
            // 
            // ChkShowHidePassword
            // 
            this.ChkShowHidePassword.AutoSize = true;
            this.ChkShowHidePassword.Location = new System.Drawing.Point(162, 199);
            this.ChkShowHidePassword.Name = "ChkShowHidePassword";
            this.ChkShowHidePassword.Size = new System.Drawing.Size(137, 22);
            this.ChkShowHidePassword.TabIndex = 22;
            this.ChkShowHidePassword.Text = "Parolayı Göster";
            this.ChkShowHidePassword.UseVisualStyleBackColor = true;
            this.ChkShowHidePassword.CheckedChanged += new System.EventHandler(this.ChkShowHidePassword_CheckedChanged);
            // 
            // FrmAdminLogin
            // 
            this.AcceptButton = this.LnkLblLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.LnkLblClear;
            this.ClientSize = new System.Drawing.Size(571, 360);
            this.Controls.Add(this.ChkShowHidePassword);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.lblyoneticigirispaneli);
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
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.Label lblguvenlikkodu;
        private System.Windows.Forms.TextBox TxtSecurityCode;
        private System.Windows.Forms.Label LblSecurityCode;
        private System.Windows.Forms.LinkLabel LnkLblLogin;
        private System.Windows.Forms.LinkLabel LnkLblClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblyoneticigirispaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.CheckBox ChkShowHidePassword;
    }
}