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

namespace EducationAutomationSystem.Lesson
{
    public partial class FrmLesson : Form
    {
        public FrmLesson()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        private void FrmLesson_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();


            lbldersara.Text = Localization.lbldersara;
            lbldersduzenle.Text = Localization.lbldersduzenle;
            lbldersekle.Text = Localization.lbldersekle;
            lblderslerpanel.Text = Localization.lblderslerpanel;
            lblderslistesi.Text = Localization.lblderslistesi;
            lblderssil.Text = Localization.lblderssil;
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

        private void PctAddLesson_Click(object sender, EventArgs e)
        {
            FrmAddLesson fr = new FrmAddLesson();
            fr.number = number;
            fr.Show();
        }

        private void PctEditLesson_Click(object sender, EventArgs e)
        {
            FrmEditLesson fr = new FrmEditLesson();
            fr.number = number;
            fr.Show();
        }

        private void PctSearchLesson_Click(object sender, EventArgs e)
        {
            FrmSearchLesson fr = new FrmSearchLesson();
            fr.number = number;
            fr.Show();
        }

        private void PctDeleteLesson_Click(object sender, EventArgs e)
        {
            FrmDeleteLesson fr = new FrmDeleteLesson();
            fr.number = number;
            fr.Show();
        }

        private void PctListLesson_Click(object sender, EventArgs e)
        {
            FrmListLesson fr = new FrmListLesson();
            fr.number = number;
            fr.Show();
        }
    }
}
