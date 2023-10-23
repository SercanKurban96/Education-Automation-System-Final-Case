using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.ToDoList;
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
    public partial class FrmStudentPanel : Form
    {
        public FrmStudentPanel()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int studentid;

        void NotifyIcon()
        {
            this.Hide();
            notifyIcon3.Visible = true;
            notifyIcon3.Text = String.Format(Localization.notifyiconogrencitext);
            notifyIcon3.BalloonTipTitle = String.Format(Localization.notifyiconballoontiptitle);
            notifyIcon3.BalloonTipText = String.Format(Localization.notifyiconballoontiptext);
            notifyIcon3.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon3.ShowBalloonTip(2000);
        }
        private void PctNotes_Click(object sender, EventArgs e)
        {
            FrmStudentNotes fr = new FrmStudentNotes();
            fr.number = number;
            fr.Show();
            this.Hide();
            notifyIcon3.Visible = false;
        }

        private void FrmStudentPanel_Load(object sender, EventArgs e)
        {
            hideshowexit();
            timer1.Start();

            LblNameSurname.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentName + " " + y.StudentSurname).FirstOrDefault();

            LblNumber.Text = number;

            PctStudentImage.ImageLocation = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentPicture).FirstOrDefault();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            lblogrencipaneli.Text = Localization.lblogrencipaneli;
            lbladsoyad.Text = Localization.lbladsoyad;
            lblnotbilgileri.Text = Localization.lblnotbilgileri;
            lblduyurularogrenci.Text = Localization.lblduyurularogrenci;
            lbluygulamalar.Text = Localization.lbluygulamalar;
            lblogrencino.Text = Localization.lblogrencino;
            lblyapilacaklar.Text = Localization.lblyapilacaklar;
        }
        public void hideshowexit()
        {
            gösterToolStripMenuItem.Text = String.Format(Localization.gösterToolStripMenuItem);
            gizleToolStripMenuItem.Text = String.Format(Localization.gizleToolStripMenuItem);
            çıkışToolStripMenuItem.Text = String.Format(Localization.çıkışOgrenciToolStripMenuItem);
            notifyIcon3.Text = Localization.notifyIcon3;
        }

        private void PctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

            NotifyIcon();
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

        private void PctExit_Click(object sender, EventArgs e)
        {
            hideshowexit();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.ogrencicikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLoading fr = new FrmLoading();
                fr.Show();
                this.Hide();
                notifyIcon3.Visible = false;
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

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            hideshowexit();
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideshowexit();
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.ogrencicikis), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLoading fr = new FrmLoading();
                fr.Show();
                this.Hide();
                notifyIcon3.Visible = false;
            }
        }

        private void PctNotification_Click(object sender, EventArgs e)
        {
            FrmStudentNotification fr = new FrmStudentNotification();
            fr.number = number;
            fr.Show();
            this.Hide();
            notifyIcon3.Visible = false;
        }

        private void PctSettings_Click(object sender, EventArgs e)
        {
            FrmStudentApplication fr = new FrmStudentApplication();
            fr.number = number;
            fr.Show();
            this.Hide();
            notifyIcon3.Visible = false;
        }

        private void PctSettings_MouseHover(object sender, EventArgs e)
        {
            toolTip10.ToolTipTitle = Localization.toolTip10_ToolTipTitle;
            toolTip10.SetToolTip(PctSettings, Localization.toolTip10_SetToolTip);
        }

        private void PctNotes_MouseHover(object sender, EventArgs e)
        {
            toolTip8.ToolTipTitle = Localization.toolTip8_ToolTipTitle;
            toolTip8.SetToolTip(PctNotes, Localization.toolTip8_SetToolTip);
        }

        private void PctNotification_MouseHover(object sender, EventArgs e)
        {
            toolTip9.ToolTipTitle = Localization.toolTip9_ToolTipTitle;
            toolTip9.SetToolTip(PctNotification, Localization.toolTip9_SetToolTip);
        }

        private void PctToDoList_Click(object sender, EventArgs e)
        {
            FrmToDoList fr = new FrmToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
            notifyIcon3.Visible = false;
        }
        private void PctToDoList_MouseHover(object sender, EventArgs e)
        {
            toolTip15.ToolTipTitle = Localization.toolTip15_ToolTipTitle;
            toolTip15.SetToolTip(PctToDoList, Localization.toolTip15_SetToolTip);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
