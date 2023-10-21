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

namespace EducationAutomationSystem
{
    public partial class FrmLanguage : Form
    {
        public FrmLanguage()
        {
            InitializeComponent();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            if (rdbturkce.Checked)
            {
                Localization.Culture = new CultureInfo("");
            }
            else if (rdbenglish.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            FrmLoading fr = new FrmLoading();
            fr.Show();
            this.Hide();
        }

        private void FrmLanguage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            rdbturkce.Checked = true;
        }

        private void pctturkce_Click(object sender, EventArgs e)
        {
            rdbturkce.Checked = true;
        }

        private void pctenglish_Click(object sender, EventArgs e)
        {
            rdbenglish.Checked = true;
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label1.Text);
            num++;
            label1.Text = num.ToString();

            if (num == 20)
            {
                lblegitimotomasyonsistemi.ForeColor = Color.Red;
            }
            if (num == 40)
            {
                lblegitimotomasyonsistemi.ForeColor = Color.Black;
            }
            if (num == 60)
            {
                lblegitimotomasyonsistemi.ForeColor = Color.Yellow;
            }
            if (num == 80)
            {
                lblegitimotomasyonsistemi.ForeColor = Color.Cyan;
            }
            if (num == 100)
            {
                lblegitimotomasyonsistemi.ForeColor = Color.LightGreen;
            }
            if (num == 120)
            {
                num = 0;
                label1.Text = num.ToString();
                lblegitimotomasyonsistemi.ForeColor = Color.White;
            }

            lblegitimotomasyonsistemi.Text = lblegitimotomasyonsistemi.Text.Substring(1) + lblegitimotomasyonsistemi.Text.Substring(0, 1);
        }
    }
}
