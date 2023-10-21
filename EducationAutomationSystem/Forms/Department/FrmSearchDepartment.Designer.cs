namespace EducationAutomationSystem.Department
{
    partial class FrmSearchDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchDepartment));
            this.TxtDepartmentSearch = new System.Windows.Forms.TextBox();
            this.LblDepartmentCount = new System.Windows.Forms.Label();
            this.TxtDepartmentID = new System.Windows.Forms.TextBox();
            this.lblsearchdepartmentmenu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.DtgDepartment = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblbolumsayisi = new System.Windows.Forms.Label();
            this.lblbolumara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDepartmentSearch
            // 
            this.TxtDepartmentSearch.BackColor = System.Drawing.Color.White;
            this.TxtDepartmentSearch.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDepartmentSearch.Location = new System.Drawing.Point(198, 131);
            this.TxtDepartmentSearch.Name = "TxtDepartmentSearch";
            this.TxtDepartmentSearch.Size = new System.Drawing.Size(316, 32);
            this.TxtDepartmentSearch.TabIndex = 48;
            this.TxtDepartmentSearch.TextChanged += new System.EventHandler(this.TxtDepartmentSearch_TextChanged);
            // 
            // LblDepartmentCount
            // 
            this.LblDepartmentCount.AutoSize = true;
            this.LblDepartmentCount.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDepartmentCount.Location = new System.Drawing.Point(192, 249);
            this.LblDepartmentCount.Name = "LblDepartmentCount";
            this.LblDepartmentCount.Size = new System.Drawing.Size(22, 24);
            this.LblDepartmentCount.TabIndex = 46;
            this.LblDepartmentCount.Text = "0";
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.Location = new System.Drawing.Point(0, -3);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.Size = new System.Drawing.Size(49, 26);
            this.TxtDepartmentID.TabIndex = 44;
            this.TxtDepartmentID.Visible = false;
            // 
            // lblsearchdepartmentmenu
            // 
            this.lblsearchdepartmentmenu.AutoSize = true;
            this.lblsearchdepartmentmenu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsearchdepartmentmenu.Location = new System.Drawing.Point(219, 9);
            this.lblsearchdepartmentmenu.Name = "lblsearchdepartmentmenu";
            this.lblsearchdepartmentmenu.Size = new System.Drawing.Size(247, 51);
            this.lblsearchdepartmentmenu.TabIndex = 42;
            this.lblsearchdepartmentmenu.Text = "BÖLÜM ARA";
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(650, 2);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 41;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // DtgDepartment
            // 
            this.DtgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgDepartment.Location = new System.Drawing.Point(0, 296);
            this.DtgDepartment.Name = "DtgDepartment";
            this.DtgDepartment.Size = new System.Drawing.Size(711, 169);
            this.DtgDepartment.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(565, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblbolumsayisi
            // 
            this.lblbolumsayisi.AutoSize = true;
            this.lblbolumsayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumsayisi.Location = new System.Drawing.Point(12, 253);
            this.lblbolumsayisi.Name = "lblbolumsayisi";
            this.lblbolumsayisi.Size = new System.Drawing.Size(103, 18);
            this.lblbolumsayisi.TabIndex = 52;
            this.lblbolumsayisi.Text = "Bölüm Sayısı:";
            // 
            // lblbolumara
            // 
            this.lblbolumara.AutoSize = true;
            this.lblbolumara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbolumara.Location = new System.Drawing.Point(12, 139);
            this.lblbolumara.Name = "lblbolumara";
            this.lblbolumara.Size = new System.Drawing.Size(88, 18);
            this.lblbolumara.TabIndex = 51;
            this.lblbolumara.Text = "Bölüm Ara:";
            // 
            // FrmSearchDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 465);
            this.Controls.Add(this.lblbolumsayisi);
            this.Controls.Add(this.lblbolumara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgDepartment);
            this.Controls.Add(this.TxtDepartmentSearch);
            this.Controls.Add(this.LblDepartmentCount);
            this.Controls.Add(this.TxtDepartmentID);
            this.Controls.Add(this.lblsearchdepartmentmenu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchDepartment";
            this.Load += new System.EventHandler(this.FrmSearchDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDepartmentSearch;
        private System.Windows.Forms.Label LblDepartmentCount;
        private System.Windows.Forms.TextBox TxtDepartmentID;
        private System.Windows.Forms.Label lblsearchdepartmentmenu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.DataGridView DtgDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblbolumsayisi;
        private System.Windows.Forms.Label lblbolumara;
    }
}