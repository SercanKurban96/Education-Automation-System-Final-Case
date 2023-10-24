using DocumentFormat.OpenXml.Spreadsheet;
using EducationAutomationSystem.Entity;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
        public string number, picture;
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

            TxtPicture.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentPicture).FirstOrDefault();

            PctStudentImage.ImageLocation = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentPicture).FirstOrDefault();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            var examnotes = (from x in db.TBLNOTE
                             select new
                             {
                                 Ders = x.TBLLESSON.LessonName,
                                 Vize = x.MidtermExam,
                                 Final = x.FinalExam,
                                 Ortalama = x.Average,
                                 HarfNotu = x.LetterGrade,
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
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
            BtnEdit.Text = Localization.BtnEdit;
            lblphoto.Text = Localization.lblphoto;

            BtnEdit.Enabled = true;
            StudentDisabled();
        }

        public void StudentEnabled()
        {
            TxtMail.Enabled = true;
            MskPhoneNumber.Enabled = true;
            BtnEdit.Enabled = false;
            BtnAdd.Enabled = true;
            BtnCancel.Enabled = true;
            BtnPicture.Enabled = true;
        }
        public void StudentDisabled()
        {
            MskTRNumber.Enabled = false;
            TxtMail.Enabled = false;
            MskPhoneNumber.Enabled = false;
            BtnAdd.Enabled = false;
            BtnCancel.Enabled = false;
            TxtStudentName.Enabled = false;
            TxtStudentSurname.Enabled = false;
            DtpBirthDate.Enabled = false;
            TxtBirthPlace.Enabled = false;
            TxtDepartment.Enabled = false;
            BtnEdit.Enabled = true;
            BtnPicture.Enabled = false;
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
            PctBack.BackColor = System.Drawing.Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StudentDisabled();

            MskPhoneNumber.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.PhoneNumber).FirstOrDefault();

            TxtMail.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentMail).FirstOrDefault();

            TxtPicture.Text = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentPicture).FirstOrDefault();

            PctStudentImage.ImageLocation = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentPicture).FirstOrDefault();
        }
        private bool IsEmailValid(string input)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(input, emailPattern);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblNumber.Text = number;
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            string mail = TxtMail.Text;

            if (MskPhoneNumber.Text == "(   )    -" || MskPhoneNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.telefonnobos, MskPhoneNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtMail.Text == "")
            {
                MessageBox.Show(String.Format(Localization.mailbos, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsEmailValid(mail))
            {
                MessageBox.Show(String.Format(Localization.gecersizmailadresi, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtPicture.Text == "" || PctStudentImage.Image == null)
            {
                MessageBox.Show(String.Format(Localization.resimbos, TxtPicture.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(studentid.ToString());
                var t = db.TBLSTUDENT.Find(id);
                t.StudentMail = TxtMail.Text;
                t.PhoneNumber = MskPhoneNumber.Text;
                t.StudentPicture = TxtPicture.Text;
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.ogrencibilgileriguncellendi, TxtMail.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentDisabled();
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctStudentImage.ImageLocation = openFileDialog1.FileName;
            TxtPicture.Text = openFileDialog1.FileName;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            StudentEnabled();
        }
    }
}
