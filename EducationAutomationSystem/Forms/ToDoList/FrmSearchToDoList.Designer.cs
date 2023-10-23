namespace EducationAutomationSystem.Forms.ToDoList
{
    partial class FrmSearchToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchToDoList));
            this.DtgToDoList = new System.Windows.Forms.DataGridView();
            this.lblsearchtodolist = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblgorevbaslikara = new System.Windows.Forms.Label();
            this.TxtSearchToDoList = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblToDoListCount = new System.Windows.Forms.Label();
            this.lblgorevsayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgToDoList
            // 
            this.DtgToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgToDoList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgToDoList.Location = new System.Drawing.Point(0, 288);
            this.DtgToDoList.Name = "DtgToDoList";
            this.DtgToDoList.Size = new System.Drawing.Size(718, 156);
            this.DtgToDoList.TabIndex = 176;
            // 
            // lblsearchtodolist
            // 
            this.lblsearchtodolist.AutoSize = true;
            this.lblsearchtodolist.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsearchtodolist.Location = new System.Drawing.Point(212, 9);
            this.lblsearchtodolist.Name = "lblsearchtodolist";
            this.lblsearchtodolist.Size = new System.Drawing.Size(247, 51);
            this.lblsearchtodolist.TabIndex = 177;
            this.lblsearchtodolist.Text = "GÖREV ARA";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(657, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 178;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblgorevbaslikara
            // 
            this.lblgorevbaslikara.AutoSize = true;
            this.lblgorevbaslikara.Location = new System.Drawing.Point(25, 134);
            this.lblgorevbaslikara.Name = "lblgorevbaslikara";
            this.lblgorevbaslikara.Size = new System.Drawing.Size(87, 18);
            this.lblgorevbaslikara.TabIndex = 180;
            this.lblgorevbaslikara.Text = "Görev Ara:";
            // 
            // TxtSearchToDoList
            // 
            this.TxtSearchToDoList.Location = new System.Drawing.Point(155, 131);
            this.TxtSearchToDoList.MaxLength = 100;
            this.TxtSearchToDoList.Name = "TxtSearchToDoList";
            this.TxtSearchToDoList.Size = new System.Drawing.Size(382, 26);
            this.TxtSearchToDoList.TabIndex = 179;
            this.TxtSearchToDoList.TextChanged += new System.EventHandler(this.TxtSearchToDoList_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 181;
            this.pictureBox1.TabStop = false;
            // 
            // LblToDoListCount
            // 
            this.LblToDoListCount.AutoSize = true;
            this.LblToDoListCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToDoListCount.Location = new System.Drawing.Point(192, 246);
            this.LblToDoListCount.Name = "LblToDoListCount";
            this.LblToDoListCount.Size = new System.Drawing.Size(22, 23);
            this.LblToDoListCount.TabIndex = 183;
            this.LblToDoListCount.Text = "0";
            // 
            // lblgorevsayisi
            // 
            this.lblgorevsayisi.AutoSize = true;
            this.lblgorevsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgorevsayisi.Location = new System.Drawing.Point(12, 246);
            this.lblgorevsayisi.Name = "lblgorevsayisi";
            this.lblgorevsayisi.Size = new System.Drawing.Size(121, 23);
            this.lblgorevsayisi.TabIndex = 182;
            this.lblgorevsayisi.Text = "Görev Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 184;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmSearchToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(718, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblToDoListCount);
            this.Controls.Add(this.lblgorevsayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblgorevbaslikara);
            this.Controls.Add(this.TxtSearchToDoList);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.lblsearchtodolist);
            this.Controls.Add(this.DtgToDoList);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchToDoList";
            this.Load += new System.EventHandler(this.FrmSearchToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgToDoList;
        private System.Windows.Forms.Label lblsearchtodolist;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblgorevbaslikara;
        private System.Windows.Forms.TextBox TxtSearchToDoList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblToDoListCount;
        private System.Windows.Forms.Label lblgorevsayisi;
        private System.Windows.Forms.Label label1;
    }
}