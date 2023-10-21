namespace EducationAutomationSystem.Notification
{
    partial class FrmNotificationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificationList));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblduyurulistesiformu = new System.Windows.Forms.Label();
            this.DtgNotification = new System.Windows.Forms.DataGridView();
            this.LblNotificationCount = new System.Windows.Forms.Label();
            this.lblduyurusayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(750, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 28;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblduyurulistesiformu
            // 
            this.lblduyurulistesiformu.AutoSize = true;
            this.lblduyurulistesiformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurulistesiformu.Location = new System.Drawing.Point(248, 9);
            this.lblduyurulistesiformu.Name = "lblduyurulistesiformu";
            this.lblduyurulistesiformu.Size = new System.Drawing.Size(314, 51);
            this.lblduyurulistesiformu.TabIndex = 27;
            this.lblduyurulistesiformu.Text = "DUYURU LİSTESİ";
            // 
            // DtgNotification
            // 
            this.DtgNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgNotification.Location = new System.Drawing.Point(0, 63);
            this.DtgNotification.Name = "DtgNotification";
            this.DtgNotification.Size = new System.Drawing.Size(810, 469);
            this.DtgNotification.TabIndex = 30;
            this.DtgNotification.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgNotification_CellClick);
            // 
            // LblNotificationCount
            // 
            this.LblNotificationCount.AutoSize = true;
            this.LblNotificationCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNotificationCount.Location = new System.Drawing.Point(175, 19);
            this.LblNotificationCount.Name = "LblNotificationCount";
            this.LblNotificationCount.Size = new System.Drawing.Size(22, 23);
            this.LblNotificationCount.TabIndex = 37;
            this.LblNotificationCount.Text = "0";
            // 
            // lblduyurusayisi
            // 
            this.lblduyurusayisi.AutoSize = true;
            this.lblduyurusayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurusayisi.Location = new System.Drawing.Point(-1, 19);
            this.lblduyurusayisi.Name = "lblduyurusayisi";
            this.lblduyurusayisi.Size = new System.Drawing.Size(135, 23);
            this.lblduyurusayisi.TabIndex = 55;
            this.lblduyurusayisi.Text = "Duyuru Sayısı:";
            // 
            // FrmNotificationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 532);
            this.Controls.Add(this.lblduyurusayisi);
            this.Controls.Add(this.LblNotificationCount);
            this.Controls.Add(this.DtgNotification);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblduyurulistesiformu);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNotificationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNotificationList";
            this.Load += new System.EventHandler(this.FrmNotificationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblduyurulistesiformu;
        private System.Windows.Forms.DataGridView DtgNotification;
        private System.Windows.Forms.Label LblNotificationCount;
        private System.Windows.Forms.Label lblduyurusayisi;
    }
}