namespace EducationAutomationSystem.Academician
{
    partial class FrmEditAcademician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAcademician));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbldistrict = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.RchAddress = new System.Windows.Forms.RichTextBox();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.LblAcademicianCount = new System.Windows.Forms.Label();
            this.DtgAcademician = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.lblakademisyenduzenlemeformu = new System.Windows.Forms.Label();
            this.PctAcademicianImage = new System.Windows.Forms.PictureBox();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.TxtPicture = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblakademisyentcno = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblakademisyenadi = new System.Windows.Forms.Label();
            this.lblakademisyensoyadi = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.ChkConfirmPassword = new System.Windows.Forms.CheckBox();
            this.ChkPassword = new System.Windows.Forms.CheckBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTRNumber = new System.Windows.Forms.MaskedTextBox();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.TxtAcademicianName = new System.Windows.Forms.TextBox();
            this.TxtAcademicianSurname = new System.Windows.Forms.TextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblakademisyensayisi = new System.Windows.Forms.Label();
            this.lblphoto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademicianImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(1052, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 143;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblphonenumber);
            this.groupBox3.Controls.Add(this.lblmail);
            this.groupBox3.Controls.Add(this.MskPhoneNumber);
            this.groupBox3.Controls.Add(this.TxtMail);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(434, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 109);
            this.groupBox3.TabIndex = 136;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(6, 36);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(106, 18);
            this.lblphonenumber.TabIndex = 22;
            this.lblphonenumber.Text = "Cep Telefonu:";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(6, 68);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(94, 18);
            this.lblmail.TabIndex = 23;
            this.lblmail.Text = "Mail Adresi:";
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.Location = new System.Drawing.Point(145, 33);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(214, 26);
            this.MskPhoneNumber.TabIndex = 19;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(145, 65);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(214, 26);
            this.TxtMail.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.lbldistrict);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Controls.Add(this.RchAddress);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.CmbCity);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(434, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 202);
            this.groupBox2.TabIndex = 135;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(6, 92);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 18);
            this.lbladdress.TabIndex = 72;
            this.lbladdress.Text = "Adres:";
            // 
            // lbldistrict
            // 
            this.lbldistrict.AutoSize = true;
            this.lbldistrict.Location = new System.Drawing.Point(6, 63);
            this.lbldistrict.Name = "lbldistrict";
            this.lbldistrict.Size = new System.Drawing.Size(39, 18);
            this.lbldistrict.TabIndex = 73;
            this.lbldistrict.Text = "İlçe:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(6, 33);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 18);
            this.lblcity.TabIndex = 71;
            this.lblcity.Text = "İl:";
            // 
            // RchAddress
            // 
            this.RchAddress.Location = new System.Drawing.Point(131, 94);
            this.RchAddress.Name = "RchAddress";
            this.RchAddress.Size = new System.Drawing.Size(229, 97);
            this.RchAddress.TabIndex = 17;
            this.RchAddress.Text = "";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(131, 62);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(228, 26);
            this.CmbDistrict.TabIndex = 14;
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(131, 30);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(228, 26);
            this.CmbCity.TabIndex = 13;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // LblAcademicianCount
            // 
            this.LblAcademicianCount.AutoSize = true;
            this.LblAcademicianCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAcademicianCount.Location = new System.Drawing.Point(201, 377);
            this.LblAcademicianCount.Name = "LblAcademicianCount";
            this.LblAcademicianCount.Size = new System.Drawing.Size(22, 23);
            this.LblAcademicianCount.TabIndex = 147;
            this.LblAcademicianCount.Text = "0";
            // 
            // DtgAcademician
            // 
            this.DtgAcademician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgAcademician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAcademician.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgAcademician.Location = new System.Drawing.Point(0, 433);
            this.DtgAcademician.Name = "DtgAcademician";
            this.DtgAcademician.Size = new System.Drawing.Size(1113, 191);
            this.DtgAcademician.TabIndex = 145;
            this.DtgAcademician.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAcademician_CellClick);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(-47, 429);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 26);
            this.TxtID.TabIndex = 148;
            this.TxtID.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(889, 356);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 140;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(889, 276);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 139;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblakademisyenduzenlemeformu
            // 
            this.lblakademisyenduzenlemeformu.AutoSize = true;
            this.lblakademisyenduzenlemeformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyenduzenlemeformu.Location = new System.Drawing.Point(218, 8);
            this.lblakademisyenduzenlemeformu.Name = "lblakademisyenduzenlemeformu";
            this.lblakademisyenduzenlemeformu.Size = new System.Drawing.Size(674, 51);
            this.lblakademisyenduzenlemeformu.TabIndex = 142;
            this.lblakademisyenduzenlemeformu.Text = "AKADEMİSYEN DÜZENLEME FORMU";
            // 
            // PctAcademicianImage
            // 
            this.PctAcademicianImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAcademicianImage.Location = new System.Drawing.Point(952, 76);
            this.PctAcademicianImage.Name = "PctAcademicianImage";
            this.PctAcademicianImage.Size = new System.Drawing.Size(150, 164);
            this.PctAcademicianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAcademicianImage.TabIndex = 141;
            this.PctAcademicianImage.TabStop = false;
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.Enabled = false;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Location = new System.Drawing.Point(889, 80);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(57, 26);
            this.BtnPicture.TabIndex = 137;
            this.BtnPicture.Text = "...";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // TxtPicture
            // 
            this.TxtPicture.Location = new System.Drawing.Point(845, 109);
            this.TxtPicture.Name = "TxtPicture";
            this.TxtPicture.Size = new System.Drawing.Size(40, 26);
            this.TxtPicture.TabIndex = 144;
            this.TxtPicture.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblconfirmpassword);
            this.groupBox4.Controls.Add(this.lblpassword);
            this.groupBox4.Controls.Add(this.lblakademisyentcno);
            this.groupBox4.Controls.Add(this.lbldepartment);
            this.groupBox4.Controls.Add(this.lblgender);
            this.groupBox4.Controls.Add(this.lblakademisyenadi);
            this.groupBox4.Controls.Add(this.lblakademisyensoyadi);
            this.groupBox4.Controls.Add(this.lblbirthdate);
            this.groupBox4.Controls.Add(this.ChkConfirmPassword);
            this.groupBox4.Controls.Add(this.ChkPassword);
            this.groupBox4.Controls.Add(this.TxtConfirmPassword);
            this.groupBox4.Controls.Add(this.TxtPassword);
            this.groupBox4.Controls.Add(this.MskTRNumber);
            this.groupBox4.Controls.Add(this.RdbFemale);
            this.groupBox4.Controls.Add(this.CmbDepartment);
            this.groupBox4.Controls.Add(this.RdbMale);
            this.groupBox4.Controls.Add(this.TxtAcademicianName);
            this.groupBox4.Controls.Add(this.TxtAcademicianSurname);
            this.groupBox4.Controls.Add(this.DtpBirthDate);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(11, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 295);
            this.groupBox4.TabIndex = 134;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Akademisyen Bilgileri";
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(6, 230);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(112, 18);
            this.lblconfirmpassword.TabIndex = 79;
            this.lblconfirmpassword.Text = "Parola Tekrar:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(6, 198);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(58, 18);
            this.lblpassword.TabIndex = 78;
            this.lblpassword.Text = "Parola:";
            // 
            // lblakademisyentcno
            // 
            this.lblakademisyentcno.AutoSize = true;
            this.lblakademisyentcno.Location = new System.Drawing.Point(6, 39);
            this.lblakademisyentcno.Name = "lblakademisyentcno";
            this.lblakademisyentcno.Size = new System.Drawing.Size(66, 18);
            this.lblakademisyentcno.TabIndex = 73;
            this.lblakademisyentcno.Text = "T.C. No:";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(6, 262);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(58, 18);
            this.lbldepartment.TabIndex = 76;
            this.lbldepartment.Text = "Bölüm:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(6, 167);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 18);
            this.lblgender.TabIndex = 77;
            this.lblgender.Text = "Cinsiyet:";
            // 
            // lblakademisyenadi
            // 
            this.lblakademisyenadi.AutoSize = true;
            this.lblakademisyenadi.Location = new System.Drawing.Point(6, 71);
            this.lblakademisyenadi.Name = "lblakademisyenadi";
            this.lblakademisyenadi.Size = new System.Drawing.Size(37, 18);
            this.lblakademisyenadi.TabIndex = 72;
            this.lblakademisyenadi.Text = "Adı:";
            // 
            // lblakademisyensoyadi
            // 
            this.lblakademisyensoyadi.AutoSize = true;
            this.lblakademisyensoyadi.Location = new System.Drawing.Point(6, 103);
            this.lblakademisyensoyadi.Name = "lblakademisyensoyadi";
            this.lblakademisyensoyadi.Size = new System.Drawing.Size(60, 18);
            this.lblakademisyensoyadi.TabIndex = 74;
            this.lblakademisyensoyadi.Text = "Soyadı:";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(6, 136);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(110, 18);
            this.lblbirthdate.TabIndex = 75;
            this.lblbirthdate.Text = "Doğum Tarihi:";
            // 
            // ChkConfirmPassword
            // 
            this.ChkConfirmPassword.AutoSize = true;
            this.ChkConfirmPassword.Location = new System.Drawing.Point(299, 229);
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
            this.ChkPassword.Location = new System.Drawing.Point(299, 196);
            this.ChkPassword.Name = "ChkPassword";
            this.ChkPassword.Size = new System.Drawing.Size(75, 22);
            this.ChkPassword.TabIndex = 70;
            this.ChkPassword.Text = "Göster";
            this.ChkPassword.UseVisualStyleBackColor = true;
            this.ChkPassword.CheckedChanged += new System.EventHandler(this.ChkPassword_CheckedChanged);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(169, 227);
            this.TxtConfirmPassword.MaxLength = 10;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(124, 26);
            this.TxtConfirmPassword.TabIndex = 69;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(169, 195);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(124, 26);
            this.TxtPassword.TabIndex = 67;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // MskTRNumber
            // 
            this.MskTRNumber.Enabled = false;
            this.MskTRNumber.Location = new System.Drawing.Point(169, 36);
            this.MskTRNumber.Mask = "00000000000";
            this.MskTRNumber.Name = "MskTRNumber";
            this.MskTRNumber.Size = new System.Drawing.Size(240, 26);
            this.MskTRNumber.TabIndex = 1;
            this.MskTRNumber.ValidatingType = typeof(int);
            this.MskTRNumber.TextChanged += new System.EventHandler(this.MskTRNumber_TextChanged);
            // 
            // RdbFemale
            // 
            this.RdbFemale.AutoSize = true;
            this.RdbFemale.Location = new System.Drawing.Point(250, 167);
            this.RdbFemale.Name = "RdbFemale";
            this.RdbFemale.Size = new System.Drawing.Size(67, 22);
            this.RdbFemale.TabIndex = 8;
            this.RdbFemale.TabStop = true;
            this.RdbFemale.Text = "Kadın";
            this.RdbFemale.UseVisualStyleBackColor = true;
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(169, 259);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(240, 26);
            this.CmbDepartment.TabIndex = 11;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(169, 167);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(69, 22);
            this.RdbMale.TabIndex = 7;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "Erkek";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // TxtAcademicianName
            // 
            this.TxtAcademicianName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAcademicianName.Location = new System.Drawing.Point(169, 68);
            this.TxtAcademicianName.Name = "TxtAcademicianName";
            this.TxtAcademicianName.Size = new System.Drawing.Size(240, 26);
            this.TxtAcademicianName.TabIndex = 2;
            this.TxtAcademicianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcademicianName_KeyPress);
            // 
            // TxtAcademicianSurname
            // 
            this.TxtAcademicianSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAcademicianSurname.Location = new System.Drawing.Point(169, 100);
            this.TxtAcademicianSurname.Name = "TxtAcademicianSurname";
            this.TxtAcademicianSurname.Size = new System.Drawing.Size(240, 26);
            this.TxtAcademicianSurname.TabIndex = 3;
            this.TxtAcademicianSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcademicianSurname_KeyPress);
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(169, 132);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(240, 26);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // lblakademisyensayisi
            // 
            this.lblakademisyensayisi.AutoSize = true;
            this.lblakademisyensayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyensayisi.Location = new System.Drawing.Point(11, 377);
            this.lblakademisyensayisi.Name = "lblakademisyensayisi";
            this.lblakademisyensayisi.Size = new System.Drawing.Size(184, 23);
            this.lblakademisyensayisi.TabIndex = 149;
            this.lblakademisyensayisi.Text = "Akademisyen Sayısı:";
            // 
            // lblphoto
            // 
            this.lblphoto.AutoSize = true;
            this.lblphoto.Location = new System.Drawing.Point(810, 84);
            this.lblphoto.Name = "lblphoto";
            this.lblphoto.Size = new System.Drawing.Size(73, 18);
            this.lblphoto.TabIndex = 150;
            this.lblphoto.Text = "Fotoğraf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 151;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmEditAcademician
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1113, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblphoto);
            this.Controls.Add(this.lblakademisyensayisi);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblAcademicianCount);
            this.Controls.Add(this.DtgAcademician);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.lblakademisyenduzenlemeformu);
            this.Controls.Add(this.PctAcademicianImage);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.TxtPicture);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditAcademician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditAcademician";
            this.Load += new System.EventHandler(this.FrmEditAcademician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademicianImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchAddress;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label LblAcademicianCount;
        private System.Windows.Forms.DataGridView DtgAcademician;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label lblakademisyenduzenlemeformu;
        private System.Windows.Forms.PictureBox PctAcademicianImage;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.TextBox TxtPicture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ChkConfirmPassword;
        private System.Windows.Forms.CheckBox ChkPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTRNumber;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.TextBox TxtAcademicianName;
        private System.Windows.Forms.TextBox TxtAcademicianSurname;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblakademisyentcno;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblakademisyenadi;
        private System.Windows.Forms.Label lblakademisyensoyadi;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbldistrict;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblakademisyensayisi;
        private System.Windows.Forms.Label lblphoto;
        private System.Windows.Forms.Label label1;
    }
}