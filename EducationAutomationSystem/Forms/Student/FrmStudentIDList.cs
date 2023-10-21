using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.Academician
{
    public partial class FrmStudentIDList : Form
    {
        public FrmStudentIDList()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture, studentnumber;

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }

        private void PctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int academicianid, studentid, departmentid;
        private void FrmStudentIDList_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            int akademisyenID = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            var list = (from x in db.TBLSTUDENT
                        join y in db.TBLDEPARTMENT
                        on x.Department equals y.DepartmentID          
                        where x.Department == departmentid
                        select new
                        {
                            ÖğrenciID = x.StudentID,
                            Adı = x.StudentName,
                            Soyadı = x.StudentSurname,
                            Bölüm = y.DepartmentName
                        }).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
