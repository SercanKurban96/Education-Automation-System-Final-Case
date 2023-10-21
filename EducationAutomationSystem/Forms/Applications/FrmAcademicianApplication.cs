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

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void PctChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangeAcademicianPassword fr = new FrmChangeAcademicianPassword();
            fr.number = number;
            fr.Show();
        }
        public string number, namesurname, picture;

        public int academicianid;
        private void FrmAcademicianApplication_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            label1.Text = academicianid.ToString();

            lblgazeteler.Text = Localization.lblgazeteler;
            lblhesapmakinesi.Text = Localization.lblhesapmakinesi;
            lblmuzikdinle.Text = Localization.lblmuzikdinle;
            lblradyo.Text = Localization.lblradyo;
            lblsifredegistir.Text = Localization.lblsifredegistir;
            lbluygulamalarformu.Text = Localization.lbluygulamalarformu;
        }
    }
}
