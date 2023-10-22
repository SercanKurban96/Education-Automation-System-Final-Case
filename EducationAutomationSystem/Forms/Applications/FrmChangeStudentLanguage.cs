using EducationAutomationSystem.Admin;
using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.Student;
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

namespace EducationAutomationSystem.Forms.Applications
{
    public partial class FrmChangeStudentLanguage : Form
    {
        public FrmChangeStudentLanguage()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        int studentid;
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
            FrmStudentApplication fr = new FrmStudentApplication();
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
                FrmStudentApplication fr = new FrmStudentApplication();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
            else if (rdbenglish.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
                FrmStudentApplication fr = new FrmStudentApplication();
                fr.number = number;
                fr.Show();
                this.Hide();
            }
        }

        private void FrmChangeStudentLanguage_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();
        }
    }
}
