namespace EducationAutomationSystem.Forms.Applications
{
    partial class FrmChangeAcademicianPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeAcademicianPassword));
            this.lblsifredegisikligi = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.ChkConfirmPassword = new System.Windows.Forms.CheckBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ChkNewPassword = new System.Windows.Forms.CheckBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.ChkCurrentPassword = new System.Windows.Forms.CheckBox();
            this.lblcurrentpassword = new System.Windows.Forms.Label();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsifredegisikligi
            // 
            this.lblsifredegisikligi.AutoSize = true;
            this.lblsifredegisikligi.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifredegisikligi.Location = new System.Drawing.Point(121, 9);
            this.lblsifredegisikligi.Name = "lblsifredegisikligi";
            this.lblsifredegisikligi.Size = new System.Drawing.Size(345, 51);
            this.lblsifredegisikligi.TabIndex = 52;
            this.lblsifredegisikligi.Text = "ŞİFRE DEĞİŞİKLİĞİ";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(544, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 51;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(33, 19);
            this.TxtID.MaxLength = 20;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(30, 26);
            this.TxtID.TabIndex = 49;
            this.TxtID.UseSystemPasswordChar = true;
            this.TxtID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(331, 237);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 48);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Location = new System.Drawing.Point(155, 237);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(105, 48);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "Değiştir";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // ChkConfirmPassword
            // 
            this.ChkConfirmPassword.AutoSize = true;
            this.ChkConfirmPassword.Location = new System.Drawing.Point(348, 180);
            this.ChkConfirmPassword.Name = "ChkConfirmPassword";
            this.ChkConfirmPassword.Size = new System.Drawing.Size(118, 22);
            this.ChkConfirmPassword.TabIndex = 46;
            this.ChkConfirmPassword.Text = "Göster/Gizle";
            this.ChkConfirmPassword.UseVisualStyleBackColor = true;
            this.ChkConfirmPassword.CheckedChanged += new System.EventHandler(this.ChkConfirmPassword_CheckedChanged);
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(29, 180);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(112, 18);
            this.lblconfirmpassword.TabIndex = 45;
            this.lblconfirmpassword.Text = "Parola Tekrar:";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(177, 177);
            this.TxtConfirmPassword.MaxLength = 20;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtConfirmPassword.TabIndex = 3;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // ChkNewPassword
            // 
            this.ChkNewPassword.AutoSize = true;
            this.ChkNewPassword.Location = new System.Drawing.Point(348, 148);
            this.ChkNewPassword.Name = "ChkNewPassword";
            this.ChkNewPassword.Size = new System.Drawing.Size(118, 22);
            this.ChkNewPassword.TabIndex = 43;
            this.ChkNewPassword.Text = "Göster/Gizle";
            this.ChkNewPassword.UseVisualStyleBackColor = true;
            this.ChkNewPassword.CheckedChanged += new System.EventHandler(this.ChkNewPassword_CheckedChanged);
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(29, 148);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(94, 18);
            this.lblnewpassword.TabIndex = 42;
            this.lblnewpassword.Text = "Yeni Parola:";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(177, 145);
            this.TxtNewPassword.MaxLength = 20;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtNewPassword.TabIndex = 2;
            this.TxtNewPassword.UseSystemPasswordChar = true;
            // 
            // ChkCurrentPassword
            // 
            this.ChkCurrentPassword.AutoSize = true;
            this.ChkCurrentPassword.Location = new System.Drawing.Point(348, 116);
            this.ChkCurrentPassword.Name = "ChkCurrentPassword";
            this.ChkCurrentPassword.Size = new System.Drawing.Size(118, 22);
            this.ChkCurrentPassword.TabIndex = 40;
            this.ChkCurrentPassword.Text = "Göster/Gizle";
            this.ChkCurrentPassword.UseVisualStyleBackColor = true;
            this.ChkCurrentPassword.CheckedChanged += new System.EventHandler(this.ChkCurrentPassword_CheckedChanged);
            // 
            // lblcurrentpassword
            // 
            this.lblcurrentpassword.AutoSize = true;
            this.lblcurrentpassword.Location = new System.Drawing.Point(29, 116);
            this.lblcurrentpassword.Name = "lblcurrentpassword";
            this.lblcurrentpassword.Size = new System.Drawing.Size(116, 18);
            this.lblcurrentpassword.TabIndex = 39;
            this.lblcurrentpassword.Text = "Mevcut Parola:";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Location = new System.Drawing.Point(177, 113);
            this.TxtCurrentPassword.MaxLength = 20;
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtCurrentPassword.TabIndex = 1;
            this.TxtCurrentPassword.UseSystemPasswordChar = true;
            this.TxtCurrentPassword.TextChanged += new System.EventHandler(this.TxtCurrentPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // FrmChangeAcademicianPassword
            // 
            this.AcceptButton = this.BtnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(604, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsifredegisikligi);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.ChkConfirmPassword);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.ChkNewPassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.ChkCurrentPassword);
            this.Controls.Add(this.lblcurrentpassword);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChangeAcademicianPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangeAcademicianPassword";
            this.Load += new System.EventHandler(this.FrmChangeAcademicianPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsifredegisikligi;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.CheckBox ChkConfirmPassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.CheckBox ChkNewPassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.CheckBox ChkCurrentPassword;
        private System.Windows.Forms.Label lblcurrentpassword;
        private System.Windows.Forms.TextBox TxtCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}