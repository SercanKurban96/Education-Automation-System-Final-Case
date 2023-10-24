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
    public partial class FrmListLesson : Form
    {
        public FrmListLesson()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgLesson.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLLESSON", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblLessonCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void FrmListLesson_Load(object sender, EventArgs e)
        {
            verilerigoster("select LessonID as 'Ders ID',LessonName as 'Ders Adı', DepartmentName as 'Bölüm', AcademicianName + ' ' + AcademicianSurname as 'Akademisyen' from TBLDEPARTMENT inner join TBLLESSON on TBLDEPARTMENT.DepartmentID = TBLLESSON.Department inner join TBLACADEMICIAN on TBLLESSON.Academician = TBLACADEMICIAN.AcademicianID");
            kayitsayisi();

            lblderssayisi.Text = Localization.lblderssayisi;
            lblderslistesiformu.Text = Localization.lblderslistesiformu;

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();
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
    }
}
