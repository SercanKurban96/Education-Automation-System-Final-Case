using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationAutomationSystem.Lesson
{
    public partial class FrmAddLesson : Form
    {
        public FrmAddLesson()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();

        public string number, namesurname, picture;
        public int academicianid, departmentid;
        void kayitsayisi()
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            SqlCommand cmd = new SqlCommand("select count(*) from TBLLESSON where Academician=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", academicianid);
            int lessonCount = (int)cmd.ExecuteScalar();
            LblLessonCount.Text = lessonCount.ToString();
            conn.connection().Close();
        }
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(LessonName) from TBLLESSON where LessonName= '" + TxtLessonName.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
        }
        private void Temizle()
        {
            TxtID.Clear();
            TxtLessonName.Clear();
        }
        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddLesson_Load(object sender, EventArgs e)
        {
            kayitsayisi();
            TxtLessonName.Focus();

            lblders.Text = Localization.lblders;
            lbldersekleformu.Text = Localization.lbldersekleformu;
            lblderssayisi.Text = Localization.lblderssayisi;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtLessonName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.dersadibos, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtLessonName.Text.Length < 5)
            {
                MessageBox.Show(String.Format(Localization.dersadi5karakterdenaz, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (varMi(TxtLessonName.Text) != 0)
                {
                    MessageBox.Show(String.Format(Localization.aynidersadi, TxtLessonName.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtLessonName.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into TBLLESSON (LessonName,Department,Academician) values (@p1,@p2,@p3)", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtLessonName.Text);
                    cmd.Parameters.AddWithValue("@p2", label2.Text);
                    cmd.Parameters.AddWithValue("@p3", label1.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.derskaydedildi, TxtLessonName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayitsayisi();
                    Temizle();
                    TxtLessonName.Focus();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            TxtLessonName.Focus();
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

        private void CmbAcademician_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
