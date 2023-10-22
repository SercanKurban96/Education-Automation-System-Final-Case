using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        private void PctAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent fr = new FrmAddStudent();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctEditStudent_Click(object sender, EventArgs e)
        {
            FrmEditStudent fr = new FrmEditStudent();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
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

        private void PctDeleteStudent_Click(object sender, EventArgs e)
        {
            FrmDeleteStudent fr = new FrmDeleteStudent();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctListStudent_Click(object sender, EventArgs e)
        {
            FrmListStudent fr = new FrmListStudent();
            fr.number = number;
            fr.Show();
        }

        private void PctSearchStudent_Click(object sender, EventArgs e)
        {
            FrmSearchStudent fr = new FrmSearchStudent();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            lbladdstudent.Text = Localization.lbladdstudent;
            lbldeletestudent.Text = Localization.lbldeletestudent;
            lbleditstudent.Text = Localization.lbleditstudent;
            lblliststudent.Text = Localization.lblliststudent;
            lblsearchstudent.Text = Localization.lblsearchstudent;
            lblstudentpanel.Text = Localization.lblstudentpanel;
        }
    }
}
