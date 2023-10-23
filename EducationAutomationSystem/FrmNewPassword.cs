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

namespace EducationAutomationSystem
{
    public partial class FrmNewPassword : Form
    {
        public FrmNewPassword()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        sqlconnection conn = new sqlconnection();
        public string number, namesurname, picture;
        public string birthdate, email;

        public void Temizle()
        {
            TxtNewPassword.Clear();
            TxtConfirmPassword.Clear();
            TxtNewPassword.Focus();
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

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.Text == "" || TxtConfirmPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtNewPassword.Text == TxtConfirmPassword.Text)
            {
                SqlCommand command = new SqlCommand("update TBLACADEMICIAN set AcademicianPassword=@p1, AcademicianConfirmPassword=@p2 where AcademicianID=@p3 and Department=@p4", conn.connection());
                command.Parameters.AddWithValue("@p1", TxtNewPassword.Text);
                command.Parameters.AddWithValue("@p2", TxtConfirmPassword.Text);
                command.Parameters.AddWithValue("@p3", label1.Text);
                command.Parameters.AddWithValue("@p4", label2.Text);
                command.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.adminsifredegisti), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }         
            else
            {
                MessageBox.Show(String.Format(Localization.parolalaraynidegil), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtNewPassword.UseSystemPasswordChar)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                ChkNewPassword.Text = Localization.ChkNewPassword;
            }
            else
            {
                TxtNewPassword.UseSystemPasswordChar = true;
                ChkNewPassword.Text = Localization.ChkNewPassword;
            }
        }

        private void ChkConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.UseSystemPasswordChar)
            {
                TxtConfirmPassword.UseSystemPasswordChar = false;
                ChkConfirmPassword.Text = Localization.ChkConfirmPassword;
            }
            else
            {
                TxtConfirmPassword.UseSystemPasswordChar = true;
                ChkConfirmPassword.Text = Localization.ChkConfirmPassword;
            }
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmPasswordChangeForm fr = new FrmPasswordChangeForm();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        public int academicianid, departmentid;
        private void FrmNewPassword_Load(object sender, EventArgs e)
        {
            TxtNewPassword.Focus();

            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            lblconfirmpassword.Text = Localization.lblconfirmpassword;
            lblnewpassword.Text = Localization.lblnewpassword;
            lblnewpasswordform.Text = Localization.lblnewpasswordform;
            BtnCancel.Text = Localization.BtnCancel;
            BtnChange.Text = Localization.BtnChange;
            ChkConfirmPassword.Text = Localization.ChkConfirmPassword;
            ChkNewPassword.Text = Localization.ChkNewPassword;
        }
    }
}
