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
    public partial class FrmDeleteToDoList : Form
    {
        public FrmDeleteToDoList()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int studentid;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtToDoListTitle.Text == "")
            {
                MessageBox.Show(String.Format(Localization.gorevbaslikbos, TxtToDoListTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(label1.Text);
                var x = db.TBLTODOLIST.Find(id);
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.gorevsil, TxtToDoListTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.TBLTODOLIST.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.gorevsilindi, TxtToDoListTitle.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayitsayisi();
                    Temizle();            
                    LoadData();
                    TxtToDoListTitle.Focus();
                }
            }
        }

        private void DtgToDoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Text = DtgToDoList.Rows[e.RowIndex].Cells[0].Value.ToString();
                DtpToDoListDate.Text = DtgToDoList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtToDoListTitle.Text = DtgToDoList.Rows[e.RowIndex].Cells[2].Value.ToString();
                RchToDoListContent.Text = DtgToDoList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void FrmDeleteToDoList_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            kayitsayisi();
            LoadData();
            lbldeletetodolist.Text = Localization.lbldeletetodolist;
            lblgorevbasligi.Text = Localization.lblgorevbasligi;
            lblgorevsayisi.Text = Localization.lblgorevsayisi;
            lblgorevtanimi.Text = Localization.lblgorevtanimi;
            BtnDelete.Text = Localization.BtnDelete;
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
