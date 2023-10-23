namespace EducationAutomationSystem
{
    partial class FrmNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewPassword));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.ChkConfirmPassword = new System.Windows.Forms.CheckBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ChkNewPassword = new System.Windows.Forms.CheckBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblnewpasswordform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 134;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(353, 210);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 48);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Location = new System.Drawing.Point(177, 210);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(105, 48);
            this.BtnChange.TabIndex = 3;
            this.BtnChange.Text = "Değiştir";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // ChkConfirmPassword
            // 
            this.ChkConfirmPassword.AutoSize = true;
            this.ChkConfirmPassword.Location = new System.Drawing.Point(370, 153);
            this.ChkConfirmPassword.Name = "ChkConfirmPassword";
            this.ChkConfirmPassword.Size = new System.Drawing.Size(118, 22);
            this.ChkConfirmPassword.TabIndex = 6;
            this.ChkConfirmPassword.Text = "Göster/Gizle";
            this.ChkConfirmPassword.UseVisualStyleBackColor = true;
            this.ChkConfirmPassword.CheckedChanged += new System.EventHandler(this.ChkConfirmPassword_CheckedChanged);
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(51, 153);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(112, 18);
            this.lblconfirmpassword.TabIndex = 141;
            this.lblconfirmpassword.Text = "Parola Tekrar:";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(199, 150);
            this.TxtConfirmPassword.MaxLength = 20;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtConfirmPassword.TabIndex = 2;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // ChkNewPassword
            // 
            this.ChkNewPassword.AutoSize = true;
            this.ChkNewPassword.Location = new System.Drawing.Point(370, 121);
            this.ChkNewPassword.Name = "ChkNewPassword";
            this.ChkNewPassword.Size = new System.Drawing.Size(118, 22);
            this.ChkNewPassword.TabIndex = 5;
            this.ChkNewPassword.Text = "Göster/Gizle";
            this.ChkNewPassword.UseVisualStyleBackColor = true;
            this.ChkNewPassword.CheckedChanged += new System.EventHandler(this.ChkNewPassword_CheckedChanged);
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(51, 121);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(94, 18);
            this.lblnewpassword.TabIndex = 139;
            this.lblnewpassword.Text = "Yeni Parola:";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(199, 118);
            this.TxtNewPassword.MaxLength = 20;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtNewPassword.TabIndex = 1;
            this.TxtNewPassword.UseSystemPasswordChar = true;
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
            this.PctBack.TabIndex = 144;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblnewpasswordform
            // 
            this.lblnewpasswordform.AutoSize = true;
            this.lblnewpasswordform.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnewpasswordform.Location = new System.Drawing.Point(194, 9);
            this.lblnewpasswordform.Name = "lblnewpasswordform";
            this.lblnewpasswordform.Size = new System.Drawing.Size(230, 38);
            this.lblnewpasswordform.TabIndex = 145;
            this.lblnewpasswordform.Text = "YENİ PAROLA";
            // 
            // FrmNewPassword
            // 
            this.AcceptButton = this.BtnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(636, 314);
            this.Controls.Add(this.lblnewpasswordform);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.ChkConfirmPassword);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.ChkNewPassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewPassword";
            this.Load += new System.EventHandler(this.FrmNewPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.CheckBox ChkConfirmPassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.CheckBox ChkNewPassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblnewpasswordform;
    }
}