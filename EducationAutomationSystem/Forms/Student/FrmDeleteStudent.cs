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

namespace EducationAutomationSystem.Student
{
    public partial class FrmDeleteStudent : Form
    {
        public FrmDeleteStudent()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
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
            SqlCommand komut = new SqlCommand("select count(*) from TBLSTUDENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStudentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        private void Temizle()
        {
            MskTRNumber.Clear();
            TxtStudentName.Clear();
            TxtStudentSurname.Clear();
            MskNumber.Clear();
            DtpBirthDate.Text = "";
            TxtBirthPlace.Clear();
            TxtMotherName.Clear();
            TxtFatherName.Clear();
            TxtNeighborhood.Clear();
            MskPostalCode.Clear();
            RchAddress.Clear();
            MskPhoneNumber.Clear();
            MskHomePhoneNumber.Clear();
            TxtMail.Clear();
            TxtPicture.Clear();
            PctStudentImage.Image = null;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmStudent fr = new FrmStudent();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBLSTUDENT where StudentID=@p1", conn.connection());
            if (MskNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrencisilmebos,MskNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskTRNumber.Focus();
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.ogrencisil, MskNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.ogrencisilindi, MskNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Adı', StudentSurname as 'Soyadı', StudentNumber as 'Okul Numarası', StudentBirthDate as 'Doğum Tarihi', StudentBirthPlace as 'Doğum Yeri', StudentGender as 'Cinsiyet', MothersName as 'Anne Adı', FathersName as 'Baba Adı', DepartmentName as 'Bölüm', sehiradi as 'Şehir', District as 'İlçe', Neighborhood as 'Mahalle', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id");
                    kayitsayisi();
                    Temizle();
                }
            }
        }

        private void FrmDeleteStudent_Load(object sender, EventArgs e)
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

            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Adı', StudentSurname as 'Soyadı', StudentNumber as 'Okul Numarası', StudentBirthDate as 'Doğum Tarihi', StudentBirthPlace as 'Doğum Yeri', StudentGender as 'Cinsiyet', MothersName as 'Anne Adı', FathersName as 'Baba Adı', DepartmentName as 'Bölüm', sehiradi as 'Şehir', District as 'İlçe', Neighborhood as 'Mahalle', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id");
            kayitsayisi();
            MskTRNumber.Focus();

            lblstudenttrno.Text = Localization.lblstudenttrno;
            lblstudentname.Text = Localization.lblstudentname;
            lblstudentsurname.Text = Localization.lblstudentsurname;
            lblstudentnumber.Text = Localization.lblstudentnumber;
            lblbirthdate.Text = Localization.lblbirthdate;
            lblbirthplace.Text = Localization.lblbirthplace;
            lblgender.Text = Localization.lblgender;
            RdbMale.Text = Localization.RdbMale;
            RdbFemale.Text = Localization.RdbFemale;
            lblmothername.Text = Localization.lblmothername;
            lblfathername.Text = Localization.lblfathername;
            lbldepartment.Text = Localization.lbldepartment;
            groupBox1.Text = Localization.groupBox1;
            groupBox2.Text = Localization.groupBox2;
            groupBox3.Text = Localization.groupBox3;
            lblcity.Text = Localization.lblcity;
            lbldistrict.Text = Localization.lbldistrict;
            lblneighborhood.Text = Localization.lblneighborhood;
            lblpostalcode.Text = Localization.lblpostalcode;
            lbladdress.Text = Localization.lbladdress;
            lblphonenumber.Text = Localization.lblphonenumber;
            lblhomephonenumber.Text = Localization.lblhomephonenumber;
            lblmail.Text = Localization.lblmail;
            lblphoto.Text = Localization.lblphoto;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrencisilmeformu.Text = Localization.lblogrencisilmeformu;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void DtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = DtgStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                MskTRNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtStudentName.Text = DtgStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtStudentSurname.Text = DtgStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                MskNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                DtpBirthDate.Text = DtgStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtBirthPlace.Text = DtgStudent.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (DtgStudent.Rows[e.RowIndex].Cells[7].Value.ToString() == "Erkek")
                {
                    RdbMale.Checked = true;
                }
                else if (DtgStudent.Rows[e.RowIndex].Cells[7].Value.ToString() == "Kadın")
                {
                    RdbFemale.Checked = true;
                }

                TxtMotherName.Text = DtgStudent.Rows[e.RowIndex].Cells[8].Value.ToString();
                TxtFatherName.Text = DtgStudent.Rows[e.RowIndex].Cells[9].Value.ToString();
                CmbDepartment.Text = DtgStudent.Rows[e.RowIndex].Cells[10].Value.ToString();
                CmbCity.Text = DtgStudent.Rows[e.RowIndex].Cells[11].Value.ToString();
                CmbDistrict.Text = DtgStudent.Rows[e.RowIndex].Cells[12].Value.ToString();
                TxtNeighborhood.Text = DtgStudent.Rows[e.RowIndex].Cells[13].Value.ToString();
                MskPostalCode.Text = DtgStudent.Rows[e.RowIndex].Cells[14].Value.ToString();
                RchAddress.Text = DtgStudent.Rows[e.RowIndex].Cells[15].Value.ToString();
                MskPhoneNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[16].Value.ToString();
                MskHomePhoneNumber.Text = DtgStudent.Rows[e.RowIndex].Cells[17].Value.ToString();
                TxtMail.Text = DtgStudent.Rows[e.RowIndex].Cells[18].Value.ToString();
                TxtPicture.Text = DtgStudent.Rows[e.RowIndex].Cells[19].Value.ToString();
                PctStudentImage.ImageLocation = DtgStudent.Rows[e.RowIndex].Cells[19].Value.ToString();
            }
            catch (Exception)
            {

            }
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
