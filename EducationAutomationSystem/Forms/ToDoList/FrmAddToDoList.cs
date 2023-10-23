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

namespace EducationAutomationSystem.Forms.ToDoList
{
    public partial class FrmAddToDoList : Form
    {
        public FrmAddToDoList()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int studentid;

        public void Temizle()
        {
            TxtToDoListTitle.Clear();
            RchToDoListContent.Clear();
            TxtToDoListTitle.Focus();
        }

        void kayitsayisi()
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            SqlCommand cmd = new SqlCommand("select count(*) from TBLTODOLIST where Student=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", studentid);
            int toDoList = (int)cmd.ExecuteScalar();
            LblToDoListCount.Text = toDoList.ToString();
            conn.connection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtToDoListTitle.Text == "")
            {
                MessageBox.Show(String.Format(Localization.gorevbasligibos, TxtToDoListTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RchToDoListContent.Text == "")
            {
                MessageBox.Show(String.Format(Localization.gorevicerigibos, RchToDoListContent.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBLTODOLIST t = new TBLTODOLIST();
                t.ToDoListDate = DateTime.Now;
                t.ToDoListTitle = TxtToDoListTitle.Text;
                t.ToDoListContent = RchToDoListContent.Text;
                t.Student = int.Parse(label1.Text.ToString());
                db.TBLTODOLIST.Add(t);
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.gorevkaydedildi, RchToDoListContent.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information); 
                kayitsayisi();
                Temizle();
                TxtToDoListTitle.Focus();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmAddToDoList_Load(object sender, EventArgs e)
        {
            kayitsayisi();
            TxtToDoListTitle.Focus();

            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            lbladdtodolist.Text = Localization.lbladdtodolist;
            lblgorevbasligi.Text = Localization.lblgorevbasligi;
            lblgorevsayisi.Text = Localization.lblgorevsayisi;
            lblgorevtanimi.Text = Localization.lblgorevtanimi;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmToDoList fr = new FrmToDoList();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
    }
}
