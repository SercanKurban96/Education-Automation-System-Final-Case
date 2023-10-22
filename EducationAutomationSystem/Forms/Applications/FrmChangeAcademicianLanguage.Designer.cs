namespace EducationAutomationSystem.Forms
{
    partial class FrmChangeAcademicianLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeAcademicianLanguage));
            this.PctBack = new System.Windows.Forms.PictureBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.pctenglish = new System.Windows.Forms.PictureBox();
            this.pctturkce = new System.Windows.Forms.PictureBox();
            this.rdbenglish = new System.Windows.Forms.RadioButton();
            this.rdbturkce = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctenglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctturkce)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBack
            // 
            this.PctBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBack.Image = ((System.Drawing.Image)(resources.GetObject("PctBack.Image")));
            this.PctBack.Location = new System.Drawing.Point(475, 1);
            this.PctBack.Name = "PctBack";
            this.PctBack.Size = new System.Drawing.Size(58, 53);
            this.PctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBack.TabIndex = 43;
            this.PctBack.TabStop = false;
            this.PctBack.Click += new System.EventHandler(this.PctBack_Click);
            this.PctBack.MouseLeave += new System.EventHandler(this.PctBack_MouseLeave);
            this.PctBack.MouseHover += new System.EventHandler(this.PctBack_MouseHover);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.Transparent;
            this.BtnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnChange.BackgroundImage")));
            this.BtnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Location = new System.Drawing.Point(215, 187);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(90, 65);
            this.BtnChange.TabIndex = 42;
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // pctenglish
            // 
            this.pctenglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctenglish.Image = ((System.Drawing.Image)(resources.GetObject("pctenglish.Image")));
            this.pctenglish.Location = new System.Drawing.Point(317, 84);
            this.pctenglish.Name = "pctenglish";
            this.pctenglish.Size = new System.Drawing.Size(100, 50);
            this.pctenglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctenglish.TabIndex = 41;
            this.pctenglish.TabStop = false;
            this.pctenglish.Click += new System.EventHandler(this.pctenglish_Click);
            // 
            // pctturkce
            // 
            this.pctturkce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctturkce.Image = ((System.Drawing.Image)(resources.GetObject("pctturkce.Image")));
            this.pctturkce.Location = new System.Drawing.Point(108, 84);
            this.pctturkce.Name = "pctturkce";
            this.pctturkce.Size = new System.Drawing.Size(100, 50);
            this.pctturkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctturkce.TabIndex = 40;
            this.pctturkce.TabStop = false;
            this.pctturkce.Click += new System.EventHandler(this.pctturkce_Click);
            // 
            // rdbenglish
            // 
            this.rdbenglish.AutoSize = true;
            this.rdbenglish.ForeColor = System.Drawing.Color.White;
            this.rdbenglish.Location = new System.Drawing.Point(319, 141);
            this.rdbenglish.Margin = new System.Windows.Forms.Padding(4);
            this.rdbenglish.Name = "rdbenglish";
            this.rdbenglish.Size = new System.Drawing.Size(98, 22);
            this.rdbenglish.TabIndex = 39;
            this.rdbenglish.TabStop = true;
            this.rdbenglish.Text = "ENGLISH";
            this.rdbenglish.UseVisualStyleBackColor = true;
            // 
            // rdbturkce
            // 
            this.rdbturkce.AutoSize = true;
            this.rdbturkce.ForeColor = System.Drawing.Color.White;
            this.rdbturkce.Location = new System.Drawing.Point(113, 141);
            this.rdbturkce.Margin = new System.Windows.Forms.Padding(4);
            this.rdbturkce.Name = "rdbturkce";
            this.rdbturkce.Size = new System.Drawing.Size(91, 22);
            this.rdbturkce.TabIndex = 38;
            this.rdbturkce.TabStop = true;
            this.rdbturkce.Text = "TÜRKÇE";
            this.rdbturkce.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // FrmChangeAcademicianLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(535, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctBack);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.pctenglish);
            this.Controls.Add(this.pctturkce);
            this.Controls.Add(this.rdbenglish);
            this.Controls.Add(this.rdbturkce);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChangeAcademicianLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangeAcademicianLanguage";
            this.Load += new System.EventHandler(this.FrmChangeAcademicianLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctenglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctturkce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBack;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.PictureBox pctenglish;
        private System.Windows.Forms.PictureBox pctturkce;
        private System.Windows.Forms.RadioButton rdbenglish;
        private System.Windows.Forms.RadioButton rdbturkce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}