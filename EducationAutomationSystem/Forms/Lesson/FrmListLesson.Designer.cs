namespace EducationAutomationSystem.Lesson
{
    partial class FrmListLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListLesson));
            this.LblLessonCount = new System.Windows.Forms.Label();
            this.DtgLesson = new System.Windows.Forms.DataGridView();
            this.lblderslistesiformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblderssayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLessonCount
            // 
            this.LblLessonCount.AutoSize = true;
            this.LblLessonCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLessonCount.Location = new System.Drawing.Point(154, 18);
            this.LblLessonCount.Name = "LblLessonCount";
            this.LblLessonCount.Size = new System.Drawing.Size(22, 23);
            this.LblLessonCount.TabIndex = 162;
            this.LblLessonCount.Text = "0";
            // 
            // DtgLesson
            // 
            this.DtgLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgLesson.Location = new System.Drawing.Point(0, 59);
            this.DtgLesson.Name = "DtgLesson";
            this.DtgLesson.Size = new System.Drawing.Size(753, 352);
            this.DtgLesson.TabIndex = 160;
            // 
            // lblderslistesiformu
            // 
            this.lblderslistesiformu.AutoSize = true;
            this.lblderslistesiformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderslistesiformu.Location = new System.Drawing.Point(253, 2);
            this.lblderslistesiformu.Name = "lblderslistesiformu";
            this.lblderslistesiformu.Size = new System.Drawing.Size(259, 51);
            this.lblderslistesiformu.TabIndex = 158;
            this.lblderslistesiformu.Text = "DERS LİSTESİ";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(694, 0);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 157;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblderssayisi
            // 
            this.lblderssayisi.AutoSize = true;
            this.lblderssayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssayisi.Location = new System.Drawing.Point(3, 18);
            this.lblderssayisi.Name = "lblderssayisi";
            this.lblderssayisi.Size = new System.Drawing.Size(110, 23);
            this.lblderssayisi.TabIndex = 163;
            this.lblderssayisi.Text = "Ders Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 165;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 164;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmListLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblderssayisi);
            this.Controls.Add(this.LblLessonCount);
            this.Controls.Add(this.DtgLesson);
            this.Controls.Add(this.lblderslistesiformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListLesson";
            this.Load += new System.EventHandler(this.FrmListLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblLessonCount;
        private System.Windows.Forms.DataGridView DtgLesson;
        private System.Windows.Forms.Label lblderslistesiformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblderssayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}