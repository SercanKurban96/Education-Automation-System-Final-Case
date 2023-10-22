namespace EducationAutomationSystem.Academician
{
    partial class FrmSearchAcademician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchAcademician));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgAcademician = new System.Windows.Forms.DataGridView();
            this.TxtAcademicianSearch = new System.Windows.Forms.TextBox();
            this.lbltcnoara = new System.Windows.Forms.Label();
            this.LblAcademicianCount = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblakademisyenaraformu = new System.Windows.Forms.Label();
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.lblakademisyensayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // DtgAcademician
            // 
            this.DtgAcademician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgAcademician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAcademician.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgAcademician.Location = new System.Drawing.Point(0, 309);
            this.DtgAcademician.Name = "DtgAcademician";
            this.DtgAcademician.Size = new System.Drawing.Size(711, 169);
            this.DtgAcademician.TabIndex = 76;
            // 
            // TxtAcademicianSearch
            // 
            this.TxtAcademicianSearch.BackColor = System.Drawing.Color.White;
            this.TxtAcademicianSearch.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAcademicianSearch.Location = new System.Drawing.Point(167, 134);
            this.TxtAcademicianSearch.Name = "TxtAcademicianSearch";
            this.TxtAcademicianSearch.Size = new System.Drawing.Size(316, 32);
            this.TxtAcademicianSearch.TabIndex = 75;
            this.TxtAcademicianSearch.TextChanged += new System.EventHandler(this.TxtAcademicianSearch_TextChanged);
            // 
            // lbltcnoara
            // 
            this.lbltcnoara.AutoSize = true;
            this.lbltcnoara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcnoara.Location = new System.Drawing.Point(28, 142);
            this.lbltcnoara.Name = "lbltcnoara";
            this.lbltcnoara.Size = new System.Drawing.Size(96, 18);
            this.lbltcnoara.TabIndex = 74;
            this.lbltcnoara.Text = "T.C. No Ara:";
            // 
            // LblAcademicianCount
            // 
            this.LblAcademicianCount.AutoSize = true;
            this.LblAcademicianCount.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAcademicianCount.Location = new System.Drawing.Point(203, 252);
            this.LblAcademicianCount.Name = "LblAcademicianCount";
            this.LblAcademicianCount.Size = new System.Drawing.Size(31, 31);
            this.LblAcademicianCount.TabIndex = 73;
            this.LblAcademicianCount.Text = "0";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(0, 0);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(49, 26);
            this.TxtID.TabIndex = 71;
            this.TxtID.Visible = false;
            // 
            // lblakademisyenaraformu
            // 
            this.lblakademisyenaraformu.AutoSize = true;
            this.lblakademisyenaraformu.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyenaraformu.Location = new System.Drawing.Point(158, 9);
            this.lblakademisyenaraformu.Name = "lblakademisyenaraformu";
            this.lblakademisyenaraformu.Size = new System.Drawing.Size(383, 51);
            this.lblakademisyenaraformu.TabIndex = 70;
            this.lblakademisyenaraformu.Text = "AKADEMİSYEN ARA";
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
            this.PctBack.TabIndex = 69;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // lblakademisyensayisi
            // 
            this.lblakademisyensayisi.AutoSize = true;
            this.lblakademisyensayisi.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblakademisyensayisi.Location = new System.Drawing.Point(13, 258);
            this.lblakademisyensayisi.Name = "lblakademisyensayisi";
            this.lblakademisyensayisi.Size = new System.Drawing.Size(184, 23);
            this.lblakademisyensayisi.TabIndex = 132;
            this.lblakademisyensayisi.Text = "Akademisyen Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmSearchAcademician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(711, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblakademisyensayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgAcademician);
            this.Controls.Add(this.TxtAcademicianSearch);
            this.Controls.Add(this.lbltcnoara);
            this.Controls.Add(this.LblAcademicianCount);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.lblakademisyenaraformu);
            this.Controls.Add(this.PctBack);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchAcademician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchAcademician";
            this.Load += new System.EventHandler(this.FrmSearchAcademician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAcademician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgAcademician;
        private System.Windows.Forms.TextBox TxtAcademicianSearch;
        private System.Windows.Forms.Label lbltcnoara;
        private System.Windows.Forms.Label LblAcademicianCount;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label lblakademisyenaraformu;
        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Label lblakademisyensayisi;
        private System.Windows.Forms.Label label1;
    }
}