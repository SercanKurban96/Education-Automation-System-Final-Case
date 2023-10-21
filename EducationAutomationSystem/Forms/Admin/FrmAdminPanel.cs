using EducationAutomationSystem.Admin;
using EducationAutomationSystem.Department;
using EducationAutomationSystem.Forms.Admin;
using EducationAutomationSystem.Lesson;
using EducationAutomationSystem.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationAutomationSystem
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void PctDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment fr = new FrmDepartment();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.yoneticicikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLanguage fr = new FrmLanguage();
                fr.Show();
                this.Hide();
                notifyIcon1.Visible = false;
            }
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
            toolTip13.SetToolTip(PctExit, Localization.toolTip13_SetToolTip);
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void PctStudent_Click(object sender, EventArgs e)
        {
            FrmStudent fr = new FrmStudent();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void PctNotification_Click(object sender, EventArgs e)
        {
            FrmNotification fr = new FrmNotification();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }
        public string username;
        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblyoneticipaneli.Text = Localization.lblyoneticipaneli;
            lblbolumler.Text = Localization.lblbolumler;
            lblogrenciler.Text = Localization.lblogrenciler;
            lblakademisyenler.Text = Localization.lblakademisyenler;
            lblraporlar.Text = Localization.lblraporlar;
            lblduyurular.Text = Localization.lblduyurular;
            lbluygulamalar.Text = Localization.lbluygulamalar;
            hideshowexit();
        }

        private void PctSettings_Click(object sender, EventArgs e)
        {
            FrmSettings fr = new FrmSettings();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        void NotifyIcon()
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = String.Format(Localization.notifyiconyoneticitext);
            notifyIcon1.BalloonTipTitle = String.Format(Localization.notifyiconballoontiptitle);
            notifyIcon1.BalloonTipText = String.Format(Localization.notifyiconballoontiptext);
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.Hide();
            NotifyIcon();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.yoneticicikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLanguage fr = new FrmLanguage();
                fr.Show();
                this.Hide();
                notifyIcon1.Visible = false;
            }
        }
        public void hideshowexit()
        {
            gösterToolStripMenuItem.Text = String.Format(Localization.gösterToolStripMenuItem);
            gizleToolStripMenuItem.Text = String.Format(Localization.gizleToolStripMenuItem);
            çıkışToolStripMenuItem.Text = String.Format(Localization.çıkışAdminToolStripMenuItem);
            notifyIcon1.Text = Localization.notifyIcon1;
        }
        private void PctMinimize_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

            NotifyIcon();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            hideshowexit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void PctMinimize_MouseHover(object sender, EventArgs e)
        {
            PctMinimize.BackColor = Color.Blue;
            toolTip12.SetToolTip(PctMinimize, Localization.toolTip12_SetToolTip);
        }

        private void PctMinimize_MouseLeave(object sender, EventArgs e)
        {
            PctMinimize.BackColor = Color.Transparent;
        }

        private void PctAcademician_Click(object sender, EventArgs e)
        {
            FrmAcademician fr = new FrmAcademician();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void PctLesson_Click(object sender, EventArgs e)
        {
            FrmLesson fr = new FrmLesson();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
                      
        }

        private void PctDepartment_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = Localization.toolTip1_ToolTipTitle;
            toolTip1.SetToolTip(PctDepartment, Localization.toolTip1_SetToolTip);
        }

        private void PctSettings_MouseHover(object sender, EventArgs e)
        {
            toolTip2.ToolTipTitle = Localization.toolTip2_ToolTipTitle;
            toolTip2.SetToolTip(PctSettings, Localization.toolTip2_SetToolTip);
        }

        private void PctNotification_MouseHover(object sender, EventArgs e)
        {
            toolTip3.ToolTipTitle = Localization.toolTip3_ToolTipTitle;
            toolTip3.SetToolTip(PctNotification, Localization.toolTip3_SetToolTip);
        }

        private void PctStudent_MouseHover(object sender, EventArgs e)
        {
            toolTip4.ToolTipTitle = Localization.toolTip4_ToolTipTitle;
            toolTip4.SetToolTip(PctStudent, Localization.toolTip4_SetToolTip);
        }

        private void PctAcademician_MouseHover(object sender, EventArgs e)
        {
            toolTip5.ToolTipTitle = Localization.toolTip5_ToolTipTitle;
            toolTip5.SetToolTip(PctAcademician, Localization.toolTip5_SetToolTip);
        }

        private void PctLesson_MouseHover(object sender, EventArgs e)
        {
            toolTip6.ToolTipTitle = Localization.toolTip6_ToolTipTitle;
            toolTip6.SetToolTip(PctReport, Localization.toolTip6_SetToolTip);
        }

        private void PctReport_Click(object sender, EventArgs e)
        {
            FrmReport fr = new FrmReport();
            fr.Show();
            this.Hide();
            notifyIcon1.Visible = false;
        }

        private void PctReport_MouseHover(object sender, EventArgs e)
        {
            toolTip11.ToolTipTitle = Localization.toolTip11_ToolTipTitle;
            toolTip11.SetToolTip(PctReport, Localization.toolTip11_SetToolTip);
        }
    }
}
