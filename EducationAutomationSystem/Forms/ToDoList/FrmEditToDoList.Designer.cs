namespace EducationAutomationSystem.Forms.ToDoList
{
    partial class FrmEditToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditToDoList));
            this.DtgToDoList = new System.Windows.Forms.DataGridView();
            this.LblToDoListCount = new System.Windows.Forms.Label();
            this.lblgorevsayisi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblgorevtanimi = new System.Windows.Forms.Label();
            this.lblgorevbasligi = new System.Windows.Forms.Label();
            this.lbledittodolist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RchToDoListContent = new System.Windows.Forms.RichTextBox();
            this.TxtToDoListTitle = new System.Windows.Forms.TextBox();
            this.DtpToDoListDate = new System.Windows.Forms.DateTimePicker();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgToDoList
            // 
            this.DtgToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgToDoList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgToDoList.Location = new System.Drawing.Point(0, 348);
            this.DtgToDoList.Name = "DtgToDoList";
            this.DtgToDoList.Size = new System.Drawing.Size(766, 150);
            this.DtgToDoList.TabIndex = 174;
            this.DtgToDoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgToDoList_CellClick);
            // 
            // LblToDoListCount
            // 
            this.LblToDoListCount.AutoSize = true;
            this.LblToDoListCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToDoListCount.Location = new System.Drawing.Point(188, 307);
            this.LblToDoListCount.Name = "LblToDoListCount";
            this.LblToDoListCount.Size = new System.Drawing.Size(22, 23);
            this.LblToDoListCount.TabIndex = 172;
            this.LblToDoListCount.Text = "0";
            // 
            // lblgorevsayisi
            // 
            this.lblgorevsayisi.AutoSize = true;
            this.lblgorevsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgorevsayisi.Location = new System.Drawing.Point(8, 307);
            this.lblgorevsayisi.Name = "lblgorevsayisi";
            this.lblgorevsayisi.Size = new System.Drawing.Size(121, 23);
            this.lblgorevsayisi.TabIndex = 171;
            this.lblgorevsayisi.Text = "Görev Sayısı:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 170;
            this.pictureBox2.TabStop = false;
            // 
            // lblgorevtanimi
            // 
            this.lblgorevtanimi.AutoSize = true;
            this.lblgorevtanimi.Location = new System.Drawing.Point(9, 107);
            this.lblgorevtanimi.Name = "lblgorevtanimi";
            this.lblgorevtanimi.Size = new System.Drawing.Size(111, 18);
            this.lblgorevtanimi.TabIndex = 169;
            this.lblgorevtanimi.Text = "Görev Tanımı:";
            // 
            // lblgorevbasligi
            // 
            this.lblgorevbasligi.AutoSize = true;
            this.lblgorevbasligi.Location = new System.Drawing.Point(9, 72);
            this.lblgorevbasligi.Name = "lblgorevbasligi";
            this.lblgorevbasligi.Size = new System.Drawing.Size(106, 18);
            this.lblgorevbasligi.TabIndex = 168;
            this.lblgorevbasligi.Text = "Görev Başlığı:";
            // 
            // lbledittodolist
            // 
            this.lbledittodolist.AutoSize = true;
            this.lbledittodolist.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbledittodolist.Location = new System.Drawing.Point(225, 3);
            this.lbledittodolist.Name = "lbledittodolist";
            this.lbledittodolist.Size = new System.Drawing.Size(341, 51);
            this.lbledittodolist.TabIndex = 167;
            this.lbledittodolist.Text = "GÖREV DÜZENLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 166;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(707, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 165;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(590, 214);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(149, 43);
            this.BtnCancel.TabIndex = 164;
            this.BtnCancel.Text = "İptal Et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RchToDoListContent
            // 
            this.RchToDoListContent.Enabled = false;
            this.RchToDoListContent.Location = new System.Drawing.Point(163, 104);
            this.RchToDoListContent.Name = "RchToDoListContent";
            this.RchToDoListContent.Size = new System.Drawing.Size(409, 187);
            this.RchToDoListContent.TabIndex = 162;
            this.RchToDoListContent.Text = "";
            // 
            // TxtToDoListTitle
            // 
            this.TxtToDoListTitle.Enabled = false;
            this.TxtToDoListTitle.Location = new System.Drawing.Point(163, 69);
            this.TxtToDoListTitle.MaxLength = 100;
            this.TxtToDoListTitle.Name = "TxtToDoListTitle";
            this.TxtToDoListTitle.Size = new System.Drawing.Size(409, 26);
            this.TxtToDoListTitle.TabIndex = 161;
            // 
            // DtpToDoListDate
            // 
            this.DtpToDoListDate.Location = new System.Drawing.Point(12, 1);
            this.DtpToDoListDate.Name = "DtpToDoListDate";
            this.DtpToDoListDate.Size = new System.Drawing.Size(34, 26);
            this.DtpToDoListDate.TabIndex = 163;
            this.DtpToDoListDate.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(590, 140);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 43);
            this.BtnEdit.TabIndex = 175;
            this.BtnEdit.Text = "Düzenle";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmEditToDoList
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(766, 498);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.DtgToDoList);
            this.Controls.Add(this.LblToDoListCount);
            this.Controls.Add(this.lblgorevsayisi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblgorevtanimi);
            this.Controls.Add(this.lblgorevbasligi);
            this.Controls.Add(this.lbledittodolist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.RchToDoListContent);
            this.Controls.Add(this.TxtToDoListTitle);
            this.Controls.Add(this.DtpToDoListDate);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditToDoList";
            this.Load += new System.EventHandler(this.FrmEditToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgToDoList;
        private System.Windows.Forms.Label LblToDoListCount;
        private System.Windows.Forms.Label lblgorevsayisi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblgorevtanimi;
        private System.Windows.Forms.Label lblgorevbasligi;
        private System.Windows.Forms.Label lbledittodolist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RichTextBox RchToDoListContent;
        private System.Windows.Forms.TextBox TxtToDoListTitle;
        private System.Windows.Forms.DateTimePicker DtpToDoListDate;
        private System.Windows.Forms.Button BtnEdit;
    }
}