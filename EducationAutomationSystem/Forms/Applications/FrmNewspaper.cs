using EducationAutomationSystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Applications
{
    public partial class FrmNewspaper : Form
    {
        public FrmNewspaper()
        {
            InitializeComponent();
        }

        private void BtnCumhuriyetGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cumhuriyet.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnHurriyetGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnMilliyetGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnSabahGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnFotomacGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fotomac.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnFanatikGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void BtnHaberturkGazetesi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com");
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
