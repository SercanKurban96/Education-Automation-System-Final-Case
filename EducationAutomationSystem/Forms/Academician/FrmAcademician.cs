using EducationAutomationSystem.Academician;
using EducationAutomationSystem.Entity;
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
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
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

        private void PctAddAcademician_Click(object sender, EventArgs e)
        {
            FrmAddAcademician fr = new FrmAddAcademician();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctDeleteAcademician_Click(object sender, EventArgs e)
        {
            FrmDeleteAcademician fr = new FrmDeleteAcademician();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctEditAcademician_Click(object sender, EventArgs e)
        {
            FrmEditAcademician fr = new FrmEditAcademician();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctListAcademician_Click(object sender, EventArgs e)
        {
            FrmListAcademician fr = new FrmListAcademician();
            fr.number = number;
            fr.Show();
        }

        private void PctSearchAcademician_Click(object sender, EventArgs e)
        {
            FrmSearchAcademician fr = new FrmSearchAcademician();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void FrmAcademician_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            lblakademisyenara.Text = Localization.lblakademisyenara;
            lblakademisyenduzenle.Text = Localization.lblakademisyenduzenle;
            lblakademisyenkayit.Text = Localization.lblakademisyenkayit;
            lblakademisyenlistesi.Text = Localization.lblakademisyenlistesi;
            lblakademisyenpanel.Text = Localization.lblakademisyenpanel;
            lblakademisyensil.Text = Localization.lblakademisyensil;
        }
    }
}
