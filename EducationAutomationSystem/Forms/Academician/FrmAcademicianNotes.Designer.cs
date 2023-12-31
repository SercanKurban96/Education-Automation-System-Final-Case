﻿namespace EducationAutomationSystem.Forms.Academician
{
    partial class FrmAcademicianNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademicianNotes));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbLesson = new System.Windows.Forms.ComboBox();
            this.lblderssec = new System.Windows.Forms.Label();
            this.lblogrenciid = new System.Windows.Forms.Label();
            this.lblvizesinavi = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.lblfinalsinavi = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.lblortalama = new System.Windows.Forms.Label();
            this.lblnotislemleri = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.DtgStudentNotes = new System.Windows.Forms.DataGridView();
            this.TxtMidtermExam = new System.Windows.Forms.TextBox();
            this.TxtFinalExam = new System.Windows.Forms.TextBox();
            this.lbldersid = new System.Windows.Forms.Label();
            this.BtnNumbers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblharfnotu = new System.Windows.Forms.Label();
            this.TxtLetterGrade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudentNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(473, 293);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 39);
            this.BtnCancel.TabIndex = 127;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(123, 293);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 39);
            this.BtnAdd.TabIndex = 126;
            this.BtnAdd.Text = "Kaydet";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbLesson
            // 
            this.CmbLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLesson.FormattingEnabled = true;
            this.CmbLesson.Location = new System.Drawing.Point(140, 107);
            this.CmbLesson.Name = "CmbLesson";
            this.CmbLesson.Size = new System.Drawing.Size(240, 26);
            this.CmbLesson.TabIndex = 128;
            //this.CmbLesson.SelectedIndexChanged += new System.EventHandler(this.CmbLesson_SelectedIndexChanged);
            // 
            // lblderssec
            // 
            this.lblderssec.AutoSize = true;
            this.lblderssec.Location = new System.Drawing.Point(6, 110);
            this.lblderssec.Name = "lblderssec";
            this.lblderssec.Size = new System.Drawing.Size(74, 18);
            this.lblderssec.TabIndex = 129;
            this.lblderssec.Text = "Ders Seç:";
            // 
            // lblogrenciid
            // 
            this.lblogrenciid.AutoSize = true;
            this.lblogrenciid.Location = new System.Drawing.Point(6, 142);
            this.lblogrenciid.Name = "lblogrenciid";
            this.lblogrenciid.Size = new System.Drawing.Size(90, 18);
            this.lblogrenciid.TabIndex = 131;
            this.lblogrenciid.Text = "Öğrenci ID:";
            // 
            // lblvizesinavi
            // 
            this.lblvizesinavi.AutoSize = true;
            this.lblvizesinavi.Location = new System.Drawing.Point(440, 110);
            this.lblvizesinavi.Name = "lblvizesinavi";
            this.lblvizesinavi.Size = new System.Drawing.Size(90, 18);
            this.lblvizesinavi.TabIndex = 133;
            this.lblvizesinavi.Text = "Vize Sınavı:";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Location = new System.Drawing.Point(570, 171);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(91, 35);
            this.BtnCalculate.TabIndex = 134;
            this.BtnCalculate.Text = "Hesapla";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblfinalsinavi
            // 
            this.lblfinalsinavi.AutoSize = true;
            this.lblfinalsinavi.Location = new System.Drawing.Point(440, 142);
            this.lblfinalsinavi.Name = "lblfinalsinavi";
            this.lblfinalsinavi.Size = new System.Drawing.Size(95, 18);
            this.lblfinalsinavi.TabIndex = 136;
            this.lblfinalsinavi.Text = "Final Sınavı:";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Enabled = false;
            this.TxtAverage.Location = new System.Drawing.Point(571, 212);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(90, 26);
            this.TxtAverage.TabIndex = 139;
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(440, 215);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(80, 18);
            this.lblortalama.TabIndex = 140;
            this.lblortalama.Text = "Ortalama:";
            // 
            // lblnotislemleri
            // 
            this.lblnotislemleri.AutoSize = true;
            this.lblnotislemleri.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnotislemleri.Location = new System.Drawing.Point(191, 9);
            this.lblnotislemleri.Name = "lblnotislemleri";
            this.lblnotislemleri.Size = new System.Drawing.Size(300, 51);
            this.lblnotislemleri.TabIndex = 142;
            this.lblnotislemleri.Text = "NOT İŞLEMLERİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, -23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 143;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Location = new System.Drawing.Point(140, 139);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(69, 26);
            this.TxtStudentID.TabIndex = 144;
            this.TxtStudentID.TextChanged += new System.EventHandler(this.TxtStudentID_TextChanged);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(140, 75);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(43, 26);
            this.TxtID.TabIndex = 145;
            this.TxtID.Visible = false;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(295, 293);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(116, 39);
            this.BtnEdit.TabIndex = 146;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DtgStudentNotes
            // 
            this.DtgStudentNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudentNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudentNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgStudentNotes.Location = new System.Drawing.Point(0, 360);
            this.DtgStudentNotes.Name = "DtgStudentNotes";
            this.DtgStudentNotes.Size = new System.Drawing.Size(727, 167);
            this.DtgStudentNotes.TabIndex = 147;
            this.DtgStudentNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgStudentNotes_CellClick);
            // 
            // TxtMidtermExam
            // 
            this.TxtMidtermExam.Location = new System.Drawing.Point(570, 107);
            this.TxtMidtermExam.MaxLength = 3;
            this.TxtMidtermExam.Name = "TxtMidtermExam";
            this.TxtMidtermExam.Size = new System.Drawing.Size(90, 26);
            this.TxtMidtermExam.TabIndex = 148;
            // 
            // TxtFinalExam
            // 
            this.TxtFinalExam.Location = new System.Drawing.Point(570, 139);
            this.TxtFinalExam.MaxLength = 3;
            this.TxtFinalExam.Name = "TxtFinalExam";
            this.TxtFinalExam.Size = new System.Drawing.Size(90, 26);
            this.TxtFinalExam.TabIndex = 149;
            // 
            // lbldersid
            // 
            this.lbldersid.AutoSize = true;
            this.lbldersid.Location = new System.Drawing.Point(6, 78);
            this.lbldersid.Name = "lbldersid";
            this.lbldersid.Size = new System.Drawing.Size(68, 18);
            this.lbldersid.TabIndex = 150;
            this.lbldersid.Text = "Ders ID:";
            this.lbldersid.Visible = false;
            // 
            // BtnNumbers
            // 
            this.BtnNumbers.Location = new System.Drawing.Point(216, 139);
            this.BtnNumbers.Name = "BtnNumbers";
            this.BtnNumbers.Size = new System.Drawing.Size(47, 26);
            this.BtnNumbers.TabIndex = 151;
            this.BtnNumbers.Text = "...";
            this.BtnNumbers.UseVisualStyleBackColor = true;
            this.BtnNumbers.Click += new System.EventHandler(this.BtnNumbers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 153;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(567, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 152;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(668, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 154;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblharfnotu
            // 
            this.lblharfnotu.AutoSize = true;
            this.lblharfnotu.Location = new System.Drawing.Point(440, 247);
            this.lblharfnotu.Name = "lblharfnotu";
            this.lblharfnotu.Size = new System.Drawing.Size(84, 18);
            this.lblharfnotu.TabIndex = 156;
            this.lblharfnotu.Text = "Harf Notu:";
            // 
            // TxtLetterGrade
            // 
            this.TxtLetterGrade.Enabled = false;
            this.TxtLetterGrade.Location = new System.Drawing.Point(571, 244);
            this.TxtLetterGrade.Name = "TxtLetterGrade";
            this.TxtLetterGrade.Size = new System.Drawing.Size(90, 26);
            this.TxtLetterGrade.TabIndex = 155;
            // 
            // FrmAcademicianNotes
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(727, 527);
            this.Controls.Add(this.lblharfnotu);
            this.Controls.Add(this.TxtLetterGrade);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNumbers);
            this.Controls.Add(this.lbldersid);
            this.Controls.Add(this.TxtFinalExam);
            this.Controls.Add(this.TxtMidtermExam);
            this.Controls.Add(this.DtgStudentNotes);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblnotislemleri);
            this.Controls.Add(this.lblortalama);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.lblfinalsinavi);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.lblvizesinavi);
            this.Controls.Add(this.lblogrenciid);
            this.Controls.Add(this.lblderssec);
            this.Controls.Add(this.CmbLesson);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAcademicianNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAcademicianNotes";
            this.Load += new System.EventHandler(this.FrmAcademicianNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudentNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbLesson;
        private System.Windows.Forms.Label lblderssec;
        private System.Windows.Forms.Label lblogrenciid;
        private System.Windows.Forms.Label lblvizesinavi;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label lblfinalsinavi;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label lblortalama;
        private System.Windows.Forms.Label lblnotislemleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView DtgStudentNotes;
        private System.Windows.Forms.TextBox TxtMidtermExam;
        private System.Windows.Forms.TextBox TxtFinalExam;
        private System.Windows.Forms.Label lbldersid;
        private System.Windows.Forms.Button BtnNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblharfnotu;
        private System.Windows.Forms.TextBox TxtLetterGrade;
    }
}