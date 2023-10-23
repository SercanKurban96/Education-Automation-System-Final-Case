namespace EducationAutomationSystem.Forms.ToDoList
{
    partial class FrmListToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListToDoList));
            this.DtgToDoList = new System.Windows.Forms.DataGridView();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lbltodolists = new System.Windows.Forms.Label();
            this.LblToDoListCount = new System.Windows.Forms.Label();
            this.lblgorevsayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgToDoList
            // 
            this.DtgToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgToDoList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgToDoList.Location = new System.Drawing.Point(0, 62);
            this.DtgToDoList.Name = "DtgToDoList";
            this.DtgToDoList.Size = new System.Drawing.Size(812, 403);
            this.DtgToDoList.TabIndex = 175;
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(752, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 176;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lbltodolists
            // 
            this.lbltodolists.AutoSize = true;
            this.lbltodolists.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltodolists.Location = new System.Drawing.Point(218, 3);
            this.lbltodolists.Name = "lbltodolists";
            this.lbltodolists.Size = new System.Drawing.Size(442, 51);
            this.lbltodolists.TabIndex = 177;
            this.lbltodolists.Text = "YAPILACAKLAR LİSTESİ";
            // 
            // LblToDoListCount
            // 
            this.LblToDoListCount.AutoSize = true;
            this.LblToDoListCount.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToDoListCount.Location = new System.Drawing.Point(147, 16);
            this.LblToDoListCount.Name = "LblToDoListCount";
            this.LblToDoListCount.Size = new System.Drawing.Size(22, 23);
            this.LblToDoListCount.TabIndex = 179;
            this.LblToDoListCount.Text = "0";
            // 
            // lblgorevsayisi
            // 
            this.lblgorevsayisi.AutoSize = true;
            this.lblgorevsayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgorevsayisi.Location = new System.Drawing.Point(4, 16);
            this.lblgorevsayisi.Name = "lblgorevsayisi";
            this.lblgorevsayisi.Size = new System.Drawing.Size(121, 23);
            this.lblgorevsayisi.TabIndex = 178;
            this.lblgorevsayisi.Text = "Görev Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 180;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmListToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblToDoListCount);
            this.Controls.Add(this.lblgorevsayisi);
            this.Controls.Add(this.lbltodolists);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.DtgToDoList);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListToDoList";
            this.Load += new System.EventHandler(this.FrmListToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgToDoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgToDoList;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lbltodolists;
        private System.Windows.Forms.Label LblToDoListCount;
        private System.Windows.Forms.Label lblgorevsayisi;
        private System.Windows.Forms.Label label1;
    }
}