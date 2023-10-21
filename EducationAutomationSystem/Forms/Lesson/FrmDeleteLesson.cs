using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Lesson
{
    public partial class FrmDeleteLesson : Form
    {
        public FrmDeleteLesson()
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
        private void Temizle()
        {
            TxtID.Clear();
            TxtLessonName.Clear();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBLLESSON where LessonID=@p1", conn.connection());
            if (TxtLessonName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.dersbos, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.derssil, TxtLessonName.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.derssilindi, TxtLessonName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    kayitsayisi();
                    Temizle();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmDeleteLesson_Load(object sender, EventArgs e)
        {
            LoadData();
            kayitsayisi();

            lblders.Text = Localization.lblders;
            lblderssilformu.Text = Localization.lblderssilformu;
            lblderssayisi.Text = Localization.lblderssayisi;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();
        }

        private void DtgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbAcademician_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
