namespace EducationAutomationSystem.Student
{
    partial class FrmListStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListStudent));
            this.lblogrencilistesiformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.LblStudentCount = new System.Windows.Forms.Label();
            this.DtgStudent = new System.Windows.Forms.DataGridView();
            this.lblogrencisayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblogrencilistesiformu
            // 
            this.lblogrencilistesiformu.AutoSize = true;
            this.lblogrencilistesiformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencilistesiformu.Location = new System.Drawing.Point(276, 4);
            this.lblogrencilistesiformu.Name = "lblogrencilistesiformu";
            this.lblogrencilistesiformu.Size = new System.Drawing.Size(327, 51);
            this.lblogrencilistesiformu.TabIndex = 109;
            this.lblogrencilistesiformu.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(809, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 110;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // LblStudentCount
            // 
            this.LblStudentCount.AutoSize = true;
            this.LblStudentCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentCount.Location = new System.Drawing.Point(151, 13);
            this.LblStudentCount.Name = "LblStudentCount";
            this.LblStudentCount.Size = new System.Drawing.Size(22, 23);
            this.LblStudentCount.TabIndex = 119;
            this.LblStudentCount.Text = "0";
            // 
            // DtgStudent
            // 
            this.DtgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudent.Location = new System.Drawing.Point(0, 58);
            this.DtgStudent.Name = "DtgStudent";
            this.DtgStudent.Size = new System.Drawing.Size(869, 426);
            this.DtgStudent.TabIndex = 120;
            // 
            // lblogrencisayisi
            // 
            this.lblogrencisayisi.AutoSize = true;
            this.lblogrencisayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblogrencisayisi.Location = new System.Drawing.Point(3, 13);
            this.lblogrencisayisi.Name = "lblogrencisayisi";
            this.lblogrencisayisi.Size = new System.Drawing.Size(138, 23);
            this.lblogrencisayisi.TabIndex = 121;
            this.lblogrencisayisi.Text = "Öğrenci Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(609, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(869, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblogrencisayisi);
            this.Controls.Add(this.DtgStudent);
            this.Controls.Add(this.LblStudentCount);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblogrencilistesiformu);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListStudent";
            this.Load += new System.EventHandler(this.FrmListStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblogrencilistesiformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label LblStudentCount;
        private System.Windows.Forms.DataGridView DtgStudent;
        private System.Windows.Forms.Label lblogrencisayisi;
        private System.Windows.Forms.Label label1;
    }
}