using EducationAutomationSystem.Entity;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.Student
{
    public partial class FrmStudentNotes : Form
    {
        public FrmStudentNotes()
        {
            InitializeComponent();
        }

        DbEducationEntities4 db = new DbEducationEntities4();
        int studentid;
        public string number;
        private void FrmStudentNotes_Load(object sender, EventArgs e)
        {
            LblNumber.Text = number;

            MskTRNumber.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentTRNumber.ToString()).FirstOrDefault();

            TxtStudentName.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentName).FirstOrDefault();

            TxtStudentSurname.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentSurname).FirstOrDefault();

            DtpBirthDate.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentBirthDate.ToString()).FirstOrDefault();

            TxtBirthPlace.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentBirthPlace).FirstOrDefault();

            lblcinsiyet.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentGender).FirstOrDefault();

            TxtDepartment.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentName).FirstOrDefault();

            MskPhoneNumber.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.PhoneNumber).FirstOrDefault();

            TxtMail.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentMail).FirstOrDefault();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            var examnotes = (from x in db.TBLNOTE
                             select new
                             {
                                 Ders = x.TBLLESSON.LessonName,
                                 Vize = x.MidtermExam,
                                 Final = x.FinalExam,
                                 Ortalama = x.Average,
                                 Öğrenci = x.Student
                             }).Where(y => y.Öğrenci == studentid).ToList();
            DtgStudentNotes.DataSource = examnotes;
            DtgStudentNotes.Columns["Öğrenci"].Visible = false;

            lblnotlarim.Text = Localization.lblnotlarim;
            lblogrencino.Text = Localization.lblogrencino;
            lblstudenttrno.Text = Localization.lblstudenttrno;
            lblstudentname.Text = Localization.lblstudentname;
            lblstudentsurname.Text = Localization.lblstudentsurname;
            lblbirthdate.Text = Localization.lblbirthdate;
            lblbirthplace.Text = Localization.lblbirthplace;
            lblgender.Text = Localization.lblgender;
            lbldepartment.Text = Localization.lbldepartment;
            groupBox1.Text = Localization.groupBox1;
            groupBox5.Text = Localization.groupBox5;
            lblmail.Text = Localization.lblmail;
            lblphonenumber.Text = Localization.lblphonenumber;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmStudentPanel fr = new FrmStudentPanel();
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
    }
}
