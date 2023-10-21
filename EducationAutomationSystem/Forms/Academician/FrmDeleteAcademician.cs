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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EducationAutomationSystem.Academician
{
    public partial class FrmDeleteAcademician : Form
    {
        public FrmDeleteAcademician()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
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
            SqlCommand komut = new SqlCommand("select count(*) from TBLACADEMICIAN", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAcademicianCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void Temizle()
        {
            MskTRNumber.Clear();
            TxtAcademicianName.Clear();
            TxtAcademicianSurname.Clear();
            DtpBirthDate.Text = "";
            TxtPassword.Clear();
            TxtConfirmPassword.Clear();
            RchAddress.Clear();
            MskPhoneNumber.Clear();
            TxtMail.Clear();
            TxtPicture.Clear();
            PctAcademicianImage.Image = null;
        }

        private void FrmDeleteAcademician_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBLDEPARTMENT", conn.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDepartment.DisplayMember = "DepartmentName";
            CmbDepartment.ValueMember = "DepartmentID";
            CmbDepartment.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("select * from iller", conn.connection());
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbCity.DisplayMember = "sehiradi";
            CmbCity.ValueMember = "id";
            CmbCity.DataSource = dt2;

            RdbMale.Checked = true;

            verilerigoster("select AcademicianID as 'ID', AcademicianTRNumber as 'TC Kimlik Numarası', AcademicianName as 'Adı', AcademicianSurname as 'Soyadı', AcademicianBirthDate as 'Doğum Tarihi', AcademicianGender as 'Cinsiyet', AcademicianPassword as 'Parola', AcademicianConfirmPassword AS 'Parola Tekrar', DepartmentName as 'Bölüm', sehiradi as 'Şehir', AcademicianDistrict as 'İlçe', AcademicianAddress as 'Adres', AcademicianPhoneNumber as 'Telefon Numarası', AcademicianMail as 'Mail Adresi', AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id");
            kayitsayisi();

            lblakademisyentcno.Text = Localization.lblakademisyentcno;
            lblakademisyenadi.Text = Localization.lblakademisyenadi;
            lblakademisyensoyadi.Text = Localization.lblakademisyensoyadi;
            lblbirthdate.Text = Localization.lblbirthdate;
            lblgender.Text = Localization.lblgender;
            RdbMale.Text = Localization.RdbMale;
            RdbFemale.Text = Localization.RdbFemale;
            lblpassword.Text = Localization.lblpassword;
            lblconfirmpassword.Text = Localization.lblconfirmpassword;
            ChkPassword.Text = Localization.ChkPassword;
            ChkConfirmPassword.Text = Localization.ChkConfirmPassword;
            lbldepartment.Text = Localization.lbldepartment;
            groupBox4.Text = Localization.groupBox4;
            groupBox2.Text = Localization.groupBox2;
            groupBox3.Text = Localization.groupBox3;
            lblcity.Text = Localization.lblcity;
            lbldistrict.Text = Localization.lbldistrict;
            lbladdress.Text = Localization.lbladdress;
            lblphonenumber.Text = Localization.lblphonenumber;
            lblmail.Text = Localization.lblmail;
            lblphoto.Text = Localization.lblphoto;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
            lblakademisyensayisi.Text = Localization.lblakademisyensayisi;
            lblakademisyensilmeformu.Text = Localization.lblakademisyensilmeformu;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBLACADEMICIAN where AcademicianID=@p1", conn.connection());
            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.akademisyensilmebos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskTRNumber.Focus();
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.akademisyensil, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.akademisyensilindi, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    verilerigoster("select AcademicianID as 'ID', AcademicianTRNumber as 'TC Kimlik Numarası', AcademicianName as 'Adı', AcademicianSurname as 'Soyadı', AcademicianBirthDate as 'Doğum Tarihi', AcademicianGender as 'Cinsiyet', AcademicianPassword as 'Parola', AcademicianConfirmPassword AS 'Parola Tekrar', DepartmentName as 'Bölüm', sehiradi as 'Şehir', AcademicianDistrict as 'İlçe', AcademicianAddress as 'Adres', AcademicianPhoneNumber as 'Telefon Numarası', AcademicianMail as 'Mail Adresi', AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id");
                    kayitsayisi();
                    Temizle();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademician fr = new FrmAcademician();
            fr.Show();
            this.Hide();
        }

        private void DtgAcademician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = DtgAcademician.Rows[e.RowIndex].Cells[0].Value.ToString();
                MskTRNumber.Text = DtgAcademician.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtAcademicianName.Text = DtgAcademician.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtAcademicianSurname.Text = DtgAcademician.Rows[e.RowIndex].Cells[3].Value.ToString();
                DtpBirthDate.Text = DtgAcademician.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (DtgAcademician.Rows[e.RowIndex].Cells[5].Value.ToString() == "Erkek")
                {
                    RdbMale.Checked = true;
                }
                else if (DtgAcademician.Rows[e.RowIndex].Cells[5].Value.ToString() == "Kadın")
                {
                    RdbFemale.Checked = true;
                }

                TxtPassword.Text = DtgAcademician.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtConfirmPassword.Text = DtgAcademician.Rows[e.RowIndex].Cells[7].Value.ToString();
                CmbDepartment.Text = DtgAcademician.Rows[e.RowIndex].Cells[8].Value.ToString();
                CmbCity.Text = DtgAcademician.Rows[e.RowIndex].Cells[9].Value.ToString();
                CmbDistrict.Text = DtgAcademician.Rows[e.RowIndex].Cells[10].Value.ToString();
                RchAddress.Text = DtgAcademician.Rows[e.RowIndex].Cells[11].Value.ToString();
                MskPhoneNumber.Text = DtgAcademician.Rows[e.RowIndex].Cells[12].Value.ToString();
                TxtMail.Text = DtgAcademician.Rows[e.RowIndex].Cells[13].Value.ToString();
                TxtPicture.Text = DtgAcademician.Rows[e.RowIndex].Cells[14].Value.ToString();
                PctAcademicianImage.ImageLocation = DtgAcademician.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
            catch (Exception)
            {

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

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCity.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where sehirid = " + CmbCity.SelectedValue, conn.connection());
                da.Fill(dt);
                CmbDistrict.ValueMember = "id";
                CmbDistrict.DisplayMember = "ilceadi";
                CmbDistrict.DataSource = dt;
            }
        }
    }
}
