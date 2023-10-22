using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EducationAutomationSystem.Entity;

namespace EducationAutomationSystem.Student
{
    public partial class FrmListStudent : Form
    {
        public FrmListStudent()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgStudent.DataSource = ds.Tables[0];

            this.DtgStudent.Columns[6].Visible = false;
            this.DtgStudent.Columns[8].Visible = false;
            this.DtgStudent.Columns[9].Visible = false;
            this.DtgStudent.Columns[11].Visible = false;
            this.DtgStudent.Columns[12].Visible = false;
            this.DtgStudent.Columns[13].Visible = false;
            this.DtgStudent.Columns[14].Visible = false;
            this.DtgStudent.Columns[15].Visible = false;
            this.DtgStudent.Columns[17].Visible = false;
            this.DtgStudent.Columns[19].Visible = false;
        }
        void kayitsayisi()
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            SqlCommand komut = new SqlCommand("select count(*) from TBLSTUDENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStudentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
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

        private void FrmListStudent_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Adı', StudentSurname as 'Soyadı', StudentNumber as 'Okul Numarası', StudentBirthDate as 'Doğum Tarihi', StudentBirthPlace as 'Doğum Yeri', StudentGender as 'Cinsiyet', MothersName as 'Anne Adı', FathersName as 'Baba Adı', DepartmentName as 'Bölüm', sehiradi as 'Şehir', District as 'İlçe', Neighborhood as 'Mahalle', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id");
            kayitsayisi();

            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrencilistesiformu.Text = Localization.lblogrencilistesiformu;
        }
    }
}
