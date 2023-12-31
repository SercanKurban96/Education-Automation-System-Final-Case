﻿using EducationAutomationSystem.Admin;
using EducationAutomationSystem.Entity;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.Applications
{
    public partial class FrmChangeLanguage : Form
    {
        public FrmChangeLanguage()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (rdbturkce.Checked)
            {
                Localization.Culture = new CultureInfo("");
                FrmSettings fr = new FrmSettings();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
            else if (rdbenglish.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
                FrmSettings fr = new FrmSettings();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmSettings fr = new FrmSettings();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void pctturkce_Click(object sender, EventArgs e)
        {
            rdbturkce.Checked = true;
        }

        private void pctenglish_Click(object sender, EventArgs e)
        {
            rdbenglish.Checked = true;
        }

        private void FrmChangeLanguage_Load(object sender, EventArgs e)
        {
            //adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            //label1.Text = adminid.ToString();
        }
    }
}
