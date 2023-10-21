namespace EducationAutomationSystem.Lesson
{
    partial class FrmAddLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLesson));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lbldersekleformu = new System.Windows.Forms.Label();
            this.TxtLessonName = new System.Windows.Forms.TextBox();
            this.lblders = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblderssayisi = new System.Windows.Forms.Label();
            this.LblLessonCount = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(618, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 18;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lbldersekleformu
            // 
            this.lbldersekleformu.AutoSize = true;
            this.lbldersekleformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldersekleformu.Location = new System.Drawing.Point(233, 3);
            this.lbldersekleformu.Name = "lbldersekleformu";
            this.lbldersekleformu.Size = new System.Drawing.Size(225, 51);
            this.lbldersekleformu.TabIndex = 19;
            this.lbldersekleformu.Text = "DERS EKLE";
            // 
            // TxtLessonName
            // 
            this.TxtLessonName.Location = new System.Drawing.Point(100, 114);
            this.TxtLessonName.MaxLength = 50;
            this.TxtLessonName.Name = "TxtLessonName";
            this.TxtLessonName.Size = new System.Drawing.Size(255, 26);
            this.TxtLessonName.TabIndex = 2;
            // 
            // lblders
            // 
            this.lblders.AutoSize = true;
            this.lblders.Location = new System.Drawing.Point(6, 117);
            this.lblders.Name = "lblders";
            this.lblders.Size = new System.Drawing.Size(46, 18);
            this.lblders.TabIndex = 72;
            this.lblders.Text = "Ders:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(454, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(454, 113);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblderssayisi
            // 
            this.lblderssayisi.AutoSize = true;
            this.lblderssayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssayisi.Location = new System.Drawing.Point(12, 210);
            this.lblderssayisi.Name = "lblderssayisi";
            this.lblderssayisi.Size = new System.Drawing.Size(110, 23);
            this.lblderssayisi.TabIndex = 133;
            this.lblderssayisi.Text = "Ders Sayısı:";
            // 
            // LblLessonCount
            // 
            this.LblLessonCount.AutoSize = true;
            this.LblLessonCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLessonCount.Location = new System.Drawing.Point(147, 210);
            this.LblLessonCount.Name = "LblLessonCount";
            this.LblLessonCount.Size = new System.Drawing.Size(22, 23);
            this.LblLessonCount.TabIndex = 134;
            this.LblLessonCount.Text = "0";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(-10, 20);
            this.TxtID.MaxLength = 50;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(41, 26);
            this.TxtID.TabIndex = 135;
            this.TxtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 141;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // FrmAddLesson
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(678, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.lblderssayisi);
            this.Controls.Add(this.LblLessonCount);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.lblders);
            this.Controls.Add(this.TxtLessonName);
            this.Controls.Add(this.lbldersekleformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddLesson";
            this.Load += new System.EventHandler(this.FrmAddLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lbldersekleformu;
        private System.Windows.Forms.TextBox TxtLessonName;
        private System.Windows.Forms.Label lblders;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblderssayisi;
        private System.Windows.Forms.Label LblLessonCount;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}