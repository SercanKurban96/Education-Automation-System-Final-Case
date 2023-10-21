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

namespace EducationAutomationSystem.Forms.Admin
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();

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

        private void PctOgrenciSirala_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                              select new
                              {
                                  ID = x.StudentID,
                                  TC = x.StudentTRNumber,
                                  Numara = x.StudentNumber,
                                  Adı = x.StudentName,
                                  Soyadı = x.StudentSurname
                              }).OrderBy(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctOgrenciSiralaTers_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                               select new
                               {
                                   ID = x.StudentID,
                                   TC = x.StudentTRNumber,
                                   Numara = x.StudentNumber,
                                   Adı = x.StudentName,
                                   Soyadı = x.StudentSurname
                               }).OrderByDescending(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctAkademisyenSirala_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                               select new
                               {
                                   ID = x.AcademicianID,
                                   TC = x.AcademicianTRNumber,                       
                                   Adı = x.AcademicianName,
                                   Soyadı = x.AcademicianSurname
                               }).OrderBy(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctAkademisyenSiralaTers_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                                   select new
                                   {
                                       ID = x.AcademicianID,
                                       TC = x.AcademicianTRNumber,
                                       Adı = x.AcademicianName,
                                       Soyadı = x.AcademicianSurname
                                   }).OrderByDescending(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctDersSirala_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                                   select new
                                   {
                                       ID = x.LessonID,
                                       Ders = x.LessonName
                                   }).OrderBy(x => x.Ders).ToList();
            DtgReport.DataSource = lessonList;
        }

        private void PctDersSiralaTers_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                              select new
                              {
                                  ID = x.LessonID,
                                  Ders = x.LessonName
                              }).OrderByDescending(x => x.Ders).ToList();
            DtgReport.DataSource = lessonList;
        }

        private void PctBolumSirala_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                              select new
                              {
                                  ID = x.DepartmentID,
                                  Bölüm = x.DepartmentName
                              }).OrderBy(x => x.Bölüm).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctBolumSiralaTers_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                                  select new
                                  {
                                      ID = x.DepartmentID,
                                      Bölüm = x.DepartmentName
                                  }).OrderByDescending(x => x.Bölüm).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctToplamOgrenciSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamogrencisayisi) + " " + db.TBLSTUDENT.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamAkademisyenSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamakademisyensayisi) + " " + db.TBLACADEMICIAN.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamDersSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamderssayisi) + " " + db.TBLLESSON.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamBolumSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplambolumsayisi) + " " + db.TBLDEPARTMENT.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctSon3OgrenciKayit_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                               select new
                               {
                                   ID = x.StudentID,
                                   TC = x.StudentTRNumber,
                                   Numara = x.StudentNumber,
                                   Adı = x.StudentName,
                                   Soyadı = x.StudentSurname
                               }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctSon3AkademisyenKayit_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                               select new
                               {
                                   ID = x.AcademicianID,
                                   TC = x.AcademicianTRNumber,
                                   Adı = x.AcademicianName,
                                   Soyadı = x.AcademicianSurname
                               }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctSon3BolumKayit_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                                  select new
                                  {
                                      ID = x.DepartmentID,
                                      Bölüm = x.DepartmentName
                                  }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctSon3DersKayit_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                              select new
                              {
                                  ID = x.LessonID,
                                  Ders = x.LessonName
                              }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = lessonList;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lblakademisyensirala.Text = Localization.lblakademisyensirala;
            lblakademisyensiralaters.Text = Localization.lblakademisyensiralaters;
            lblbolumsirala.Text = Localization.lblbolumsirala;
            lblbolumsiralaters.Text = Localization.lblbolumsiralaters;
            lblderssirala.Text = Localization.lblderssirala;
            lblderssiralaters.Text = Localization.lblderssiralaters;
            lblogrencisirala.Text = Localization.lblogrencisirala;
            lblogrencisiralaters.Text = Localization.lblogrencisiralaters;
            lblraporlarpaneli.Text = Localization.lblraporlarpaneli;
            lbltoplamakademisyensayisi.Text = Localization.lbltoplamakademisyensayisi;
            lbltoplambolumsayisi.Text = Localization.lbltoplambolumsayisi;
            lbltoplamderssayisi.Text = Localization.lbltoplamderssayisi;
            lbltoplamogrencisayisi.Text = Localization.lbltoplamogrencisayisi;
            lblson3akademisyenkayit.Text = Localization.lblson3akademisyenkayit;
            lblson3bolumkayit.Text = Localization.lblson3bolumkayit;
            lblson3derskayit.Text = Localization.lblson3derskayit;
            lblson3ogrencikayit.Text = Localization.lblson3ogrencikayit;
        }
    }
}
