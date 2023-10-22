using EducationAutomationSystem.Academician;
using EducationAutomationSystem.Applications;
using EducationAutomationSystem.Entity;
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

namespace EducationAutomationSystem.Forms.Applications
{
    public partial class FrmAcademicianApplication : Form
    {
        public FrmAcademicianApplication()
        {
            InitializeComponent();
        }

        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        private void PctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctRadio_Click(object sender, EventArgs e)
        {
            FrmRadio fr = new FrmRadio();
            fr.Show();
        }

        private void PctCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void PctNewspaper_Click(object sender, EventArgs e)
        {
            FrmNewspaper fr = new FrmNewspaper();
            fr.Show();
        }

        private void PctMusic_Click(object sender, EventArgs e)
        {
            FrmMusic fr = new FrmMusic();
            fr.Show();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademicianPanel fr = new FrmAcademicianPanel();
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

        private void PctChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangeAcademicianPassword fr = new FrmChangeAcademicianPassword();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
        

        private void PctChangeLanguage_Click(object sender, EventArgs e)
        {
            FrmChangeAcademicianLanguage fr = new FrmChangeAcademicianLanguage();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void FrmAcademicianApplication_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            lblgazeteler.Text = Localization.lblgazeteler;
            lblhesapmakinesi.Text = Localization.lblhesapmakinesi;
            lblmuzikdinle.Text = Localization.lblmuzikdinle;
            lblradyo.Text = Localization.lblradyo;
            lblsifredegistir.Text = Localization.lblsifredegistir;
            lbluygulamalarformu.Text = Localization.lbluygulamalarformu;
            lbldildegistir.Text = Localization.lbldildegistir;
        }
    }
}
