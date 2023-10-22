namespace EducationAutomationSystem.Notification
{
    partial class FrmSearchNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchNotification));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgNotification = new System.Windows.Forms.DataGridView();
            this.TxtNotificationSearch = new System.Windows.Forms.TextBox();
            this.lblduyuruarama = new System.Windows.Forms.Label();
            this.LblNotificationCount = new System.Windows.Forms.Label();
            this.TxtDepartmentID = new System.Windows.Forms.TextBox();
            this.lblduyuruaraformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblduyurusayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // DtgNotification
            // 
            this.DtgNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgNotification.Location = new System.Drawing.Point(0, 296);
            this.DtgNotification.Name = "DtgNotification";
            this.DtgNotification.Size = new System.Drawing.Size(711, 169);
            this.DtgNotification.TabIndex = 58;
            // 
            // TxtNotificationSearch
            // 
            this.TxtNotificationSearch.BackColor = System.Drawing.Color.White;
            this.TxtNotificationSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotificationSearch.Location = new System.Drawing.Point(186, 138);
            this.TxtNotificationSearch.Name = "TxtNotificationSearch";
            this.TxtNotificationSearch.Size = new System.Drawing.Size(316, 26);
            this.TxtNotificationSearch.TabIndex = 57;
            this.TxtNotificationSearch.TextChanged += new System.EventHandler(this.TxtNotificationSearch_TextChanged);
            // 
            // lblduyuruarama
            // 
            this.lblduyuruarama.AutoSize = true;
            this.lblduyuruarama.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyuruarama.Location = new System.Drawing.Point(12, 141);
            this.lblduyuruarama.Name = "lblduyuruarama";
            this.lblduyuruarama.Size = new System.Drawing.Size(97, 18);
            this.lblduyuruarama.TabIndex = 56;
            this.lblduyuruarama.Text = "Duyuru Ara:";
            // 
            // LblNotificationCount
            // 
            this.LblNotificationCount.AutoSize = true;
            this.LblNotificationCount.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotificationCount.Location = new System.Drawing.Point(207, 257);
            this.LblNotificationCount.Name = "LblNotificationCount";
            this.LblNotificationCount.Size = new System.Drawing.Size(22, 24);
            this.LblNotificationCount.TabIndex = 55;
            this.LblNotificationCount.Text = "0";
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.Location = new System.Drawing.Point(0, -1);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.Size = new System.Drawing.Size(49, 26);
            this.TxtDepartmentID.TabIndex = 53;
            this.TxtDepartmentID.Visible = false;
            // 
            // lblduyuruaraformu
            // 
            this.lblduyuruaraformu.AutoSize = true;
            this.lblduyuruaraformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyuruaraformu.Location = new System.Drawing.Point(156, 7);
            this.lblduyuruaraformu.Name = "lblduyuruaraformu";
            this.lblduyuruaraformu.Size = new System.Drawing.Size(269, 51);
            this.lblduyuruaraformu.TabIndex = 52;
            this.lblduyuruaraformu.Text = "DUYURU ARA";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(650, 4);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 51;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblduyurusayisi
            // 
            this.lblduyurusayisi.AutoSize = true;
            this.lblduyurusayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurusayisi.Location = new System.Drawing.Point(11, 257);
            this.lblduyurusayisi.Name = "lblduyurusayisi";
            this.lblduyurusayisi.Size = new System.Drawing.Size(135, 23);
            this.lblduyurusayisi.TabIndex = 60;
            this.lblduyurusayisi.Text = "Duyuru Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(483, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 137;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmSearchNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblduyurusayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgNotification);
            this.Controls.Add(this.TxtNotificationSearch);
            this.Controls.Add(this.lblduyuruarama);
            this.Controls.Add(this.LblNotificationCount);
            this.Controls.Add(this.TxtDepartmentID);
            this.Controls.Add(this.lblduyuruaraformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchNotification";
            this.Load += new System.EventHandler(this.FrmSearchNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgNotification;
        private System.Windows.Forms.TextBox TxtNotificationSearch;
        private System.Windows.Forms.Label lblduyuruarama;
        private System.Windows.Forms.Label LblNotificationCount;
        private System.Windows.Forms.TextBox TxtDepartmentID;
        private System.Windows.Forms.Label lblduyuruaraformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblduyurusayisi;
        private System.Windows.Forms.Label label1;
    }
}