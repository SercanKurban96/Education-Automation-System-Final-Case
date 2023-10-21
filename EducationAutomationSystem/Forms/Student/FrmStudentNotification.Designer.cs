namespace EducationAutomationSystem.Forms.Student
{
    partial class FrmStudentNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentNotification));
            this.DtgNotifications = new System.Windows.Forms.DataGridView();
            this.lblduyurularpanel = new System.Windows.Forms.Label();
            this.PctExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgNotifications
            // 
            this.DtgNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgNotifications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgNotifications.Location = new System.Drawing.Point(0, 67);
            this.DtgNotifications.Name = "DtgNotifications";
            this.DtgNotifications.Size = new System.Drawing.Size(822, 403);
            this.DtgNotifications.TabIndex = 0;
            // 
            // lblduyurularpanel
            // 
            this.lblduyurularpanel.AutoSize = true;
            this.lblduyurularpanel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblduyurularpanel.Location = new System.Drawing.Point(273, 9);
            this.lblduyurularpanel.Name = "lblduyurularpanel";
            this.lblduyurularpanel.Size = new System.Drawing.Size(251, 51);
            this.lblduyurularpanel.TabIndex = 42;
            this.lblduyurularpanel.Text = "DUYURULAR";
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(761, 2);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 41;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // FrmStudentNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(822, 470);
            this.Controls.Add(this.lblduyurularpanel);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.DtgNotifications);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentNotification";
            this.Load += new System.EventHandler(this.FrmStudentNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgNotifications;
        private System.Windows.Forms.Label lblduyurularpanel;
        private System.Windows.Forms.PictureBox PctExit;
    }
}