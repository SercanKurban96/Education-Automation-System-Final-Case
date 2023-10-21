using EducationAutomationSystem.Academician;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem
{
    public partial class FrmAcademician : Form
    {
        public FrmAcademician()
        {
            InitializeComponent();
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

        private void PctAddAcademician_Click(object sender, EventArgs e)
        {
            FrmAddAcademician fr = new FrmAddAcademician();
            fr.Show();
            this.Hide();
        }

        private void PctDeleteAcademician_Click(object sender, EventArgs e)
        {
            FrmDeleteAcademician fr = new FrmDeleteAcademician();
            fr.Show();
            this.Hide();
        }

        private void PctEditAcademician_Click(object sender, EventArgs e)
        {
            FrmEditAcademician fr = new FrmEditAcademician();
            fr.Show();
            this.Hide();
        }

        private void PctListAcademician_Click(object sender, EventArgs e)
        {
            FrmListAcademician fr = new FrmListAcademician();
            fr.Show();
        }

        private void PctSearchAcademician_Click(object sender, EventArgs e)
        {
            FrmSearchAcademician fr = new FrmSearchAcademician();
            fr.Show();
            this.Hide();
        }

        private void FrmAcademician_Load(object sender, EventArgs e)
        {
            lblakademisyenara.Text = Localization.lblakademisyenara;
            lblakademisyenduzenle.Text = Localization.lblakademisyenduzenle;
            lblakademisyenkayit.Text = Localization.lblakademisyenkayit;
            lblakademisyenlistesi.Text = Localization.lblakademisyenlistesi;
            lblakademisyenpanel.Text = Localization.lblakademisyenpanel;
            lblakademisyensil.Text = Localization.lblakademisyensil;
        }
    }
}
