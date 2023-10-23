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
    public partial class FrmEditToDoList : Form
    {
        public FrmEditToDoList()
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
            TxtToDoListTitle.Enabled = false;
            RchToDoListContent.Enabled = false;
        }

        private void DtgToDoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgToDoList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                TxtToDoListTitle.Enabled = true;
                RchToDoListContent.Enabled = true;
            }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
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
                int id = int.Parse(label1.Text);
                var t = db.TBLTODOLIST.Find(id);
                t.ToDoListDate = DateTime.Now;
                t.ToDoListTitle = TxtToDoListTitle.Text;
                t.ToDoListContent = RchToDoListContent.Text;
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.gorevguncellendi, TxtToDoListTitle.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                kayitsayisi();
                Temizle();
                TxtToDoListTitle.Focus();
            }
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
        private void FrmEditToDoList_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            kayitsayisi();
            LoadData();
            lbledittodolist.Text = Localization.lbledittodolist;
            lblgorevbasligi.Text = Localization.lblgorevbasligi;
            lblgorevsayisi.Text = Localization.lblgorevsayisi;
            lblgorevtanimi.Text = Localization.lblgorevtanimi;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
        }
    }
}
