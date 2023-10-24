using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EducationAutomationSystem.Academician;
using EducationAutomationSystem.Entity;

namespace EducationAutomationSystem.Forms.Academician
{
    public partial class FrmAcademicianNotes : Form
    {
        public FrmAcademicianNotes()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        sqlconnection conn = new sqlconnection();
        public string number, namesurname, picture, studentnumber;
        public int academicianid, studentid, departmentid;

        private int GetAkademisyenBolum(int akademisyenID)
        {
            string query = "SELECT Department FROM TBLACADEMICIAN WHERE AcademicianID = @p1";
            SqlCommand cmd = new SqlCommand(query, conn.connection());
            cmd.Parameters.AddWithValue("@p1", akademisyenID);
            return (int)cmd.ExecuteScalar();
        }

        private void FrmAcademicianNotes_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            TxtAverage.Text = "0";
            TxtMidtermExam.Text = "0";
            TxtFinalExam.Text = "0";

            int akademisyenID = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            string query = "SELECT LessonID, LessonName FROM TBLLESSON WHERE Department = @p1 AND Academician = @p2";
            SqlCommand cmd = new SqlCommand(query, conn.connection());
            cmd.Parameters.AddWithValue("@p1", GetAkademisyenBolum(akademisyenID));
            cmd.Parameters.AddWithValue("@p2", akademisyenID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CmbLesson.DataSource = dt;
            CmbLesson.DisplayMember = "LessonName";
            CmbLesson.ValueMember = "LessonID";

            lblderssec.Text = Localization.lblderssec;
            lblfinalsinavi.Text = Localization.lblfinalsinavi;
            lblnotislemleri.Text = Localization.lblnotislemleri;
            lblogrenciid.Text = Localization.lblogrenciid;
            lblortalama.Text = Localization.lblortalama;
            lblvizesinavi.Text = Localization.lblvizesinavi;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCalculate.Text = Localization.BtnCalculate;
            BtnCancel.Text = Localization.BtnCancel;
            BtnEdit.Text = Localization.BtnEdit;
            lblharfnotu.Text = Localization.lblharfnotu;

            var examnotes = (from x in db.TBLNOTE
                             select new
                             {
                                 ID = x.NoteID,
                                 Ders = x.TBLLESSON.LessonName,
                                 Vize = x.MidtermExam,
                                 Final = x.FinalExam,
                                 Ortalama = x.Average,
                                 HarfNotu = x.LetterGrade,
                                 AdSoyad = x.TBLSTUDENT.StudentName + " " + x.TBLSTUDENT.StudentSurname,
                                 Öğrenci = x.Student,
                                 Akademisyen = x.Academician
                             }).Where(y => y.Akademisyen == academicianid).ToList();
            DtgStudentNotes.DataSource = examnotes;
            DtgStudentNotes.Columns["ID"].Visible = false;
            DtgStudentNotes.Columns["Öğrenci"].Visible = false;
            DtgStudentNotes.Columns["Akademisyen"].Visible = false;
        }

        public void Temizle()
        {
            TxtAverage.Text = "0";
            TxtFinalExam.Text = "0";
            TxtStudentID.Clear();
            TxtMidtermExam.Text = "0";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            byte vizeNotu, finalNotu;
            double ortalama;
            string harfNotu = "";
            vizeNotu = Convert.ToByte(TxtMidtermExam.Text);
            finalNotu = Convert.ToByte(TxtFinalExam.Text);
            ortalama = (vizeNotu * 0.40) + (finalNotu * 0.60);
            TxtAverage.Text = ortalama.ToString();
            if (ortalama < 50)
            {
                harfNotu = "FF";
            }
            else if (ortalama >= 50 && ortalama < 55)
            {
                harfNotu = "DD";
            }
            else if (ortalama >= 55 && ortalama < 60)
            {
                harfNotu = "DC";
            }
            else if (ortalama >= 60 && ortalama < 65)
            {
                harfNotu = "CC";
            }
            else if (ortalama >= 65 && ortalama < 70)
            {
                harfNotu = "CB";
            }
            else if (ortalama >= 70 && ortalama < 80)
            {
                harfNotu = "BB";
            }
            else if (ortalama >= 80 && ortalama < 90)
            {
                harfNotu = "BA";
            }
            else
            {
                harfNotu = "AA";
            }
            TxtLetterGrade.Text = harfNotu;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            TBLNOTE t = new TBLNOTE();
            t.MidtermExam = byte.Parse(TxtMidtermExam.Text);
            t.FinalExam = byte.Parse(TxtFinalExam.Text);
            t.Average = decimal.Parse(TxtAverage.Text);
            t.Lesson = int.Parse(CmbLesson.SelectedValue.ToString());
            t.Student = int.Parse(TxtStudentID.Text.ToString());
            t.Academician = int.Parse(label1.Text);
            t.LetterGrade = TxtLetterGrade.Text;
            db.TBLNOTE.Add(t);
            db.SaveChanges();
            MessageBox.Show(String.Format(Localization.ogrencinotukaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();

            var examnotes = (from x in db.TBLNOTE
                             select new
                             {
                                 ID = x.NoteID,
                                 Ders = x.TBLLESSON.LessonName,
                                 Vize = x.MidtermExam,
                                 Final = x.FinalExam,
                                 Ortalama = x.Average,
                                 HarfNotu = x.LetterGrade,
                                 AdSoyad = x.TBLSTUDENT.StudentName + " " + x.TBLSTUDENT.StudentSurname,
                                 Öğrenci = x.Student,
                                 Akademisyen = x.Academician
                             }).Where(y => y.Akademisyen == academicianid).ToList();
            DtgStudentNotes.DataSource = examnotes;
            DtgStudentNotes.Columns["ID"].Visible = false;
            DtgStudentNotes.Columns["Öğrenci"].Visible = false;
            DtgStudentNotes.Columns["Akademisyen"].Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtMidtermExam.Text = "0";
            TxtFinalExam.Text = "0";
            TxtAverage.Text = "0";
            TxtStudentID.Text = "";
        }

        private void DtgStudentNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[0].Value.ToString();
                CmbLesson.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtMidtermExam.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtFinalExam.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtAverage.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtLetterGrade.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtStudentID.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[7].Value.ToString();
                label1.Text = DtgStudentNotes.Rows[e.RowIndex].Cells[7].Value.ToString();


            }
            catch (Exception)
            {

            }
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            FrmStudentIDList fr = new FrmStudentIDList();
            fr.number = number;
            fr.Show();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademicianPanel fr = new FrmAcademicianPanel();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void TxtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            int id = int.Parse(TxtID.Text);
            var t = db.TBLNOTE.Find(id);
            t.MidtermExam = byte.Parse(TxtMidtermExam.Text);
            t.FinalExam = byte.Parse(TxtFinalExam.Text);
            t.Average = decimal.Parse(TxtAverage.Text);
            t.Lesson = int.Parse(CmbLesson.SelectedValue.ToString());
            t.Academician = int.Parse(label1.Text);
            t.LetterGrade = TxtLetterGrade.Text;
            db.SaveChanges();
            MessageBox.Show(String.Format(Localization.ogrencinotuguncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            var examnotes = (from x in db.TBLNOTE
                             select new
                             {
                                 ID = x.NoteID,
                                 Ders = x.TBLLESSON.LessonName,
                                 Vize = x.MidtermExam,
                                 Final = x.FinalExam,
                                 Ortalama = x.Average,
                                 HarfNotu = x.LetterGrade,
                                 AdSoyad = x.TBLSTUDENT.StudentName + " " + x.TBLSTUDENT.StudentSurname,
                                 Öğrenci = x.Student,
                                 Akademisyen = x.Academician
                             }).Where(y => y.Akademisyen == academicianid).ToList();
            DtgStudentNotes.DataSource = examnotes;
            DtgStudentNotes.Columns["ID"].Visible = false;
            DtgStudentNotes.Columns["Öğrenci"].Visible = false;
            DtgStudentNotes.Columns["Akademisyen"].Visible = false;
        }
    }
}
