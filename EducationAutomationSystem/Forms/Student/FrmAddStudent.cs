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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
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
        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(StudentTRNumber) from TBLSTUDENT where StudentTRNumber= '" + MskTRNumber.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
        }
        public int varMi2(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(StudentNumber) from TBLSTUDENT where StudentNumber= '" + MskNumber.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            DateTime dogumGunu = DateTime.Parse(DtpBirthDate.Text);
            DateTime buGun = DateTime.Now;
            int yas = buGun.Year - dogumGunu.Year;
            if (dogumGunu > buGun.AddYears(-yas))
                yas--;

            if (MskTRNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.tcnobos,MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskTRNumber.Text.Length < 11)
            {
                MessageBox.Show(String.Format(Localization.errorprovidertc, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtStudentName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.ogrenciadibos,TxtStudentName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (varMi(MskTRNumber.Text) != 0)
                {
                    MessageBox.Show(String.Format(Localization.ayniogrencitc, MskTRNumber.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MskTRNumber.Focus();
                }
                else if (varMi2(MskNumber.Text) != 0)
                {
                    MessageBox.Show(String.Format(Localization.ayniokulno, MskNumber.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MskTRNumber.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into TBLSTUDENT (StudentTRNumber,StudentName,StudentSurname,StudentNumber,StudentBirthDate,StudentBirthPlace,StudentGender,MothersName,FathersName,Department,City,District,Neighborhood,PostalCode,Address,PhoneNumber,HomePhoneNumber,StudentMail,StudentPicture) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19)", conn.connection());
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
                    
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.ogrencikaydedildi, MskNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayitsayisi();
                    Temizle();
                    MskTRNumber.Focus();
                }
            }
        }       
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            MskTRNumber.Focus();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
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

            RdbMale.Checked = true;
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
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
            lblogrencisayisi.Text = Localization.lblogrencisayisi;
            lblstudentregistrationform.Text = Localization.lblstudentregistrationform;
        }

        private void MskTRNumber_TextChanged(object sender, EventArgs e)
        {
            if (MskTRNumber.Text.Length < 11)
            {
                errorProvider1.SetError(MskTRNumber, String.Format(Localization.errorprovidertc));
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

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctStudentImage.ImageLocation = openFileDialog1.FileName;
            TxtPicture.Text = openFileDialog1.FileName;
        }
    }
}
