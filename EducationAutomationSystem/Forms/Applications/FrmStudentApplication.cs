﻿using EducationAutomationSystem.Applications;
using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.Student
{
    public partial class FrmStudentApplication : Form
    {
        public FrmStudentApplication()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        int studentid;
        private void PctExit_Click(object sender, EventArgs e)
        {
            FrmStudentPanel fr = new FrmStudentPanel();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctNewspaper_Click(object sender, EventArgs e)
        {
            FrmNewspaper fr = new FrmNewspaper();
            fr.Show();
        }

        private void PctRadio_Click(object sender, EventArgs e)
        {
            FrmRadio fr = new FrmRadio();
            fr.Show();
        }

        private void PctMusic_Click(object sender, EventArgs e)
        {
            FrmMusic fr = new FrmMusic();
            fr.Show();
        }

        private void PctCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmStudentPanel fr = new FrmStudentPanel();
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

        private void FrmStudentApplication_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            lblgazeteler.Text = Localization.lblgazeteler;
            lblhesapmakinesi.Text = Localization.lblhesapmakinesi;
            lblmuzikdinle.Text = Localization.lblmuzikdinle;
            lblradyo.Text = Localization.lblradyo;
            lbluygulamalarformu.Text = Localization.lbluygulamalarformu;
            lbldildegistir.Text = Localization.lbldildegistir;
        }

        private void PctChangeLanguage_Click(object sender, EventArgs e)
        {
            FrmChangeStudentLanguage fr = new FrmChangeStudentLanguage();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
    }
}
