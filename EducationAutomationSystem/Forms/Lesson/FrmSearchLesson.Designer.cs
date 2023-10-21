namespace EducationAutomationSystem.Lesson
{
    partial class FrmSearchLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchLesson));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgLesson = new System.Windows.Forms.DataGridView();
            this.TxtLessonSearch = new System.Windows.Forms.TextBox();
            this.lbldersarama = new System.Windows.Forms.Label();
            this.LblLessonCount = new System.Windows.Forms.Label();
            this.TxtDepartmentID = new System.Windows.Forms.TextBox();
            this.lbldersaraformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblderssayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // DtgLesson
            // 
            this.DtgLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgLesson.Location = new System.Drawing.Point(0, 296);
            this.DtgLesson.Name = "DtgLesson";
            this.DtgLesson.Size = new System.Drawing.Size(711, 169);
            this.DtgLesson.TabIndex = 58;
            // 
            // TxtLessonSearch
            // 
            this.TxtLessonSearch.BackColor = System.Drawing.Color.White;
            this.TxtLessonSearch.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtLessonSearch.Location = new System.Drawing.Point(160, 132);
            this.TxtLessonSearch.Name = "TxtLessonSearch";
            this.TxtLessonSearch.Size = new System.Drawing.Size(316, 32);
            this.TxtLessonSearch.TabIndex = 57;
            this.TxtLessonSearch.TextChanged += new System.EventHandler(this.TxtLessonSearch_TextChanged);
            // 
            // lbldersarama
            // 
            this.lbldersarama.AutoSize = true;
            this.lbldersarama.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldersarama.Location = new System.Drawing.Point(12, 140);
            this.lbldersarama.Name = "lbldersarama";
            this.lbldersarama.Size = new System.Drawing.Size(76, 18);
            this.lbldersarama.TabIndex = 56;
            this.lbldersarama.Text = "Ders Ara:";
            // 
            // LblLessonCount
            // 
            this.LblLessonCount.AutoSize = true;
            this.LblLessonCount.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLessonCount.Location = new System.Drawing.Point(156, 253);
            this.LblLessonCount.Name = "LblLessonCount";
            this.LblLessonCount.Size = new System.Drawing.Size(22, 24);
            this.LblLessonCount.TabIndex = 55;
            this.LblLessonCount.Text = "0";
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.Location = new System.Drawing.Point(0, -2);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.Size = new System.Drawing.Size(49, 26);
            this.TxtDepartmentID.TabIndex = 53;
            this.TxtDepartmentID.Visible = false;
            // 
            // lbldersaraformu
            // 
            this.lbldersaraformu.AutoSize = true;
            this.lbldersaraformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldersaraformu.Location = new System.Drawing.Point(212, 6);
            this.lbldersaraformu.Name = "lbldersaraformu";
            this.lbldersaraformu.Size = new System.Drawing.Size(214, 51);
            this.lbldersaraformu.TabIndex = 52;
            this.lbldersaraformu.Text = "DERS ARA";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(650, 3);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 51;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblderssayisi
            // 
            this.lblderssayisi.AutoSize = true;
            this.lblderssayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblderssayisi.Location = new System.Drawing.Point(11, 254);
            this.lblderssayisi.Name = "lblderssayisi";
            this.lblderssayisi.Size = new System.Drawing.Size(110, 23);
            this.lblderssayisi.TabIndex = 164;
            this.lblderssayisi.Text = "Ders Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 166;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 165;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmSearchLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(711, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblderssayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgLesson);
            this.Controls.Add(this.TxtLessonSearch);
            this.Controls.Add(this.lbldersarama);
            this.Controls.Add(this.LblLessonCount);
            this.Controls.Add(this.TxtDepartmentID);
            this.Controls.Add(this.lbldersaraformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchLesson";
            this.Load += new System.EventHandler(this.FrmSearchLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgLesson;
        private System.Windows.Forms.TextBox TxtLessonSearch;
        private System.Windows.Forms.Label lbldersarama;
        private System.Windows.Forms.Label LblLessonCount;
        private System.Windows.Forms.TextBox TxtDepartmentID;
        private System.Windows.Forms.Label lbldersaraformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblderssayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}