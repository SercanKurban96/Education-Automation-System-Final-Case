using EducationAutomationSystem.Admin;
using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms
{
    public partial class FrmChangeAcademicianLanguage : Form
    {
        public FrmChangeAcademicianLanguage()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;

        private void pctturkce_Click(object sender, EventArgs e)
        {
            rdbturkce.Checked = true;
        }

        private void pctenglish_Click(object sender, EventArgs e)
        {
            rdbenglish.Checked = true;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademicianApplication fr = new FrmAcademicianApplication();
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

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (rdbturkce.Checked)
            {
                Localization.Culture = new CultureInfo("");
                FrmAcademicianApplication fr = new FrmAcademicianApplication();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
            else if (rdbenglish.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
                FrmAcademicianApplication fr = new FrmAcademicianApplication();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
        }

        private void FrmChangeAcademicianLanguage_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();
        }
    }
}
