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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.metin), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void PctAdministrator_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.Show();
            this.Hide();
        }

        private void PctTeacher_Click(object sender, EventArgs e)
        {
            FrmAcademicianLogin fr = new FrmAcademicianLogin();
            fr.Show();
            this.Hide();
        }

        private void PctStudent_Click(object sender, EventArgs e)
        {
            FrmStudentLogin fr = new FrmStudentLogin();
            fr.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblyonetici.Text = Localization.lblyonetici;
            lblakademisyen.Text = Localization.lblakademisyen;
            lblogrenci.Text = Localization.lblogrenci;
            lblegitimotomasyonugirispanelleri.Text = Localization.lblegitimotomasyonugirispanelleri;
            lbllogineos.Text = Localization.lbllogineos;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbllogineos.Text = Localization.lbllogineos + " ~ " + DateTime.Now.Year.ToString();
        }
    }
}
