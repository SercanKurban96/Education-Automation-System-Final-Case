namespace EducationAutomationSystem
{
    partial class FrmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            this.PctDepartment = new System.Windows.Forms.PictureBox();
            this.lblbolumler = new System.Windows.Forms.Label();
            this.PctExit = new System.Windows.Forms.PictureBox();
            this.lblogrenciler = new System.Windows.Forms.Label();
            this.PctStudent = new System.Windows.Forms.PictureBox();
            this.lblakademisyenler = new System.Windows.Forms.Label();
            this.PctAcademician = new System.Windows.Forms.PictureBox();
            this.lblraporlar = new System.Windows.Forms.Label();
            this.lblduyurular = new System.Windows.Forms.Label();
            this.PctNotification = new System.Windows.Forms.PictureBox();
            this.lbluygulamalar = new System.Windows.Forms.Label();
            this.PctSettings = new System.Windows.Forms.PictureBox();
            this.lblyoneticipaneli = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PctMinimize = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.PctReport = new System.Windows.Forms.PictureBox();
            this.toolTip11 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip12 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip13 = new System.Windows.Forms.ToolTip(this.components);
            this.lblyoneticibasligi = new System.Windows.Forms.Label();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimize)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctReport)).BeginInit();
            this.SuspendLayout();
            // 
            // PctDepartment
            // 
            this.PctDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctDepartment.Image = ((System.Drawing.Image)(resources.GetObject("PctDepartment.Image")));
            this.PctDepartment.Location = new System.Drawing.Point(31, 170);
            this.PctDepartment.Name = "PctDepartment";
            this.PctDepartment.Size = new System.Drawing.Size(154, 110);
            this.PctDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctDepartment.TabIndex = 1;
            this.PctDepartment.TabStop = false;
            this.toolTip1.SetToolTip(this.PctDepartment, "Bölüm ekleme, silme veya güncelleme işlemleri için tıklayın.");
            this.PctDepartment.Click += new System.EventHandler(this.PctDepartment_Click);
            this.PctDepartment.MouseHover += new System.EventHandler(this.PctDepartment_MouseHover);
            // 
            // lblbolumler
            // 
            this.lblbolumler.AutoSize = true;
            this.lblbolumler.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblbolumler.Location = new System.Drawing.Point(35, 294);
            this.lblbolumler.Name = "lblbolumler";
            this.lblbolumler.Size = new System.Drawing.Size(113, 25);
            this.lblbolumler.TabIndex = 2;
            this.lblbolumler.Text = "Bölümler";
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(861, 2);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 8;
            this.PctExit.TabStop = false;
            this.toolTip13.SetToolTip(this.PctExit, "Kapat");
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // lblogrenciler
            // 
            this.lblogrenciler.AutoSize = true;
            this.lblogrenciler.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrenciler.ForeColor = System.Drawing.Color.Red;
            this.lblogrenciler.Location = new System.Drawing.Point(405, 294);
            this.lblogrenciler.Name = "lblogrenciler";
            this.lblogrenciler.Size = new System.Drawing.Size(127, 25);
            this.lblogrenciler.TabIndex = 10;
            this.lblogrenciler.Text = "Öğrenciler";
            // 
            // PctStudent
            // 
            this.PctStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctStudent.Image = ((System.Drawing.Image)(resources.GetObject("PctStudent.Image")));
            this.PctStudent.Location = new System.Drawing.Point(385, 170);
            this.PctStudent.Name = "PctStudent";
            this.PctStudent.Size = new System.Drawing.Size(154, 110);
            this.PctStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStudent.TabIndex = 9;
            this.PctStudent.TabStop = false;
            this.toolTip4.SetToolTip(this.PctStudent, "Öğrenci kayıt, silme, düzenleme işlemleri için tıklayın.");
            this.PctStudent.Click += new System.EventHandler(this.PctStudent_Click);
            this.PctStudent.MouseHover += new System.EventHandler(this.PctStudent_MouseHover);
            // 
            // lblakademisyenler
            // 
            this.lblakademisyenler.AutoSize = true;
            this.lblakademisyenler.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyenler.ForeColor = System.Drawing.Color.Green;
            this.lblakademisyenler.Location = new System.Drawing.Point(726, 294);
            this.lblakademisyenler.Name = "lblakademisyenler";
            this.lblakademisyenler.Size = new System.Drawing.Size(188, 25);
            this.lblakademisyenler.TabIndex = 12;
            this.lblakademisyenler.Text = "Akademisyenler";
            // 
            // PctAcademician
            // 
            this.PctAcademician.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAcademician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctAcademician.Image = ((System.Drawing.Image)(resources.GetObject("PctAcademician.Image")));
            this.PctAcademician.Location = new System.Drawing.Point(735, 170);
            this.PctAcademician.Name = "PctAcademician";
            this.PctAcademician.Size = new System.Drawing.Size(154, 110);
            this.PctAcademician.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAcademician.TabIndex = 11;
            this.PctAcademician.TabStop = false;
            this.toolTip5.SetToolTip(this.PctAcademician, "Akademisyen ekleme, silme, güncelleme işlemleri için tıklayın.");
            this.PctAcademician.Click += new System.EventHandler(this.PctAcademician_Click);
            this.PctAcademician.MouseHover += new System.EventHandler(this.PctAcademician_MouseHover);
            // 
            // lblraporlar
            // 
            this.lblraporlar.AutoSize = true;
            this.lblraporlar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblraporlar.Location = new System.Drawing.Point(757, 481);
            this.lblraporlar.Name = "lblraporlar";
            this.lblraporlar.Size = new System.Drawing.Size(111, 25);
            this.lblraporlar.TabIndex = 14;
            this.lblraporlar.Text = "Raporlar";
            // 
            // lblduyurular
            // 
            this.lblduyurular.AutoSize = true;
            this.lblduyurular.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblduyurular.Location = new System.Drawing.Point(39, 481);
            this.lblduyurular.Name = "lblduyurular";
            this.lblduyurular.Size = new System.Drawing.Size(126, 25);
            this.lblduyurular.TabIndex = 16;
            this.lblduyurular.Text = "Duyurular";
            // 
            // PctNotification
            // 
            this.PctNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctNotification.Image = ((System.Drawing.Image)(resources.GetObject("PctNotification.Image")));
            this.PctNotification.Location = new System.Drawing.Point(31, 359);
            this.PctNotification.Name = "PctNotification";
            this.PctNotification.Size = new System.Drawing.Size(154, 110);
            this.PctNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctNotification.TabIndex = 15;
            this.PctNotification.TabStop = false;
            this.toolTip3.SetToolTip(this.PctNotification, "Duyuru ekleme, silme, güncelleme işlemleri için tıklayın.");
            this.PctNotification.Click += new System.EventHandler(this.PctNotification_Click);
            this.PctNotification.MouseHover += new System.EventHandler(this.PctNotification_MouseHover);
            // 
            // lbluygulamalar
            // 
            this.lbluygulamalar.AutoSize = true;
            this.lbluygulamalar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluygulamalar.ForeColor = System.Drawing.Color.Yellow;
            this.lbluygulamalar.Location = new System.Drawing.Point(389, 481);
            this.lbluygulamalar.Name = "lbluygulamalar";
            this.lbluygulamalar.Size = new System.Drawing.Size(153, 25);
            this.lbluygulamalar.TabIndex = 18;
            this.lbluygulamalar.Text = "Uygulamalar";
            // 
            // PctSettings
            // 
            this.PctSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctSettings.Image = ((System.Drawing.Image)(resources.GetObject("PctSettings.Image")));
            this.PctSettings.Location = new System.Drawing.Point(385, 359);
            this.PctSettings.Name = "PctSettings";
            this.PctSettings.Size = new System.Drawing.Size(154, 110);
            this.PctSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSettings.TabIndex = 17;
            this.PctSettings.TabStop = false;
            this.toolTip2.SetToolTip(this.PctSettings, "Şifre değişikliği, radyo, müzik dinleme gibi araçlar için tıklayın.");
            this.PctSettings.Click += new System.EventHandler(this.PctSettings_Click);
            this.PctSettings.MouseHover += new System.EventHandler(this.PctSettings_MouseHover);
            // 
            // lblyoneticipaneli
            // 
            this.lblyoneticipaneli.AutoSize = true;
            this.lblyoneticipaneli.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticipaneli.Location = new System.Drawing.Point(301, 9);
            this.lblyoneticipaneli.Name = "lblyoneticipaneli";
            this.lblyoneticipaneli.Size = new System.Drawing.Size(329, 51);
            this.lblyoneticipaneli.TabIndex = 20;
            this.lblyoneticipaneli.Text = "YÖNETİCİ PANELİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 27);
            this.label11.TabIndex = 24;
            this.label11.Text = "label11";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PctMinimize
            // 
            this.PctMinimize.BackColor = System.Drawing.Color.Transparent;
            this.PctMinimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PctMinimize.Image")));
            this.PctMinimize.Location = new System.Drawing.Point(801, 2);
            this.PctMinimize.Name = "PctMinimize";
            this.PctMinimize.Size = new System.Drawing.Size(58, 53);
            this.PctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMinimize.TabIndex = 25;
            this.PctMinimize.TabStop = false;
            this.toolTip12.SetToolTip(this.PctMinimize, "Simge Durumuna");
            this.PctMinimize.Click += new System.EventHandler(this.PctMinimize_Click);
            this.PctMinimize.MouseLeave += new System.EventHandler(this.PctMinimize_MouseLeave);
            this.PctMinimize.MouseHover += new System.EventHandler(this.PctMinimize_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Eğitim Otomasyon Sistemi Yönetici Paneli";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bölüm İşlemleri";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Uygulamalar";
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Duyuru İşlemleri";
            // 
            // toolTip4
            // 
            this.toolTip4.IsBalloon = true;
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip4.ToolTipTitle = "Öğrenci İşlemleri";
            // 
            // toolTip5
            // 
            this.toolTip5.IsBalloon = true;
            this.toolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip5.ToolTipTitle = "Akademisyen İşlemleri";
            // 
            // toolTip6
            // 
            this.toolTip6.IsBalloon = true;
            this.toolTip6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip6.ToolTipTitle = "Ders İşlemleri";
            // 
            // PctReport
            // 
            this.PctReport.BackColor = System.Drawing.Color.Transparent;
            this.PctReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctReport.Image = ((System.Drawing.Image)(resources.GetObject("PctReport.Image")));
            this.PctReport.Location = new System.Drawing.Point(735, 359);
            this.PctReport.Name = "PctReport";
            this.PctReport.Size = new System.Drawing.Size(154, 110);
            this.PctReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctReport.TabIndex = 26;
            this.PctReport.TabStop = false;
            this.PctReport.Click += new System.EventHandler(this.PctReport_Click);
            this.PctReport.MouseHover += new System.EventHandler(this.PctReport_MouseHover);
            // 
            // toolTip11
            // 
            this.toolTip11.IsBalloon = true;
            this.toolTip11.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip11.ToolTipTitle = "Raporlar";
            // 
            // lblyoneticibasligi
            // 
            this.lblyoneticibasligi.AutoSize = true;
            this.lblyoneticibasligi.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticibasligi.Location = new System.Drawing.Point(8, 59);
            this.lblyoneticibasligi.Name = "lblyoneticibasligi";
            this.lblyoneticibasligi.Size = new System.Drawing.Size(99, 27);
            this.lblyoneticibasligi.TabIndex = 27;
            this.lblyoneticibasligi.Text = "Yönetici:";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdmin.Location = new System.Drawing.Point(113, 59);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(67, 27);
            this.LblAdmin.TabIndex = 28;
            this.LblAdmin.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 131;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.lblyoneticibasligi);
            this.Controls.Add(this.PctReport);
            this.Controls.Add(this.PctMinimize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblyoneticipaneli);
            this.Controls.Add(this.lbluygulamalar);
            this.Controls.Add(this.PctSettings);
            this.Controls.Add(this.lblduyurular);
            this.Controls.Add(this.PctNotification);
            this.Controls.Add(this.lblraporlar);
            this.Controls.Add(this.lblakademisyenler);
            this.Controls.Add(this.PctAcademician);
            this.Controls.Add(this.lblogrenciler);
            this.Controls.Add(this.PctStudent);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.lblbolumler);
            this.Controls.Add(this.PctDepartment);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAcademician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimize)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctDepartment;
        private System.Windows.Forms.Label lblbolumler;
        private System.Windows.Forms.PictureBox PctExit;
        private System.Windows.Forms.Label lblogrenciler;
        private System.Windows.Forms.PictureBox PctStudent;
        private System.Windows.Forms.Label lblakademisyenler;
        private System.Windows.Forms.PictureBox PctAcademician;
        private System.Windows.Forms.Label lblraporlar;
        private System.Windows.Forms.Label lblduyurular;
        private System.Windows.Forms.PictureBox PctNotification;
        private System.Windows.Forms.Label lbluygulamalar;
        private System.Windows.Forms.PictureBox PctSettings;
        private System.Windows.Forms.Label lblyoneticipaneli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PctMinimize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.PictureBox PctReport;
        private System.Windows.Forms.ToolTip toolTip11;
        private System.Windows.Forms.ToolTip toolTip13;
        private System.Windows.Forms.ToolTip toolTip12;
        private System.Windows.Forms.Label lblyoneticibasligi;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Label label1;
    }
}