namespace EducationAutomationSystem.Forms.Student
{
    partial class FrmStudentNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentNotes));
            this.DtgStudentNotes = new System.Windows.Forms.DataGridView();
            this.PctExit = new System.Windows.Forms.PictureBox();
            this.lblnotlarim = new System.Windows.Forms.Label();
            this.lblogrencino = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblbirthplace = new System.Windows.Forms.Label();
            this.lblstudenttrno = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentsurname = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.TxtBirthPlace = new System.Windows.Forms.TextBox();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudentNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgStudentNotes
            // 
            this.DtgStudentNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudentNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudentNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgStudentNotes.Location = new System.Drawing.Point(3, 22);
            this.DtgStudentNotes.Name = "DtgStudentNotes";
            this.DtgStudentNotes.Size = new System.Drawing.Size(474, 306);
            this.DtgStudentNotes.TabIndex = 0;
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(841, 1);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 38;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // lblnotlarim
            // 
            this.lblnotlarim.AutoSize = true;
            this.lblnotlarim.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnotlarim.Location = new System.Drawing.Point(338, 6);
            this.lblnotlarim.Name = "lblnotlarim";
            this.lblnotlarim.Size = new System.Drawing.Size(216, 51);
            this.lblnotlarim.TabIndex = 40;
            this.lblnotlarim.Text = "NOTLARIM";
            // 
            // lblogrencino
            // 
            this.lblogrencino.AutoSize = true;
            this.lblogrencino.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencino.Location = new System.Drawing.Point(12, 26);
            this.lblogrencino.Name = "lblogrencino";
            this.lblogrencino.Size = new System.Drawing.Size(71, 18);
            this.lblogrencino.TabIndex = 51;
            this.lblogrencino.Text = "Numara:";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNumber.Location = new System.Drawing.Point(153, 26);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(49, 18);
            this.LblNumber.TabIndex = 50;
            this.LblNumber.Text = "label1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DtgStudentNotes);
            this.groupBox5.Location = new System.Drawing.Point(-3, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 331);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Not Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.TxtDepartment);
            this.groupBox1.Controls.Add(this.lblcinsiyet);
            this.groupBox1.Controls.Add(this.lblmail);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.lblphonenumber);
            this.groupBox1.Controls.Add(this.MskPhoneNumber);
            this.groupBox1.Controls.Add(this.lblbirthplace);
            this.groupBox1.Controls.Add(this.lblstudenttrno);
            this.groupBox1.Controls.Add(this.lbldepartment);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.lblstudentsurname);
            this.groupBox1.Controls.Add(this.lblbirthdate);
            this.groupBox1.Controls.Add(this.TxtBirthPlace);
            this.groupBox1.Controls.Add(this.MskTRNumber);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.DtpBirthDate);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(483, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 331);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(142, 203);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(49, 18);
            this.lblcinsiyet.TabIndex = 81;
            this.lblcinsiyet.Text = "label1";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(6, 297);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 80;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(145, 294);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(255, 26);
            this.TxtMail.TabIndex = 79;
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(6, 265);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 78;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(145, 262);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(255, 26);
            this.MskPhoneNumber.TabIndex = 77;
            // 
            // lblbirthplace
            // 
            this.lblbirthplace.AutoSize = true;
            this.lblbirthplace.Location = new System.Drawing.Point(6, 168);
            this.lblbirthplace.Name = "lblbirthplace";
            this.lblbirthplace.Size = new System.Drawing.Size(97, 18);
            this.lblbirthplace.TabIndex = 76;
            this.lblbirthplace.Text = "Doğum Yeri:";
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(6, 40);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 68;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(6, 234);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 74;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(6, 203);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 18);
            this.lblgender.TabIndex = 75;
            this.lblgender.Text = "Cinsiyet:";
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(6, 72);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 67;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(6, 104);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 69;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(6, 137);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 71;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // TxtBirthPlace
            // 
            this.TxtBirthPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBirthPlace.Location = new System.Drawing.Point(145, 164);
            this.TxtBirthPlace.Name = "TxtBirthPlace";
            this.TxtBirthPlace.Size = new System.Drawing.Size(255, 26);
            this.TxtBirthPlace.TabIndex = 6;
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(145, 36);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(255, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentName.Location = new System.Drawing.Point(145, 68);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(255, 26);
            this.TxtStudentName.TabIndex = 2;
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentSurname.Location = new System.Drawing.Point(145, 100);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(255, 26);
            this.TxtStudentSurname.TabIndex = 3;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(145, 132);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(255, 26);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDepartment.Location = new System.Drawing.Point(145, 230);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(255, 26);
            this.TxtDepartment.TabIndex = 82;
            // 
            // FrmStudentNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(901, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblogrencino);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.lblnotlarim);
            this.Controls.Add(this.PctExit);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentNotes";
            this.Load += new System.EventHandler(this.FrmStudentNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudentNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgStudentNotes;
        private System.Windows.Forms.PictureBox PctExit;
        private System.Windows.Forms.Label lblnotlarim;
        private System.Windows.Forms.Label lblogrencino;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblbirthplace;
        private System.Windows.Forms.Label lblstudenttrno;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentsurname;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.TextBox TxtBirthPlace;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.TextBox TxtDepartment;
    }
}