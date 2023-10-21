using EducationAutomationSystem.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EducationAutomationSystem.Lesson
{
    public partial class FrmEditLesson : Form
    {
        public FrmEditLesson()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        private void LoadData()
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            string query = "select LessonID as 'Ders ID',LessonName as 'Ders Adı', DepartmentName as 'Bölüm', AcademicianName + ' ' + AcademicianSurname as 'Akademisyen' from TBLDEPARTMENT inner join TBLLESSON on TBLDEPARTMENT.DepartmentID = TBLLESSON.Department inner join TBLACADEMICIAN on TBLLESSON.Academician = TBLACADEMICIAN.AcademicianID WHERE Academician = @AkademisyenID";
            using (SqlCommand command = new SqlCommand(query, conn.connection()))
            {
                command.Parameters.AddWithValue("@AkademisyenID", academicianid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DtgLesson.DataSource = dt;
            }
        }
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
            TxtLessonName.Enabled = false;
        }
        private void PctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditLesson_Load(object sender, EventArgs e)
        {
            LoadData();
            kayitsayisi();
            Temizle();

            lblders.Text = Localization.lblders;
            lbldersduzenleformu.Text = Localization.lbldersduzenleformu;
            lblderssayisi.Text = Localization.lblderssayisi;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void DtgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgLesson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                TxtLessonName.Enabled = true;
            }
            try
            {
                TxtID.Text = DtgLesson.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtLessonName.Text = DtgLesson.Rows[e.RowIndex].Cells[1].Value.ToString();
                label2.Text = DtgLesson.Rows[e.RowIndex].Cells[2].Value.ToString();
                label1.Text = DtgLesson.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtLessonName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.dersadibos, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }
            else if (TxtLessonName.Text.Length < 5)
            {
                MessageBox.Show(String.Format(Localization.dersadi5karakterdenaz, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }  
            else
            {
                SqlCommand cmd = new SqlCommand("update TBLLESSON set LessonName=@p1,Department=@p2, Academician=@p3 where LessonID=@p4", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtLessonName.Text);
                cmd.Parameters.AddWithValue("@p2", departmentid);
                cmd.Parameters.AddWithValue("@p3", academicianid);
                cmd.Parameters.AddWithValue("@p4", TxtID.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.dersguncellendi, TxtLessonName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                kayitsayisi();
                Temizle();
            }
        }
    }
}
