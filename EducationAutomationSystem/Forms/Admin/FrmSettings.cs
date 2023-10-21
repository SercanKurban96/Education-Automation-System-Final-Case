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

namespace EducationAutomationSystem.Admin
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void PctChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword fr = new FrmChangePassword();
            fr.Show();
            this.Hide();
        }

        private void PctRadio_Click(object sender, EventArgs e)
        {
            FrmRadio fr = new FrmRadio();
            fr.Show();
            //this.Hide();
        }

        private void PctNewspaper_Click(object sender, EventArgs e)
        {
            FrmNewspaper fr = new FrmNewspaper();
            fr.Show();
            //this.Hide();
        }

        private void PctCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void PctMusic_Click(object sender, EventArgs e)
        {
            FrmMusic fr = new FrmMusic();
            fr.Show();
            //this.Hide();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
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

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            lblgazeteler.Text = Localization.lblgazeteler;
            lblhesapmakinesi.Text = Localization.lblhesapmakinesi;
            lblmuzikdinle.Text = Localization.lblmuzikdinle;
            lblradyo.Text = Localization.lblradyo;
            lblsifredegistir.Text = Localization.lblsifredegistir;
            lbluygulamalarformu.Text = Localization.lbluygulamalarformu;
            lbldildegistir.Text = Localization.lbldildegistir;
        }

        private void PctChangeLanguage_Click(object sender, EventArgs e)
        {
            FrmChangeLanguage fr = new FrmChangeLanguage();
            fr.Show();
            this.Hide();
        }
    }
}
