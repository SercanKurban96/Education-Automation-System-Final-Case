namespace EducationAutomationSystem.Lesson
{
    partial class FrmEditLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditLesson));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLessonCount = new System.Windows.Forms.Label();
            this.DtgLesson = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TxtLessonName = new System.Windows.Forms.TextBox();
            this.lbldersduzenleformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblderssayisi = new System.Windows.Forms.Label();
            this.lblders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(-10, 20);
            this.TxtID.MaxLength = 50;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(41, 26);
            this.TxtID.TabIndex = 149;
            this.TxtID.Visible = false;
            // 
            // LblLessonCount
            // 
            this.LblLessonCount.AutoSize = true;
            this.LblLessonCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLessonCount.Location = new System.Drawing.Point(149, 255);
            this.LblLessonCount.Name = "LblLessonCount";
            this.LblLessonCount.Size = new System.Drawing.Size(22, 23);
            this.LblLessonCount.TabIndex = 148;
            this.LblLessonCount.Text = "0";
            // 
            // DtgLesson
            // 
            this.DtgLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgLesson.Location = new System.Drawing.Point(0, 294);
            this.DtgLesson.Name = "DtgLesson";
            this.DtgLesson.Size = new System.Drawing.Size(678, 154);
            this.DtgLesson.TabIndex = 146;
            this.DtgLesson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgLesson_CellClick);
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
            this.BtnCancel.TabIndex = 142;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(454, 113);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 141;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TxtLessonName
            // 
            this.TxtLessonName.Location = new System.Drawing.Point(115, 122);
            this.TxtLessonName.MaxLength = 50;
            this.TxtLessonName.Name = "TxtLessonName";
            this.TxtLessonName.Size = new System.Drawing.Size(255, 26);
            this.TxtLessonName.TabIndex = 140;
            // 
            // lbldersduzenleformu
            // 
            this.lbldersduzenleformu.AutoSize = true;
            this.lbldersduzenleformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldersduzenleformu.Location = new System.Drawing.Point(186, 3);
            this.lbldersduzenleformu.Name = "lbldersduzenleformu";
            this.lbldersduzenleformu.Size = new System.Drawing.Size(308, 51);
            this.lbldersduzenleformu.TabIndex = 144;
            this.lbldersduzenleformu.Text = "DERS DÜZENLE";
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
            this.PctBack.TabIndex = 143;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblderssayisi
            // 
            this.lblderssayisi.AutoSize = true;
            this.lblderssayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssayisi.Location = new System.Drawing.Point(8, 255);
            this.lblderssayisi.Name = "lblderssayisi";
            this.lblderssayisi.Size = new System.Drawing.Size(110, 23);
            this.lblderssayisi.TabIndex = 158;
            this.lblderssayisi.Text = "Ders Sayısı:";
            // 
            // lblders
            // 
            this.lblders.AutoSize = true;
            this.lblders.Location = new System.Drawing.Point(12, 125);
            this.lblders.Name = "lblders";
            this.lblders.Size = new System.Drawing.Size(46, 18);
            this.lblders.TabIndex = 157;
            this.lblders.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 160;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 159;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmEditLesson
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblderssayisi);
            this.Controls.Add(this.lblders);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblLessonCount);
            this.Controls.Add(this.DtgLesson);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtLessonName);
            this.Controls.Add(this.lbldersduzenleformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditLesson";
            this.Load += new System.EventHandler(this.FrmEditLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLessonCount;
        private System.Windows.Forms.DataGridView DtgLesson;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TxtLessonName;
        private System.Windows.Forms.Label lbldersduzenleformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblderssayisi;
        private System.Windows.Forms.Label lblders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}