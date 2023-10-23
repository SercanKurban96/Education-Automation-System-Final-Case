using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.ToDoList
{
    public partial class FrmSearchToDoList : Form
    {
        public FrmSearchToDoList()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int studentid;

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmToDoList fr = new FrmToDoList();
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

        private void LoadData()
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            string query = "select ToDoListID as 'Yapılacaklar ID', ToDoListDate as 'Tarih', ToDoListTitle as 'Görev Başlığı', ToDoListContent as 'Görev İçeriği' from TBLTODOLIST inner join TBLSTUDENT on TBLTODOLIST.Student = TBLSTUDENT.StudentID WHERE Student = @p1";
            using (SqlCommand command = new SqlCommand(query, conn.connection()))
            {
                command.Parameters.AddWithValue("@p1", studentid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DtgToDoList.DataSource = dt;
            }
        }

        private void SearchData()
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            string query = "select ToDoListID as 'Yapılacaklar ID', ToDoListDate as 'Tarih', ToDoListTitle as 'Görev Başlığı', ToDoListContent as 'Görev İçeriği' from TBLTODOLIST inner join TBLSTUDENT on TBLTODOLIST.Student = TBLSTUDENT.StudentID WHERE Student = @p1 and ToDoListTitle like '%" + TxtSearchToDoList.Text + "%'";
            using (SqlCommand command = new SqlCommand(query, conn.connection()))
            {
                command.Parameters.AddWithValue("@p1", studentid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DtgToDoList.DataSource = dt;
            }
        }

        private void TxtSearchToDoList_TextChanged(object sender, EventArgs e)
        {
            SearchData();
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
        private void FrmSearchToDoList_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            kayitsayisi();
            LoadData();
            lblgorevbaslikara.Text = Localization.lblgorevbaslikara;
            lblgorevsayisi.Text = Localization.lblgorevsayisi;
            lblsearchtodolist.Text = Localization.lblsearchtodolist;
        }
    }
}
