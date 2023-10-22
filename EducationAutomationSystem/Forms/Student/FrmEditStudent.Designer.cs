﻿namespace EducationAutomationSystem.Student
{
    partial class FrmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditStudent));
            this.MskPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblbirthplace = new System.Windows.Forms.Label();
            this.lblstudenttrno = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentsurname = new System.Windows.Forms.Label();
            this.lblstudentnumber = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lblmothername = new System.Windows.Forms.Label();
            this.TxtBirthPlace = new System.Windows.Forms.TextBox();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.TxtMotherName = new System.Windows.Forms.TextBox();
            this.RchAddress = new System.Windows.Forms.RichTextBox();
            this.TxtNeighborhood = new System.Windows.Forms.TextBox();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblpostalcode = new System.Windows.Forms.Label();
            this.lblneighborhood = new System.Windows.Forms.Label();
            this.lbldistrict = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblhomephonenumber = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.MskHomePhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblogrenciduzenlemeformu = new System.Windows.Forms.Label();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.TxtPicture = new System.Windows.Forms.TextBox();
            this.PctStudentImage = new System.Windows.Forms.PictureBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblStudentCount = new System.Windows.Forms.Label();
            this.DtgStudent = new System.Windows.Forms.DataGridView();
            this.lblogrencisayisi = new System.Windows.Forms.Label();
            this.lblphoto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // MskPostalCode
            // 
            this.MskPostalCode.Location = new System.Drawing.Point(134, 126);
            this.MskPostalCode.Mask = "00000";
            this.MskPostalCode.Name = "MskPostalCode";
            this.MskPostalCode.Size = new System.Drawing.Size(239, 26);
            this.MskPostalCode.TabIndex = 16;
            this.MskPostalCode.ValidatingType = typeof(int);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1060, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 109;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // RdbFemale
            // 
            this.RdbFemale.AutoSize = true;
            this.RdbFemale.Location = new System.Drawing.Point(227, 235);
            this.RdbFemale.Name = "RdbFemale";
            this.RdbFemale.Size = new System.Drawing.Size(67, 22);
            this.RdbFemale.TabIndex = 8;
            this.RdbFemale.TabStop = true;
            this.RdbFemale.Text = "Kadın";
            this.RdbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblbirthplace);
            this.groupBox1.Controls.Add(this.lblstudenttrno);
            this.groupBox1.Controls.Add(this.lbldepartment);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.lblstudentsurname);
            this.groupBox1.Controls.Add(this.lblstudentnumber);
            this.groupBox1.Controls.Add(this.lblbirthdate);
            this.groupBox1.Controls.Add(this.lblfathername);
            this.groupBox1.Controls.Add(this.lblmothername);
            this.groupBox1.Controls.Add(this.TxtBirthPlace);
            this.groupBox1.Controls.Add(this.MskTRNumber);
            this.groupBox1.Controls.Add(this.RdbFemale);
            this.groupBox1.Controls.Add(this.CmbDepartment);
            this.groupBox1.Controls.Add(this.RdbMale);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.DtpBirthDate);
            this.groupBox1.Controls.Add(this.TxtFatherName);
            this.groupBox1.Controls.Add(this.TxtMotherName);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 371);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // lblbirthplace
            // 
            this.lblbirthplace.AutoSize = true;
            this.lblbirthplace.Location = new System.Drawing.Point(5, 200);
            this.lblbirthplace.Name = "lblbirthplace";
            this.lblbirthplace.Size = new System.Drawing.Size(97, 18);
            this.lblbirthplace.TabIndex = 86;
            this.lblbirthplace.Text = "Doğum Yeri:";
            // 
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(5, 39);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 78;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(5, 336);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 84;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(5, 235);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 18);
            this.lblgender.TabIndex = 85;
            this.lblgender.Text = "Cinsiyet:";
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(5, 71);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 77;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(5, 103);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 79;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
            // 
            // lblstudentnumber
            // 
            this.lblstudentnumber.AutoSize = true;
            this.lblstudentnumber.Location = new System.Drawing.Point(5, 135);
            this.lblstudentnumber.Name = "lblstudentnumber";
            this.lblstudentnumber.Size = new System.Drawing.Size(120, 18);
            this.lblstudentnumber.TabIndex = 80;
            this.lblstudentnumber.Text = "Okul Numarası:";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(5, 169);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 81;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Location = new System.Drawing.Point(5, 305);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(76, 18);
            this.lblfathername.TabIndex = 83;
            this.lblfathername.Text = "Baba Adı:";
            // 
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Location = new System.Drawing.Point(5, 273);
            this.lblmothername.Name = "lblmothername";
            this.lblmothername.Size = new System.Drawing.Size(78, 18);
            this.lblmothername.TabIndex = 82;
            this.lblmothername.Text = "Anne Adı:";
            // 
            // TxtBirthPlace
            // 
            this.TxtBirthPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBirthPlace.Location = new System.Drawing.Point(145, 197);
            this.TxtBirthPlace.Name = "TxtBirthPlace";
            this.TxtBirthPlace.Size = new System.Drawing.Size(255, 26);
            this.TxtBirthPlace.TabIndex = 6;
            this.TxtBirthPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirthPlace_KeyPress);
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Enabled = false;
            this.MskTRNumber.Location = new System.Drawing.Point(145, 36);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(255, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(145, 333);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(255, 26);
            this.CmbDepartment.TabIndex = 11;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(146, 235);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(69, 22);
            this.RdbMale.TabIndex = 7;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "Erkek";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentName.Location = new System.Drawing.Point(145, 68);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(255, 26);
            this.TxtStudentName.TabIndex = 2;
            this.TxtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentName_KeyPress);
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStudentSurname.Location = new System.Drawing.Point(145, 100);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(255, 26);
            this.TxtStudentSurname.TabIndex = 3;
            this.TxtStudentSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentSurname_KeyPress);
            // 
            // MskNumber
            // 
            this.MskNumber.Enabled = false;
            this.MskNumber.Location = new System.Drawing.Point(145, 132);
            this.MskNumber.Mask = "00000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(255, 26);
            this.MskNumber.TabIndex = 4;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(145, 165);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(255, 26);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFatherName.Location = new System.Drawing.Point(145, 300);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.Size = new System.Drawing.Size(255, 26);
            this.TxtFatherName.TabIndex = 10;
            this.TxtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFatherName_KeyPress);
            // 
            // TxtMotherName
            // 
            this.TxtMotherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMotherName.Location = new System.Drawing.Point(145, 268);
            this.TxtMotherName.Name = "TxtMotherName";
            this.TxtMotherName.Size = new System.Drawing.Size(255, 26);
            this.TxtMotherName.TabIndex = 9;
            this.TxtMotherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMotherName_KeyPress);
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(133, 159);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(240, 116);
            this.RchAddress.TabIndex = 17;
            this.RchAddress.Text = "";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNeighborhood.Location = new System.Drawing.Point(134, 95);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(239, 26);
            this.TxtNeighborhood.TabIndex = 15;
            this.TxtNeighborhood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNeighborhood_KeyPress);
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(134, 62);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(239, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.lblpostalcode);
            this.groupBox2.Controls.Add(this.lblneighborhood);
            this.groupBox2.Controls.Add(this.lbldistrict);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Controls.Add(this.MskPostalCode);
            this.groupBox2.Controls.Add(this.RchAddress);
            this.groupBox2.Controls.Add(this.TxtNeighborhood);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.CmbCity);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(429, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 281);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(6, 159);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 82;
            this.lbladdress.Text = "Adres:";
            // 
            // lblpostalcode
            // 
            this.lblpostalcode.AutoSize = true;
            this.lblpostalcode.Location = new System.Drawing.Point(6, 130);
            this.lblpostalcode.Name = "lblpostalcode";
            this.lblpostalcode.Size = new System.Drawing.Size(93, 18);
            this.lblpostalcode.TabIndex = 85;
            this.lblpostalcode.Text = "Posta Kodu:";
            // 
            // lblneighborhood
            // 
            this.lblneighborhood.AutoSize = true;
            this.lblneighborhood.Location = new System.Drawing.Point(6, 99);
            this.lblneighborhood.Name = "lblneighborhood";
            this.lblneighborhood.Size = new System.Drawing.Size(50, 18);
            this.lblneighborhood.TabIndex = 84;
            this.lblneighborhood.Text = "Semt:";
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(6, 65);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 83;
            this.lbldistrict.Text = "İlçe:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(6, 35);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 81;
            this.lblcity.Text = "İl:";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(134, 30);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(239, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblhomephonenumber);
            this.groupBox3.Controls.Add(this.lblphonenumber);
            this.groupBox3.Controls.Add(this.lblmail);
            this.groupBox3.Controls.Add(this.MskHomePhoneNumber);
            this.groupBox3.Controls.Add(this.MskPhoneNumber);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(429, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 125);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // lblhomephonenumber
            // 
            this.lblhomephonenumber.AutoSize = true;
            this.lblhomephonenumber.Location = new System.Drawing.Point(5, 59);
            this.lblhomephonenumber.Name = "lblhomephonenumber";
            this.lblhomephonenumber.Size = new System.Drawing.Size(98, 18);
            this.lblhomephonenumber.TabIndex = 75;
            this.lblhomephonenumber.Text = "Ev Telefonu:";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(5, 27);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 73;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(5, 91);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 74;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // MskHomePhoneNumber
            // 
            this.MskHomePhoneNumber.Location = new System.Drawing.Point(133, 56);
            this.MskHomePhoneNumber.Mask = "(999) 000-0000";
            this.MskHomePhoneNumber.Name = "MskHomePhoneNumber";
            this.MskHomePhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.MskHomePhoneNumber.TabIndex = 20;
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(133, 24);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.MskPhoneNumber.TabIndex = 19;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(133, 88);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(239, 26);
            this.TxtMail.TabIndex = 21;
            // 
            // lblogrenciduzenlemeformu
            // 
            this.lblogrenciduzenlemeformu.AutoSize = true;
            this.lblogrenciduzenlemeformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrenciduzenlemeformu.Location = new System.Drawing.Point(279, 9);
            this.lblogrenciduzenlemeformu.Name = "lblogrenciduzenlemeformu";
            this.lblogrenciduzenlemeformu.Size = new System.Drawing.Size(573, 51);
            this.lblogrenciduzenlemeformu.TabIndex = 108;
            this.lblogrenciduzenlemeformu.Text = "ÖĞRENCİ DÜZENLEME FORMU";
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.Enabled = false;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Location = new System.Drawing.Point(896, 71);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(57, 26);
            this.BtnPicture.TabIndex = 103;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(845, 100);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 110;
            this.TxtPicture.Visible = false;
            // 
            // PctStudentImage
            // 
            this.PctStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctStudentImage.Location = new System.Drawing.Point(959, 71);
            this.PctStudentImage.Name = "PctStudentImage";
            this.PctStudentImage.Size = new System.Drawing.Size(150, 164);
            this.PctStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStudentImage.TabIndex = 107;
            this.PctStudentImage.TabStop = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(277, 460);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 115;
            this.TxtID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(898, 392);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 119;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(898, 312);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 118;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(150, 443);
            this.LblStudentCount.Name = "LblStudentCount";
            this.LblStudentCount.Size = new System.Drawing.Size(22, 23);
            this.LblStudentCount.TabIndex = 121;
            this.LblStudentCount.Text = "0";
            // 
            // DtgStudent
            // 
            this.DtgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudent.Location = new System.Drawing.Point(0, 494);
            this.DtgStudent.Name = "DtgStudent";
            this.DtgStudent.Size = new System.Drawing.Size(1119, 203);
            this.DtgStudent.TabIndex = 122;
            this.DtgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgStudent_CellClick);
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(6, 443);
            this.lblogrencisayisi.Name = "lblogrencisayisi";
            this.lblogrencisayisi.Size = new System.Drawing.Size(138, 23);
            this.lblogrencisayisi.TabIndex = 123;
            this.lblogrencisayisi.Text = "Öğrenci Sayısı:";
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(812, 75);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 135;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmEditStudent
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1119, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.lblogrencisayisi);
            this.Controls.Add(this.DtgStudent);
            this.Controls.Add(this.LblStudentCount);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblogrenciduzenlemeformu);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.TxtPicture);
            this.Controls.Add(this.PctStudentImage);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStudent";
            this.Load += new System.EventHandler(this.FrmEditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBirthPlace;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.TextBox TxtFatherName;
        private System.Windows.Forms.TextBox TxtMotherName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskPostalCode;
        private System.Windows.Forms.RichTextBox RchAddress;
        private System.Windows.Forms.TextBox TxtNeighborhood;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskHomePhoneNumber;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblogrenciduzenlemeformu;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.PictureBox PctStudentImage;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.DataGridView DtgStudent;
        private System.Windows.Forms.Label lblbirthplace;
        private System.Windows.Forms.Label lblstudenttrno;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentsurname;
        private System.Windows.Forms.Label lblstudentnumber;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lblmothername;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblpostalcode;
        private System.Windows.Forms.Label lblneighborhood;
        private System.Windows.Forms.Label lbldistrict;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblhomephonenumber;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblogrencisayisi;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.Label label1;
    }
}