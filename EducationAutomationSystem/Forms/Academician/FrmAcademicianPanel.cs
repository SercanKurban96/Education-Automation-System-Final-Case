using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.Academician;
using EducationAutomationSystem.Forms.Applications;
using EducationAutomationSystem.Forms.Notification;
using EducationAutomationSystem.Lesson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Academician
{
    public partial class FrmAcademicianPanel : Form
    {
        public FrmAcademicianPanel()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        void NotifyIcon()
        {
            this.Hide();
            notifyIcon2.Visible = true;
            notifyIcon2.Text = String.Format(Localization.notifyiconakademisyentext);
            notifyIcon2.BalloonTipTitle = String.Format(Localization.notifyiconballoontiptitle);
            notifyIcon2.BalloonTipText = String.Format(Localization.notifyiconballoontiptext);
            notifyIcon2.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon2.ShowBalloonTip(2000);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }
        public void hideshowexit()
        {
            gösterToolStripMenuItem.Text = String.Format(Localization.gösterToolStripMenuItem);
            gizleToolStripMenuItem.Text = String.Format(Localization.gizleToolStripMenuItem);
            çıkışToolStripMenuItem.Text = String.Format(Localization.çıkışAkademisyenToolStripMenuItem);
            notifyIcon2.Text = Localization.notifyIcon2;
        }
        private void FrmAcademicianPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();

            LblNameSurname.Text = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianName + " " + y.AcademicianSurname).FirstOrDefault();

            LblDepartment.Text = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentName).FirstOrDefault();

            PctAcademicianImage.ImageLocation = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianImage).FirstOrDefault();

            lblakademisyenpaneli.Text = Localization.lblakademisyenpaneli;
            lblbolum.Text = Localization.lblbolum;
            lbladsoyad.Text = Localization.lbladsoyad;
            lblnotlar.Text = Localization.lblnotlar;
            lbluygulamalar.Text = Localization.lbluygulamalar;
            lbldersler.Text = Localization.lbldersler;
            lblduyurular.Text = Localization.lblduyurular;

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            hideshowexit();
        }

        private void PctMinimize_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

            NotifyIcon();
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            hideshowexit();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.akademisyencikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLanguage fr = new FrmLanguage();
                fr.Show();
                this.Hide();
                notifyIcon2.Visible = false;
            }
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

        private void notifyIcon2_DoubleClick(object sender, EventArgs e)
        {
            hideshowexit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.Hide();
            NotifyIcon();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void PctNotes_Click(object sender, EventArgs e)
        {
            FrmAcademicianNotes fr = new FrmAcademicianNotes();
            fr.number = number;
            fr.Show();
        }

        private void PctSettings_Click(object sender, EventArgs e)
        {
            FrmAcademicianApplication fr = new FrmAcademicianApplication();
            fr.number = number;
            fr.Show();
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

        private void PctNotes_MouseHover(object sender, EventArgs e)
        {
            toolTip7.ToolTipTitle = Localization.toolTip7_ToolTipTitle;
            toolTip7.SetToolTip(PctNotes, Localization.toolTip7_SetToolTip);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PctLesson_Click(object sender, EventArgs e)
        {
            FrmLesson fr = new FrmLesson();
            fr.number = number;
            fr.Show();
        }

        private void PctLesson_MouseHover(object sender, EventArgs e)
        {
            toolTip6.ToolTipTitle = Localization.toolTip6_ToolTipTitle;
            toolTip6.SetToolTip(PctLesson, Localization.toolTip6_SetToolTip);
        }

        private void PctNotification_Click(object sender, EventArgs e)
        {
            FrmAcademicianNotification fr = new FrmAcademicianNotification();
            fr.Show();
        }

        private void PctNotification_MouseHover(object sender, EventArgs e)
        {
            toolTip14.ToolTipTitle = Localization.toolTip14_ToolTipTitle;
            toolTip14.SetToolTip(PctNotification, Localization.toolTip14_SetToolTip);
        }

        private void PctSettings_MouseHover(object sender, EventArgs e)
        {
            toolTip2.ToolTipTitle = Localization.toolTip2_ToolTipTitle;
            toolTip2.SetToolTip(PctSettings, Localization.toolTip2_SetToolTip);
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.akademisyencikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLanguage fr = new FrmLanguage();
                fr.Show();
                this.Hide();
                notifyIcon2.Visible = false;
            }
        }
    }
}
