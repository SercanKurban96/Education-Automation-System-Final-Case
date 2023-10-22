namespace EducationAutomationSystem.Academician
{
    partial class FrmListAcademician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListAcademician));
            this.lblakademisyenlistesiformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.LblAcademicianCount = new System.Windows.Forms.Label();
            this.DtgAcademician = new System.Windows.Forms.DataGridView();
            this.lblakademisyensayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).BeginInit();
            this.SuspendLayout();
            // 
            // lblakademisyenlistesiformu
            // 
            this.lblakademisyenlistesiformu.AutoSize = true;
            this.lblakademisyenlistesiformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyenlistesiformu.Location = new System.Drawing.Point(295, 4);
            this.lblakademisyenlistesiformu.Name = "lblakademisyenlistesiformu";
            this.lblakademisyenlistesiformu.Size = new System.Drawing.Size(428, 51);
            this.lblakademisyenlistesiformu.TabIndex = 143;
            this.lblakademisyenlistesiformu.Text = "AKADEMİSYEN LİSTESİ";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(867, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 144;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // LblAcademicianCount
            // 
            this.LblAcademicianCount.AutoSize = true;
            this.LblAcademicianCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAcademicianCount.Location = new System.Drawing.Point(195, 11);
            this.LblAcademicianCount.Name = "LblAcademicianCount";
            this.LblAcademicianCount.Size = new System.Drawing.Size(22, 23);
            this.LblAcademicianCount.TabIndex = 149;
            this.LblAcademicianCount.Text = "0";
            // 
            // DtgAcademician
            // 
            this.DtgAcademician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgAcademician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAcademician.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgAcademician.Location = new System.Drawing.Point(0, 61);
            this.DtgAcademician.Name = "DtgAcademician";
            this.DtgAcademician.Size = new System.Drawing.Size(926, 462);
            this.DtgAcademician.TabIndex = 150;
            // 
            // lblakademisyensayisi
            // 
            this.lblakademisyensayisi.AutoSize = true;
            this.lblakademisyensayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyensayisi.Location = new System.Drawing.Point(4, 11);
            this.lblakademisyensayisi.Name = "lblakademisyensayisi";
            this.lblakademisyensayisi.Size = new System.Drawing.Size(184, 23);
            this.lblakademisyensayisi.TabIndex = 151;
            this.lblakademisyensayisi.Text = "Akademisyen Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(729, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 152;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmListAcademician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblakademisyensayisi);
            this.Controls.Add(this.DtgAcademician);
            this.Controls.Add(this.LblAcademicianCount);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblakademisyenlistesiformu);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListAcademician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListAcademician";
            this.Load += new System.EventHandler(this.FrmListAcademician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblakademisyenlistesiformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label LblAcademicianCount;
        private System.Windows.Forms.DataGridView DtgAcademician;
        private System.Windows.Forms.Label lblakademisyensayisi;
        private System.Windows.Forms.Label label1;
    }
}