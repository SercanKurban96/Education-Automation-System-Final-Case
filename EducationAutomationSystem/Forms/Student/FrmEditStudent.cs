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
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;

        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(StudentTRNumber) from TBLSTUDENT where StudentTRNumber= '" + MskTRNumber.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
        }

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
        private void Temizle()
        {
            TxtID.Clear();
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
            GroupBoxDisabled();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmStudent fr = new FrmStudent();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            DateTime dogumGunu = DateTime.Parse(DtpBirthDate.Text);
            DateTime buGun = DateTime.Now;
            int yas = buGun.Year - dogumGunu.Year;
            if (dogumGunu > buGun.AddYears(-yas))
                yas--;

            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.tcnobos, MskNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskTRNumber.Text.Length < 11)
            {
                MessageBox.Show(String.Format(Localization.errorprovidertc, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtStudentName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrenciadibos, TxtStudentName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtStudentName.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.ogrenciadi2karakterdenaz, TxtStudentName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtStudentSurname.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrencisoyadibos, TxtStudentSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtStudentSurname.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.ogrencisoyadi2karakterdenaz, TxtStudentSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrencinumarabos, MskNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (yas < 17)
            {
                MessageBox.Show(String.Format(Localization.ogrenciuniversiteyasi, yas), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtBirthPlace.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrencidogumyeribos, TxtBirthPlace.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtMotherName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.anneadibos, TxtMotherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtMotherName.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.anneadi2karakterdenaz, TxtMotherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtFatherName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.babaadibos, TxtFatherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtFatherName.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.babaadi2karakterdenaz, TxtFatherName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtNeighborhood.Text == "")
            {
                MessageBox.Show(String.Format(Localization.semtbos, TxtNeighborhood.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskPostalCode.Text == "")
            {
                MessageBox.Show(String.Format(Localization.postakodubos, MskPostalCode.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RchAddress.Text == "")
            {
                MessageBox.Show(String.Format(Localization.adresbos, RchAddress.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskPhoneNumber.Text == "(   )    -" || MskPhoneNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.telefonnobos, MskPhoneNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtMail.Text == "")
            {
                MessageBox.Show(String.Format(Localization.mailbos, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtPicture.Text == "" && PctStudentImage.Image == null)
            {
                MessageBox.Show(String.Format(Localization.resimbos, TxtPicture.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update TBLSTUDENT set StudentTRNumber=@p1,StudentName=@p2,StudentSurname=@p3,StudentNumber=@p4,StudentBirthDate=@p5,StudentBirthPlace=@p6,StudentGender=@p7,MothersName=@p8,FathersName=@p9,Department=@p10,City=@p11,District=@p12,Neighborhood=@p13,PostalCode=@p14,Address=@p15,PhoneNumber=@p16,HomePhoneNumber=@p17,StudentMail=@p18,StudentPicture=@p19 where StudentID=@p20", conn.connection());
                cmd.Parameters.AddWithValue("@p1", MskTRNumber.Text);
                cmd.Parameters.AddWithValue("@p2", TxtStudentName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p3", TxtStudentSurname.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p4", MskNumber.Text);
                cmd.Parameters.AddWithValue("@p5", DtpBirthDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@p6", TxtBirthPlace.Text.ToUpper());
                if (RdbMale.Checked == true)
                {
                    cinsiyet = "Erkek";
                }
                else if (RdbFemale.Checked == true)
                {
                    cinsiyet = "Kadın";
                }
                cmd.Parameters.AddWithValue("@p7", cinsiyet);
                cmd.Parameters.AddWithValue("@p8", TxtMotherName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p9", TxtFatherName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p10", CmbDepartment.SelectedValue);
                cmd.Parameters.AddWithValue("@p11", CmbCity.SelectedValue);
                cmd.Parameters.AddWithValue("@p12", CmbDistrict.SelectedValue);
                cmd.Parameters.AddWithValue("@p13", TxtNeighborhood.Text.ToUpper());
                cmd.Parameters.AddWithValue("@p14", MskPostalCode.Text);
                cmd.Parameters.AddWithValue("@p15", RchAddress.Text);
                cmd.Parameters.AddWithValue("@p16", MskPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@p17", MskHomePhoneNumber.Text);
                cmd.Parameters.AddWithValue("@p18", TxtMail.Text);
                cmd.Parameters.AddWithValue("@p19", TxtPicture.Text);
                cmd.Parameters.AddWithValue("@p20", TxtID.Text);

                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.ogrenciguncellendi, MskNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Adı', StudentSurname as 'Soyadı', StudentNumber as 'Okul Numarası', StudentBirthDate as 'Doğum Tarihi', StudentBirthPlace as 'Doğum Yeri', StudentGender as 'Cinsiyet', MothersName as 'Anne Adı', FathersName as 'Baba Adı', DepartmentName as 'Bölüm', sehiradi as 'Şehir', District as 'İlçe', Neighborhood as 'Mahalle', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id");
                Temizle();
                kayitsayisi();
                TxtStudentName.Focus();
                GroupBoxDisabled();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            TxtStudentName.Focus();
            GroupBoxDisabled();
        }

        public void GroupBoxEnabled()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            BtnPicture.Enabled = true;
            TxtStudentName.Focus();
        }
        public void GroupBoxDisabled()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            BtnPicture.Enabled = false;
            TxtStudentName.Focus();
        }

        private void DtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                GroupBoxEnabled();
            }
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

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

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

            verilerigoster("select StudentID as 'ID', StudentTRNumber as 'TC Kimlik Numarası', StudentName as 'Adı', StudentSurname as 'Soyadı', StudentNumber as 'Okul Numarası', StudentBirthDate as 'Doğum Tarihi', StudentBirthPlace as 'Doğum Yeri', StudentGender as 'Cinsiyet', MothersName as 'Anne Adı', FathersName as 'Baba Adı', DepartmentName as 'Bölüm', sehiradi as 'Şehir', District as 'İlçe', Neighborhood as 'Mahalle', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT on TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id");
            kayitsayisi();

            TxtStudentName.Focus();

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
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblogrenciduzenlemeformu.Text = Localization.lblogrenciduzenlemeformu;
        }

        private void MskTRNumber_TextChanged(object sender, EventArgs e)
        {
            if (MskTRNumber.Text.Length < 11)
            {
                errorProvider1.SetError(MskTRNumber, "T.C. Kimlik Numarası 11 karakter olmalıdır.");
            }
            else
            {
                errorProvider1.Clear();
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

        private void TxtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtStudentSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtBirthPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtMotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNeighborhood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctStudentImage.ImageLocation = openFileDialog1.FileName;
            TxtPicture.Text = openFileDialog1.FileName;
        }
    }
}
