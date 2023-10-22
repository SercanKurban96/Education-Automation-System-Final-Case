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
using EducationAutomationSystem.Entity;

namespace EducationAutomationSystem.Academician
{
    public partial class FrmEditAcademician : Form
    {
        public FrmEditAcademician()
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
            GroupBoxDisabled();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademician fr = new FrmAcademician();
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

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctAcademicianImage.ImageLocation = openFileDialog1.FileName;
            TxtPicture.Text = openFileDialog1.FileName;
        }
        public void GroupBoxEnabled()
        {
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            BtnPicture.Enabled = true;
            TxtAcademicianName.Focus();
        }
        public void GroupBoxDisabled()
        {
            groupBox4.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            BtnPicture.Enabled = false;
            TxtAcademicianName.Focus();
        }
        private void DtgAcademician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgAcademician.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                GroupBoxEnabled();
            }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            MskTRNumber.Focus();
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

        private void ChkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                ChkPassword.Text = "Gizle";
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                ChkPassword.Text = "Göster";
            }
        }

        private void ChkConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.UseSystemPasswordChar)
            {
                TxtConfirmPassword.UseSystemPasswordChar = false;
                ChkConfirmPassword.Text = "Gizle";
            }
            else
            {
                TxtConfirmPassword.UseSystemPasswordChar = true;
                ChkConfirmPassword.Text = "Göster";
            }
        }

        private void TxtAcademicianName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtAcademicianSurname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmEditAcademician_Load(object sender, EventArgs e)
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

            verilerigoster("select AcademicianID as 'ID', AcademicianTRNumber as 'TC Kimlik Numarası', AcademicianName as 'Adı', AcademicianSurname as 'Soyadı', AcademicianBirthDate as 'Doğum Tarihi', AcademicianGender as 'Cinsiyet', AcademicianPassword as 'Parola', AcademicianConfirmPassword AS 'Parola Tekrar', DepartmentName as 'Bölüm', sehiradi as 'Şehir', AcademicianDistrict as 'İlçe', AcademicianAddress as 'Adres', AcademicianPhoneNumber as 'Telefon Numarası', AcademicianMail as 'Mail Adresi', AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id");
            kayitsayisi();

            TxtAcademicianName.Focus();

            GroupBoxDisabled();

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
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
            lblakademisyensayisi.Text = Localization.lblakademisyensayisi;
            lblakademisyenduzenlemeformu.Text = Localization.lblakademisyenduzenlemeformu;
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
                MessageBox.Show(String.Format(Localization.tcnobos, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskTRNumber.Text.Length < 11)
            {
                MessageBox.Show(String.Format(Localization.errorprovidertc, MskTRNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAcademicianName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.akademisyenadibos, TxtAcademicianName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAcademicianName.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.akademisyenadi2karakterdenaz, TxtAcademicianName.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAcademicianSurname.Text == "")
            {
                MessageBox.Show(String.Format(Localization.akademisyensoyadibos, TxtAcademicianSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtAcademicianSurname.Text.Length < 2)
            {
                MessageBox.Show(String.Format(Localization.akademisyensoyadi2karakterdenaz, TxtAcademicianSurname.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (yas < 21)
            {
                MessageBox.Show(String.Format(Localization.akademisyenolmayasi, yas), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.parolabos, TxtPassword.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtConfirmPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.parolatekrarbos, TxtConfirmPassword.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MskPhoneNumber.Text == "(   )    -" || MskPhoneNumber.Text == "")
            {
                MessageBox.Show(String.Format(Localization.telefonnobos, MskPhoneNumber.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (RchAddress.Text == "")
            {
                MessageBox.Show(String.Format(Localization.adresbos, RchAddress.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtMail.Text == "")
            {
                MessageBox.Show(String.Format(Localization.mailbos, TxtMail.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtPicture.Text == "" && PctAcademicianImage.Image == null)
            {
                MessageBox.Show(String.Format(Localization.resimbos, TxtPicture.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TxtPassword.Text != TxtConfirmPassword.Text)
                {
                    MessageBox.Show(String.Format(Localization.parolalaraynidegil, TxtConfirmPassword.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update TBLACADEMICIAN set AcademicianTRNumber=@p1,AcademicianName=@p2,AcademicianSurname=@p3,AcademicianBirthDate=@p4,AcademicianGender=@p5,AcademicianPassword=@p6,AcademicianConfirmPassword=@p7,Department=@p8,AcademicianCity=@p9,AcademicianDistrict=@p10,AcademicianAddress=@p11,AcademicianPhoneNumber=@p12,AcademicianMail=@p13,AcademicianImage=@p14 where AcademicianID=@p15", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", MskTRNumber.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtAcademicianName.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p3", TxtAcademicianSurname.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p4", DtpBirthDate.Value.ToString("yyyy-MM-dd"));
                    if (RdbMale.Checked == true)
                    {
                        cinsiyet = "Erkek";
                    }
                    else if (RdbFemale.Checked == true)
                    {
                        cinsiyet = "Kadın";
                    }
                    cmd.Parameters.AddWithValue("@p5", cinsiyet);
                    cmd.Parameters.AddWithValue("@p6", TxtPassword.Text);
                    cmd.Parameters.AddWithValue("@p7", TxtConfirmPassword.Text);
                    cmd.Parameters.AddWithValue("@p8", CmbDepartment.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@p9", CmbCity.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@p10", CmbDistrict.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@p11", RchAddress.Text);
                    cmd.Parameters.AddWithValue("@p12", MskPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@p13", TxtMail.Text);
                    cmd.Parameters.AddWithValue("@p14", TxtPicture.Text);
                    cmd.Parameters.AddWithValue("@p15", TxtID.Text);

                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.akademisyenguncellendi, MskTRNumber.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select AcademicianID as 'ID', AcademicianTRNumber as 'TC Kimlik Numarası', AcademicianName as 'Adı', AcademicianSurname as 'Soyadı', AcademicianBirthDate as 'Doğum Tarihi', AcademicianGender as 'Cinsiyet', AcademicianPassword as 'Parola', AcademicianConfirmPassword AS 'Parola Tekrar', DepartmentName as 'Bölüm', sehiradi as 'Şehir', AcademicianDistrict as 'İlçe', AcademicianAddress as 'Adres', AcademicianPhoneNumber as 'Telefon Numarası', AcademicianMail as 'Mail Adresi', AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id");
                    kayitsayisi();
                    Temizle();
                    TxtAcademicianName.Focus();
                    GroupBoxDisabled();
                }
            }
        }
    }
}
