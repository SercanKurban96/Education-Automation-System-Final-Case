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

namespace EducationAutomationSystem.Academician
{
    public partial class FrmListAcademician : Form
    {
        public FrmListAcademician()
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
            DtgAcademician.DataSource = ds.Tables[0];

            this.DtgAcademician.Columns[6].Visible = false;
            this.DtgAcademician.Columns[7].Visible = false;
            this.DtgAcademician.Columns[9].Visible = false;
            this.DtgAcademician.Columns[10].Visible = false;
            this.DtgAcademician.Columns[11].Visible = false;
            this.DtgAcademician.Columns[14].Visible = false;
        }

        void kayitsayisi()
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            SqlCommand komut = new SqlCommand("select count(*) from TBLACADEMICIAN", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAcademicianCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void FrmListAcademician_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            verilerigoster("select AcademicianID as 'ID', AcademicianTRNumber as 'TC Kimlik Numarası', AcademicianName as 'Adı', AcademicianSurname as 'Soyadı', AcademicianBirthDate as 'Doğum Tarihi', AcademicianGender as 'Cinsiyet', AcademicianPassword as 'Parola', AcademicianConfirmPassword AS 'Parola Tekrar', DepartmentName as 'Bölüm', sehiradi as 'Şehir', AcademicianDistrict as 'İlçe', AcademicianAddress as 'Adres', AcademicianPhoneNumber as 'Telefon Numarası', AcademicianMail as 'Mail Adresi', AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id");
            kayitsayisi();

            lblakademisyenlistesiformu.Text = Localization.lblakademisyenlistesiformu;
            lblakademisyensayisi.Text = Localization.lblakademisyensayisi;
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
