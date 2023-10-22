namespace EducationAutomationSystem.Student
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.lblstudentname = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.lblstudenttrno = new System.Windows.Forms.Label();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblstudentsurname = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblstudentnumber = new System.Windows.Forms.Label();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.lblmothername = new System.Windows.Forms.Label();
            this.TxtMotherName = new System.Windows.Forms.TextBox();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblphoto = new System.Windows.Forms.Label();
            this.TxtPicture = new System.Windows.Forms.TextBox();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.PctStudentImage = new System.Windows.Forms.PictureBox();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblstudentregistrationform = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblbirthplace = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MskPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.RchAddress = new System.Windows.Forms.RichTextBox();
            this.lblpostalcode = new System.Windows.Forms.Label();
            this.TxtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblneighborhood = new System.Windows.Forms.Label();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.lbldistrict = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblhomephonenumber = new System.Windows.Forms.Label();
            this.MskHomePhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblStudentCount = new System.Windows.Forms.Label();
            this.lblogrencisayisi = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(7, 71);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(96, 18);
            this.lblstudentname.TabIndex = 3;
            this.lblstudentname.Text = "Öğrenci Adı:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(894, 302);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 23;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // lblstudenttrno
            // 
            this.lblstudenttrno.AutoSize = true;
            this.lblstudenttrno.Location = new System.Drawing.Point(7, 39);
            this.lblstudenttrno.Name = "lblstudenttrno";
            this.lblstudenttrno.Size = new System.Drawing.Size(66, 18);
            this.lblstudenttrno.TabIndex = 6;
            this.lblstudenttrno.Text = "T.C. No:";
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Location = new System.Drawing.Point(145, 36);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(255, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // lblstudentsurname
            // 
            this.lblstudentsurname.AutoSize = true;
            this.lblstudentsurname.Location = new System.Drawing.Point(7, 103);
            this.lblstudentsurname.Name = "lblstudentsurname";
            this.lblstudentsurname.Size = new System.Drawing.Size(119, 18);
            this.lblstudentsurname.TabIndex = 8;
            this.lblstudentsurname.Text = "Öğrenci Soyadı:";
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
            // lblstudentnumber
            // 
            this.lblstudentnumber.AutoSize = true;
            this.lblstudentnumber.Location = new System.Drawing.Point(7, 135);
            this.lblstudentnumber.Name = "lblstudentnumber";
            this.lblstudentnumber.Size = new System.Drawing.Size(120, 18);
            this.lblstudentnumber.TabIndex = 10;
            this.lblstudentnumber.Text = "Okul Numarası:";
            // 
            // MskNumber
            // 
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
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(7, 169);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 13;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Location = new System.Drawing.Point(7, 305);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(76, 18);
            this.lblfathername.TabIndex = 16;
            this.lblfathername.Text = "Baba Adı:";
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
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Location = new System.Drawing.Point(7, 273);
            this.lblmothername.Name = "lblmothername";
            this.lblmothername.Size = new System.Drawing.Size(78, 18);
            this.lblmothername.TabIndex = 14;
            this.lblmothername.Text = "Anne Adı:";
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
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(2, 27);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 18;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(130, 24);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.MskPhoneNumber.TabIndex = 19;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(2, 91);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 20;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(130, 88);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(239, 26);
            this.TxtMail.TabIndex = 21;
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(815, 87);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 22;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(850, 113);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 99;
            this.TxtPicture.Visible = false;
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Location = new System.Drawing.Point(894, 84);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(57, 26);
            this.BtnPicture.TabIndex = 22;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // PctStudentImage
            // 
            this.PctStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctStudentImage.Location = new System.Drawing.Point(957, 84);
            this.PctStudentImage.Name = "PctStudentImage";
            this.PctStudentImage.Size = new System.Drawing.Size(150, 164);
            this.PctStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStudentImage.TabIndex = 25;
            this.PctStudentImage.TabStop = false;
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(7, 336);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 26;
            this.lbldepartment.Text = "Bölüm:";
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
            // lblstudentregistrationform
            // 
            this.lblstudentregistrationform.AutoSize = true;
            this.lblstudentregistrationform.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstudentregistrationform.Location = new System.Drawing.Point(287, 9);
            this.lblstudentregistrationform.Name = "lblstudentregistrationform";
            this.lblstudentregistrationform.Size = new System.Drawing.Size(449, 51);
            this.lblstudentregistrationform.TabIndex = 28;
            this.lblstudentregistrationform.Text = "ÖĞRENCİ KAYIT FORMU";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(894, 382);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1058, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 30;
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
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(7, 235);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 18);
            this.lblgender.TabIndex = 64;
            this.lblgender.Text = "Cinsiyet:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBirthPlace);
            this.groupBox1.Controls.Add(this.lblbirthplace);
            this.groupBox1.Controls.Add(this.MskTRNumber);
            this.groupBox1.Controls.Add(this.RdbFemale);
            this.groupBox1.Controls.Add(this.CmbDepartment);
            this.groupBox1.Controls.Add(this.lblstudenttrno);
            this.groupBox1.Controls.Add(this.lbldepartment);
            this.groupBox1.Controls.Add(this.RdbMale);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.lblstudentsurname);
            this.groupBox1.Controls.Add(this.lblstudentnumber);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.DtpBirthDate);
            this.groupBox1.Controls.Add(this.lblbirthdate);
            this.groupBox1.Controls.Add(this.TxtFatherName);
            this.groupBox1.Controls.Add(this.lblfathername);
            this.groupBox1.Controls.Add(this.TxtMotherName);
            this.groupBox1.Controls.Add(this.lblmothername);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
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
            // lblbirthplace
            // 
            this.lblbirthplace.AutoSize = true;
            this.lblbirthplace.Location = new System.Drawing.Point(7, 200);
            this.lblbirthplace.Name = "lblbirthplace";
            this.lblbirthplace.Size = new System.Drawing.Size(97, 18);
            this.lblbirthplace.TabIndex = 66;
            this.lblbirthplace.Text = "Doğum Yeri:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MskPostalCode);
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.RchAddress);
            this.groupBox2.Controls.Add(this.lblpostalcode);
            this.groupBox2.Controls.Add(this.TxtNeighborhood);
            this.groupBox2.Controls.Add(this.lblneighborhood);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.lbldistrict);
            this.groupBox2.Controls.Add(this.CmbCity);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Location = new System.Drawing.Point(434, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 266);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // MskPostalCode
            // 
            this.MskPostalCode.Location = new System.Drawing.Point(114, 126);
            this.MskPostalCode.Mask = "00000";
            this.MskPostalCode.Name = "MskPostalCode";
            this.MskPostalCode.Size = new System.Drawing.Size(255, 26);
            this.MskPostalCode.TabIndex = 16;
            this.MskPostalCode.ValidatingType = typeof(int);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(2, 159);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Adres:";
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(113, 159);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(256, 97);
            this.RchAddress.TabIndex = 17;
            this.RchAddress.Text = "";
            // 
            // lblpostalcode
            // 
            this.lblpostalcode.AutoSize = true;
            this.lblpostalcode.Location = new System.Drawing.Point(2, 130);
            this.lblpostalcode.Name = "lblpostalcode";
            this.lblpostalcode.Size = new System.Drawing.Size(93, 18);
            this.lblpostalcode.TabIndex = 75;
            this.lblpostalcode.Text = "Posta Kodu:";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNeighborhood.Location = new System.Drawing.Point(114, 95);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(255, 26);
            this.TxtNeighborhood.TabIndex = 15;
            // 
            // lblneighborhood
            // 
            this.lblneighborhood.AutoSize = true;
            this.lblneighborhood.Location = new System.Drawing.Point(2, 99);
            this.lblneighborhood.Name = "lblneighborhood";
            this.lblneighborhood.Size = new System.Drawing.Size(50, 18);
            this.lblneighborhood.TabIndex = 73;
            this.lblneighborhood.Text = "Semt:";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(114, 62);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(255, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(2, 65);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 70;
            this.lbldistrict.Text = "İlçe:";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(114, 30);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(255, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(2, 35);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 68;
            this.lblcity.Text = "İl:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblhomephonenumber);
            this.groupBox3.Controls.Add(this.lblphonenumber);
            this.groupBox3.Controls.Add(this.MskHomePhoneNumber);
            this.groupBox3.Controls.Add(this.MskPhoneNumber);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Controls.Add(this.lblmail);
            this.groupBox3.Location = new System.Drawing.Point(434, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 125);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // lblhomephonenumber
            // 
            this.lblhomephonenumber.AutoSize = true;
            this.lblhomephonenumber.Location = new System.Drawing.Point(2, 59);
            this.lblhomephonenumber.Name = "lblhomephonenumber";
            this.lblhomephonenumber.Size = new System.Drawing.Size(98, 18);
            this.lblhomephonenumber.TabIndex = 69;
            this.lblhomephonenumber.Text = "Ev Telefonu:";
            // 
            // MskHomePhoneNumber
            // 
            this.MskHomePhoneNumber.Location = new System.Drawing.Point(130, 56);
            this.MskHomePhoneNumber.Mask = "(999) 000-0000";
            this.MskHomePhoneNumber.Name = "MskHomePhoneNumber";
            this.MskHomePhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.MskHomePhoneNumber.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(153, 458);
            this.LblStudentCount.Name = "LblStudentCount";
            this.LblStudentCount.Size = new System.Drawing.Size(22, 23);
            this.LblStudentCount.TabIndex = 117;
            this.LblStudentCount.Text = "0";
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(12, 458);
            this.lblogrencisayisi.Name = "lblogrencisayisi";
            this.lblogrencisayisi.Size = new System.Drawing.Size(138, 23);
            this.lblogrencisayisi.TabIndex = 116;
            this.lblogrencisayisi.Text = "Öğrenci Sayısı:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(321, 462);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 118;
            this.TxtID.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(397, 478);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 23);
            this.label22.TabIndex = 119;
            this.label22.Text = "label22";
            this.label22.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmAddStudent
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1119, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblStudentCount);
            this.Controls.Add(this.lblogrencisayisi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.lblstudentregistrationform);
            this.Controls.Add(this.PctStudentImage);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.TxtPicture);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStudent";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label lblstudenttrno;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.Label lblstudentsurname;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label lblstudentnumber;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.TextBox TxtFatherName;
        private System.Windows.Forms.Label lblmothername;
        private System.Windows.Forms.TextBox TxtMotherName;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.PictureBox PctStudentImage;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label lblstudentregistrationform;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBirthPlace;
        private System.Windows.Forms.Label lblbirthplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblpostalcode;
        private System.Windows.Forms.TextBox TxtNeighborhood;
        private System.Windows.Forms.Label lblneighborhood;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.Label lbldistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.RichTextBox RchAddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblhomephonenumber;
        private System.Windows.Forms.MaskedTextBox MskHomePhoneNumber;
        private System.Windows.Forms.MaskedTextBox MskPostalCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.Label lblogrencisayisi;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
    }
}