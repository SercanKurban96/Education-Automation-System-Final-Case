namespace EducationAutomationSystem
{
    partial class FrmLanguage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLanguage));
            this.BtnChoose = new System.Windows.Forms.Button();
            this.rdbturkce = new System.Windows.Forms.RadioButton();
            this.rdbenglish = new System.Windows.Forms.RadioButton();
            this.pctturkce = new System.Windows.Forms.PictureBox();
            this.pctenglish = new System.Windows.Forms.PictureBox();
            this.lblegitimotomasyonsistemi = new System.Windows.Forms.Label();
            this.PctExit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctturkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctenglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnChoose
            // 
            this.BtnChoose.BackColor = System.Drawing.Color.Transparent;
            this.BtnChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnChoose.BackgroundImage")));
            this.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChoose.Location = new System.Drawing.Point(192, 230);
            this.BtnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(70, 61);
            this.BtnChoose.TabIndex = 0;
            this.BtnChoose.UseVisualStyleBackColor = false;
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // rdbturkce
            // 
            this.rdbturkce.AutoSize = true;
            this.rdbturkce.ForeColor = System.Drawing.Color.White;
            this.rdbturkce.Location = new System.Drawing.Point(82, 173);
            this.rdbturkce.Margin = new System.Windows.Forms.Padding(4);
            this.rdbturkce.Name = "rdbturkce";
            this.rdbturkce.Size = new System.Drawing.Size(91, 22);
            this.rdbturkce.TabIndex = 1;
            this.rdbturkce.TabStop = true;
            this.rdbturkce.Text = "TÜRKÇE";
            this.rdbturkce.UseVisualStyleBackColor = true;
            // 
            // rdbenglish
            // 
            this.rdbenglish.AutoSize = true;
            this.rdbenglish.ForeColor = System.Drawing.Color.White;
            this.rdbenglish.Location = new System.Drawing.Point(288, 173);
            this.rdbenglish.Margin = new System.Windows.Forms.Padding(4);
            this.rdbenglish.Name = "rdbenglish";
            this.rdbenglish.Size = new System.Drawing.Size(98, 22);
            this.rdbenglish.TabIndex = 2;
            this.rdbenglish.TabStop = true;
            this.rdbenglish.Text = "ENGLISH";
            this.rdbenglish.UseVisualStyleBackColor = true;
            // 
            // pctturkce
            // 
            this.pctturkce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctturkce.Image = ((System.Drawing.Image)(resources.GetObject("pctturkce.Image")));
            this.pctturkce.Location = new System.Drawing.Point(77, 116);
            this.pctturkce.Name = "pctturkce";
            this.pctturkce.Size = new System.Drawing.Size(100, 50);
            this.pctturkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctturkce.TabIndex = 3;
            this.pctturkce.TabStop = false;
            this.pctturkce.Click += new System.EventHandler(this.pctturkce_Click);
            // 
            // pctenglish
            // 
            this.pctenglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctenglish.Image = ((System.Drawing.Image)(resources.GetObject("pctenglish.Image")));
            this.pctenglish.Location = new System.Drawing.Point(286, 116);
            this.pctenglish.Name = "pctenglish";
            this.pctenglish.Size = new System.Drawing.Size(100, 50);
            this.pctenglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctenglish.TabIndex = 4;
            this.pctenglish.TabStop = false;
            this.pctenglish.Click += new System.EventHandler(this.pctenglish_Click);
            // 
            // lblegitimotomasyonsistemi
            // 
            this.lblegitimotomasyonsistemi.AutoSize = true;
            this.lblegitimotomasyonsistemi.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblegitimotomasyonsistemi.ForeColor = System.Drawing.Color.White;
            this.lblegitimotomasyonsistemi.Location = new System.Drawing.Point(22, 9);
            this.lblegitimotomasyonsistemi.Name = "lblegitimotomasyonsistemi";
            this.lblegitimotomasyonsistemi.Size = new System.Drawing.Size(1867, 31);
            this.lblegitimotomasyonsistemi.TabIndex = 5;
            this.lblegitimotomasyonsistemi.Text = "                    Eğitim Otomasyon Sistemi\'ne Hoş Geldiniz...                  " +
    "                          Welcome to the Education Automation System...         " +
    "                               ";
            this.lblegitimotomasyonsistemi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctExit
            // 
            this.PctExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctExit.Image = ((System.Drawing.Image)(resources.GetObject("PctExit.Image")));
            this.PctExit.Location = new System.Drawing.Point(415, 1);
            this.PctExit.Name = "PctExit";
            this.PctExit.Size = new System.Drawing.Size(58, 53);
            this.PctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctExit.TabIndex = 8;
            this.PctExit.TabStop = false;
            this.PctExit.Click += new System.EventHandler(this.PctExit_Click);
            this.PctExit.MouseLeave += new System.EventHandler(this.PctExit_MouseLeave);
            this.PctExit.MouseHover += new System.EventHandler(this.PctExit_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // FrmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(473, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctExit);
            this.Controls.Add(this.lblegitimotomasyonsistemi);
            this.Controls.Add(this.pctenglish);
            this.Controls.Add(this.pctturkce);
            this.Controls.Add(this.rdbenglish);
            this.Controls.Add(this.rdbturkce);
            this.Controls.Add(this.BtnChoose);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLanguage";
            this.Load += new System.EventHandler(this.FrmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctturkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctenglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChoose;
        private System.Windows.Forms.RadioButton rdbturkce;
        private System.Windows.Forms.RadioButton rdbenglish;
        private System.Windows.Forms.PictureBox pctturkce;
        private System.Windows.Forms.PictureBox pctenglish;
        private System.Windows.Forms.Label lblegitimotomasyonsistemi;
        private System.Windows.Forms.PictureBox PctExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}