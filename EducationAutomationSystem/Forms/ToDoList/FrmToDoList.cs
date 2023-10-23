using EducationAutomationSystem.Entity;
using EducationAutomationSystem.Forms.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.ToDoList
{
    public partial class FrmToDoList : Form
    {
        public FrmToDoList()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int studentid;

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

        private void PctEditToDoList_Click(object sender, EventArgs e)
        {
            FrmEditToDoList fr = new FrmEditToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctDeleteToDoList_Click(object sender, EventArgs e)
        {
            FrmDeleteToDoList fr = new FrmDeleteToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctToDoList_Click(object sender, EventArgs e)
        {
            FrmListToDoList fr = new FrmListToDoList();
            fr.number = number;
            fr.Show();
        }

        private void PctSearchToDoList_Click(object sender, EventArgs e)
        {
            FrmSearchToDoList fr = new FrmSearchToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctAddToDoList_Click(object sender, EventArgs e)
        {
            FrmAddToDoList fr = new FrmAddToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
  
        private void FrmToDoList_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            lblgorevara.Text = Localization.lblgorevara;
            lblgorevduzenle.Text = Localization.lblgorevduzenle;
            lblgorevolustur.Text = Localization.lblgorevolustur;
            lblgorevsil.Text = Localization.lblgorevsil;
            lbltodolist.Text = Localization.lbltodolist;
            lblyapilacaklarlistesi.Text = Localization.lblyapilacaklarlistesi;
        }
    }
}
