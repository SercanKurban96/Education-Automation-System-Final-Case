namespace EducationAutomationSystem.Forms.ToDoList
{
    partial class FrmAddToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddToDoList));
            this.DtpToDoListDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.RchToDoListContent = new System.Windows.Forms.RichTextBox();
            this.TxtToDoListTitle = new System.Windows.Forms.TextBox();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladdtodolist = new System.Windows.Forms.Label();
            this.lblgorevbasligi = new System.Windows.Forms.Label();
            this.lblgorevtanimi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblToDoListCount = new System.Windows.Forms.Label();
            this.lblgorevsayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpToDoListDate
            // 
            this.DtpToDoListDate.Location = new System.Drawing.Point(12, 1);
            this.DtpToDoListDate.Name = "DtpToDoListDate";
            this.DtpToDoListDate.Size = new System.Drawing.Size(34, 26);
            this.DtpToDoListDate.TabIndex = 37;
            this.DtpToDoListDate.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(380, 307);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 41;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(204, 307);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(149, 43);
            this.BtnAdd.TabIndex = 40;
            this.BtnAdd.Text = "Oluştur";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RchToDoListContent
            // 
            this.RchToDoListContent.Location = new System.Drawing.Point(163, 104);
            this.RchToDoListContent.Name = "RchToDoListContent";
            this.RchToDoListContent.Size = new System.Drawing.Size(409, 187);
            this.RchToDoListContent.TabIndex = 2;
            this.RchToDoListContent.Text = "";
            // 
            // TxtToDoListTitle
            // 
            this.TxtToDoListTitle.Location = new System.Drawing.Point(163, 69);
            this.TxtToDoListTitle.MaxLength = 100;
            this.TxtToDoListTitle.Name = "TxtToDoListTitle";
            this.TxtToDoListTitle.Size = new System.Drawing.Size(409, 26);
            this.TxtToDoListTitle.TabIndex = 1;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(601, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 42;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 138;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lbladdtodolist
            // 
            this.lbladdtodolist.AutoSize = true;
            this.lbladdtodolist.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladdtodolist.Location = new System.Drawing.Point(185, 3);
            this.lbladdtodolist.Name = "lbladdtodolist";
            this.lbladdtodolist.Size = new System.Drawing.Size(335, 51);
            this.lbladdtodolist.TabIndex = 140;
            this.lbladdtodolist.Text = "GÖREV OLUŞTUR";
            // 
            // lblgorevbasligi
            // 
            this.lblgorevbasligi.AutoSize = true;
            this.lblgorevbasligi.Location = new System.Drawing.Point(9, 72);
            this.lblgorevbasligi.Name = "lblgorevbasligi";
            this.lblgorevbasligi.Size = new System.Drawing.Size(106, 18);
            this.lblgorevbasligi.TabIndex = 141;
            this.lblgorevbasligi.Text = "Görev Başlığı:";
            // 
            // lblgorevtanimi
            // 
            this.lblgorevtanimi.AutoSize = true;
            this.lblgorevtanimi.Location = new System.Drawing.Point(9, 107);
            this.lblgorevtanimi.Name = "lblgorevtanimi";
            this.lblgorevtanimi.Size = new System.Drawing.Size(111, 18);
            this.lblgorevtanimi.TabIndex = 142;
            this.lblgorevtanimi.Text = "Görev Tanımı:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // LblToDoListCount
            // 
            this.LblToDoListCount.AutoSize = true;
            this.LblToDoListCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToDoListCount.Location = new System.Drawing.Point(188, 374);
            this.LblToDoListCount.Name = "LblToDoListCount";
            this.LblToDoListCount.Size = new System.Drawing.Size(22, 23);
            this.LblToDoListCount.TabIndex = 145;
            this.LblToDoListCount.Text = "0";
            // 
            // lblgorevsayisi
            // 
            this.lblgorevsayisi.AutoSize = true;
            this.lblgorevsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgorevsayisi.Location = new System.Drawing.Point(8, 374);
            this.lblgorevsayisi.Name = "lblgorevsayisi";
            this.lblgorevsayisi.Size = new System.Drawing.Size(121, 23);
            this.lblgorevsayisi.TabIndex = 144;
            this.lblgorevsayisi.Text = "Görev Sayısı:";
            // 
            // FrmAddToDoList
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(661, 416);
            this.Controls.Add(this.LblToDoListCount);
            this.Controls.Add(this.lblgorevsayisi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblgorevtanimi);
            this.Controls.Add(this.lblgorevbasligi);
            this.Controls.Add(this.lbladdtodolist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.RchToDoListContent);
            this.Controls.Add(this.TxtToDoListTitle);
            this.Controls.Add(this.DtpToDoListDate);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddToDoList";
            this.Load += new System.EventHandler(this.FrmAddToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpToDoListDate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RichTextBox RchToDoListContent;
        private System.Windows.Forms.TextBox TxtToDoListTitle;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladdtodolist;
        private System.Windows.Forms.Label lblgorevbasligi;
        private System.Windows.Forms.Label lblgorevtanimi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblToDoListCount;
        private System.Windows.Forms.Label lblgorevsayisi;
    }
}