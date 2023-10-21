namespace EducationAutomationSystem.Lesson
{
    partial class FrmDeleteLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteLesson));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLessonCount = new System.Windows.Forms.Label();
            this.DtgLesson = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.lblderssilformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.TxtLessonName = new System.Windows.Forms.TextBox();
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
            this.TxtID.Location = new System.Drawing.Point(-9, 20);
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
            this.LblLessonCount.Location = new System.Drawing.Point(158, 255);
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
            this.BtnCancel.Location = new System.Drawing.Point(455, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 142;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(455, 113);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(149, 43);
            this.BtnDelete.TabIndex = 141;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblderssilformu
            // 
            this.lblderssilformu.AutoSize = true;
            this.lblderssilformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssilformu.Location = new System.Drawing.Point(194, 3);
            this.lblderssilformu.Name = "lblderssilformu";
            this.lblderssilformu.Size = new System.Drawing.Size(184, 51);
            this.lblderssilformu.TabIndex = 144;
            this.lblderssilformu.Text = "DERS SİL";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(619, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 143;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // TxtLessonName
            // 
            this.TxtLessonName.Enabled = false;
            this.TxtLessonName.Location = new System.Drawing.Point(122, 122);
            this.TxtLessonName.MaxLength = 50;
            this.TxtLessonName.Name = "TxtLessonName";
            this.TxtLessonName.Size = new System.Drawing.Size(255, 26);
            this.TxtLessonName.TabIndex = 140;
            // 
            // lblderssayisi
            // 
            this.lblderssayisi.AutoSize = true;
            this.lblderssayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssayisi.Location = new System.Drawing.Point(12, 255);
            this.lblderssayisi.Name = "lblderssayisi";
            this.lblderssayisi.Size = new System.Drawing.Size(110, 23);
            this.lblderssayisi.TabIndex = 154;
            this.lblderssayisi.Text = "Ders Sayısı:";
            // 
            // lblders
            // 
            this.lblders.AutoSize = true;
            this.lblders.Location = new System.Drawing.Point(8, 125);
            this.lblders.Name = "lblders";
            this.lblders.Size = new System.Drawing.Size(46, 18);
            this.lblders.TabIndex = 153;
            this.lblders.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 156;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 155;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // FrmDeleteLesson
            // 
            this.AcceptButton = this.BtnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtLessonName);
            this.Controls.Add(this.lblderssilformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDeleteLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteLesson";
            this.Load += new System.EventHandler(this.FrmDeleteLesson_Load);
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
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label lblderssilformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.TextBox TxtLessonName;
        private System.Windows.Forms.Label lblderssayisi;
        private System.Windows.Forms.Label lblders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}