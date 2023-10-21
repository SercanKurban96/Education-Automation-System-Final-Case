using EducationAutomationSystem.Applications;
using EducationAutomationSystem.Forms.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void PctExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //FrmStudentPanel fr = new FrmStudentPanel();
            //fr.Show();
            //this.Hide();
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
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

        private void FrmStudentApplication_Load(object sender, EventArgs e)
        {
            lblgazeteler.Text = Localization.lblgazeteler;
            lblhesapmakinesi.Text = Localization.lblhesapmakinesi;
            lblmuzikdinle.Text = Localization.lblmuzikdinle;
            lblradyo.Text = Localization.lblradyo;
            lbluygulamalarformu.Text = Localization.lbluygulamalarformu;
        }
    }
}
