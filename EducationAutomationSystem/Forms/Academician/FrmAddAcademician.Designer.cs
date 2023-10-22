namespace EducationAutomationSystem.Academician
{
    partial class FrmAddAcademician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAcademician));
            this.lblakademisyensayisi = new System.Windows.Forms.Label();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChkConfirmPassword = new System.Windows.Forms.CheckBox();
            this.ChkPassword = new System.Windows.Forms.CheckBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblakademisyentcno = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.TxtAcademicianName = new System.Windows.Forms.TextBox();
            this.lblakademisyenadi = new System.Windows.Forms.Label();
            this.TxtAcademicianSurname = new System.Windows.Forms.TextBox();
            this.lblakademisyensoyadi = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.RchAddress = new System.Windows.Forms.RichTextBox();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.lbldistrict = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblAcademicianCount = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblakademisyenkayitformu = new System.Windows.Forms.Label();
            this.PctAcademicianImage = new System.Windows.Forms.PictureBox();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.lblphoto = new System.Windows.Forms.Label();
            this.TxtPicture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademicianImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblakademisyensayisi
            // 
            this.lblakademisyensayisi.AutoSize = true;
            this.lblakademisyensayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyensayisi.Location = new System.Drawing.Point(12, 377);
            this.lblakademisyensayisi.Name = "lblakademisyensayisi";
            this.lblakademisyensayisi.Size = new System.Drawing.Size(184, 23);
            this.lblakademisyensayisi.TabIndex = 131;
            this.lblakademisyensayisi.Text = "Akademisyen Sayısı:";
            // 
            // RdbFemale
            // 
            this.RdbFemale.AutoSize = true;
            this.RdbFemale.Location = new System.Drawing.Point(248, 167);
            this.RdbFemale.Name = "RdbFemale";
            this.RdbFemale.Size = new System.Drawing.Size(67, 22);
            this.RdbFemale.TabIndex = 8;
            this.RdbFemale.TabStop = true;
            this.RdbFemale.Text = "Kadın";
            this.RdbFemale.UseVisualStyleBackColor = true;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(167, 167);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(69, 22);
            this.RdbMale.TabIndex = 7;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "Erkek";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(4, 167);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 18);
            this.lblgender.TabIndex = 64;
            this.lblgender.Text = "Cinsiyet:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChkConfirmPassword);
            this.groupBox4.Controls.Add(this.ChkPassword);
            this.groupBox4.Controls.Add(this.TxtConfirmPassword);
            this.groupBox4.Controls.Add(this.lblconfirmpassword);
            this.groupBox4.Controls.Add(this.TxtPassword);
            this.groupBox4.Controls.Add(this.lblpassword);
            this.groupBox4.Controls.Add(this.MskTRNumber);
            this.groupBox4.Controls.Add(this.RdbFemale);
            this.groupBox4.Controls.Add(this.CmbDepartment);
            this.groupBox4.Controls.Add(this.lblakademisyentcno);
            this.groupBox4.Controls.Add(this.lbldepartment);
            this.groupBox4.Controls.Add(this.RdbMale);
            this.groupBox4.Controls.Add(this.TxtAcademicianName);
            this.groupBox4.Controls.Add(this.lblgender);
            this.groupBox4.Controls.Add(this.lblakademisyenadi);
            this.groupBox4.Controls.Add(this.TxtAcademicianSurname);
            this.groupBox4.Controls.Add(this.lblakademisyensoyadi);
            this.groupBox4.Controls.Add(this.DtpBirthDate);
            this.groupBox4.Controls.Add(this.lblbirthdate);
            this.groupBox4.Location = new System.Drawing.Point(12, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 295);
            this.groupBox4.TabIndex = 119;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Akademisyen Bilgileri";
            // 
            // ChkConfirmPassword
            // 
            this.ChkConfirmPassword.AutoSize = true;
            this.ChkConfirmPassword.Location = new System.Drawing.Point(297, 229);
            this.ChkConfirmPassword.Name = "ChkConfirmPassword";
            this.ChkConfirmPassword.Size = new System.Drawing.Size(75, 22);
            this.ChkConfirmPassword.TabIndex = 71;
            this.ChkConfirmPassword.Text = "Göster";
            this.ChkConfirmPassword.UseVisualStyleBackColor = true;
            this.ChkConfirmPassword.CheckedChanged += new System.EventHandler(this.ChkConfirmPassword_CheckedChanged);
            // 
            // ChkPassword
            // 
            this.ChkPassword.AutoSize = true;
            this.ChkPassword.Location = new System.Drawing.Point(297, 196);
            this.ChkPassword.Name = "ChkPassword";
            this.ChkPassword.Size = new System.Drawing.Size(75, 22);
            this.ChkPassword.TabIndex = 70;
            this.ChkPassword.Text = "Göster";
            this.ChkPassword.UseVisualStyleBackColor = true;
            this.ChkPassword.CheckedChanged += new System.EventHandler(this.ChkPassword_CheckedChanged);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(167, 227);
            this.TxtConfirmPassword.MaxLength = 10;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(124, 26);
            this.TxtConfirmPassword.TabIndex = 69;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(4, 230);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(112, 18);
            this.lblconfirmpassword.TabIndex = 68;
            this.lblconfirmpassword.Text = "Parola Tekrar:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(167, 195);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(124, 26);
            this.TxtPassword.TabIndex = 67;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(4, 198);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(58, 18);
            this.lblpassword.TabIndex = 66;
            this.lblpassword.Text = "Parola:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(167, 36);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(240, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(167, 259);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(240, 26);
            this.CmbDepartment.TabIndex = 11;
            // 
            // lblakademisyentcno
            // 
            this.lblakademisyentcno.AutoSize = true;
            this.lblakademisyentcno.Location = new System.Drawing.Point(4, 39);
            this.lblakademisyentcno.Name = "lblakademisyentcno";
            this.lblakademisyentcno.Size = new System.Drawing.Size(66, 18);
            this.lblakademisyentcno.TabIndex = 6;
            this.lblakademisyentcno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(4, 262);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 26;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // TxtAcademicianName
            // 
            this.TxtAcademicianName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAcademicianName.Location = new System.Drawing.Point(167, 68);
            this.TxtAcademicianName.Name = "TxtAcademicianName";
            this.TxtAcademicianName.Size = new System.Drawing.Size(240, 26);
            this.TxtAcademicianName.TabIndex = 2;
            this.TxtAcademicianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcademicianName_KeyPress);
            // 
            // lblakademisyenadi
            // 
            this.lblakademisyenadi.AutoSize = true;
            this.lblakademisyenadi.Location = new System.Drawing.Point(4, 71);
            this.lblakademisyenadi.Name = "lblakademisyenadi";
            this.lblakademisyenadi.Size = new System.Drawing.Size(37, 18);
            this.lblakademisyenadi.TabIndex = 3;
            this.lblakademisyenadi.Text = "Adı:";
            // 
            // TxtAcademicianSurname
            // 
            this.TxtAcademicianSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAcademicianSurname.Location = new System.Drawing.Point(167, 100);
            this.TxtAcademicianSurname.Name = "TxtAcademicianSurname";
            this.TxtAcademicianSurname.Size = new System.Drawing.Size(240, 26);
            this.TxtAcademicianSurname.TabIndex = 3;
            this.TxtAcademicianSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcademicianSurname_KeyPress);
            // 
            // lblakademisyensoyadi
            // 
            this.lblakademisyensoyadi.AutoSize = true;
            this.lblakademisyensoyadi.Location = new System.Drawing.Point(4, 103);
            this.lblakademisyensoyadi.Name = "lblakademisyensoyadi";
            this.lblakademisyensoyadi.Size = new System.Drawing.Size(60, 18);
            this.lblakademisyensoyadi.TabIndex = 8;
            this.lblakademisyensoyadi.Text = "Soyadı:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(167, 132);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(240, 26);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(4, 136);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 13;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.RchAddress);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.lbldistrict);
            this.groupBox2.Controls.Add(this.CmbCity);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Location = new System.Drawing.Point(434, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 202);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(5, 94);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Adres:";
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(117, 94);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(233, 97);
            this.RchAddress.TabIndex = 17;
            this.RchAddress.Text = "";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(117, 62);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(232, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(5, 65);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 70;
            this.lbldistrict.Text = "İlçe:";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(117, 30);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(232, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(5, 35);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 68;
            this.lblcity.Text = "İl:";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1053, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 128;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblphonenumber);
            this.groupBox3.Controls.Add(this.MskPhoneNumber);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Controls.Add(this.lblmail);
            this.groupBox3.Location = new System.Drawing.Point(434, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 109);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(5, 37);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 18;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(150, 34);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(199, 26);
            this.MskPhoneNumber.TabIndex = 19;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(150, 66);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(199, 26);
            this.TxtMail.TabIndex = 21;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(5, 69);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 20;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblAcademicianCount
            // 
            this.LblAcademicianCount.AutoSize = true;
            this.LblAcademicianCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAcademicianCount.Location = new System.Drawing.Point(202, 377);
            this.LblAcademicianCount.Name = "LblAcademicianCount";
            this.LblAcademicianCount.Size = new System.Drawing.Size(22, 23);
            this.LblAcademicianCount.TabIndex = 132;
            this.LblAcademicianCount.Text = "0";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(-46, 429);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 133;
            this.TxtID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(890, 356);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 125;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(890, 276);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 124;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblakademisyenkayitformu
            // 
            this.lblakademisyenkayitformu.AutoSize = true;
            this.lblakademisyenkayitformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyenkayitformu.Location = new System.Drawing.Point(241, 8);
            this.lblakademisyenkayitformu.Name = "lblakademisyenkayitformu";
            this.lblakademisyenkayitformu.Size = new System.Drawing.Size(550, 51);
            this.lblakademisyenkayitformu.TabIndex = 127;
            this.lblakademisyenkayitformu.Text = "AKADEMİSYEN KAYIT FORMU";
            // 
            // PctAcademicianImage
            // 
            this.PctAcademicianImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAcademicianImage.Location = new System.Drawing.Point(953, 76);
            this.PctAcademicianImage.Name = "PctAcademicianImage";
            this.PctAcademicianImage.Size = new System.Drawing.Size(150, 164);
            this.PctAcademicianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAcademicianImage.TabIndex = 126;
            this.PctAcademicianImage.TabStop = false;
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Location = new System.Drawing.Point(890, 80);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(57, 26);
            this.BtnPicture.TabIndex = 122;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(811, 83);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 123;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(846, 109);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 129;
            this.TxtPicture.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmAddAcademician
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1113, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblakademisyensayisi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblAcademicianCount);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.lblakademisyenkayitformu);
            this.Controls.Add(this.PctAcademicianImage);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.TxtPicture);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddAcademician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddAcademician";
            this.Load += new System.EventHandler(this.FrmAddAcademician_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademicianImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblakademisyensayisi;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label lblakademisyentcno;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.TextBox TxtAcademicianName;
        private System.Windows.Forms.Label lblakademisyenadi;
        private System.Windows.Forms.TextBox TxtAcademicianSurname;
        private System.Windows.Forms.Label lblakademisyensoyadi;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.RichTextBox RchAddress;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.Label lbldistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblAcademicianCount;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblakademisyenkayitformu;
        private System.Windows.Forms.PictureBox PctAcademicianImage;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.CheckBox ChkConfirmPassword;
        private System.Windows.Forms.CheckBox ChkPassword;
        private System.Windows.Forms.Label label1;
    }
}