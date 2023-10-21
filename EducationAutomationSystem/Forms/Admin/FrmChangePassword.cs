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
using System.Configuration;

namespace EducationAutomationSystem.Admin
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();

        private void ChkCurrentPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtCurrentPassword.UseSystemPasswordChar)
            {
                TxtCurrentPassword.UseSystemPasswordChar = false;
                ChkCurrentPassword.Text = Localization.ChkCurrentPassword;
            }
            else
            {
                TxtCurrentPassword.UseSystemPasswordChar = true;
                ChkCurrentPassword.Text = Localization.ChkCurrentPassword;
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

        private void BtnChange_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TBLADMINLOGIN where AdminPassword=@p1", conn.connection());
            command.Parameters.AddWithValue("@p1", TxtCurrentPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (TxtNewPassword.Text == "" || TxtConfirmPassword.Text == "")
                {
                    MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtCurrentPassword.Text == TxtNewPassword.Text)
                {
                    MessageBox.Show(String.Format(Localization.eskiyenisifrelerayni), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
                else if (TxtNewPassword.Text == TxtConfirmPassword.Text)
                {
                    SqlCommand command2 = new SqlCommand("update TBLADMINLOGIN set AdminPassword=@p1", conn.connection());
                    command2.Parameters.AddWithValue("@p1", TxtNewPassword.Text);
                    command2.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.adminsifredegisti), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }              
                else
                {
                    MessageBox.Show(String.Format(Localization.parolalaraynidegil), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TxtCurrentPassword.Text == "" || TxtNewPassword.Text == "" || TxtConfirmPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.eskisifrehatali), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtOldPassword_Leave(object sender, EventArgs e)
        {

        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmSettings fr = new FrmSettings();
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
            TxtCurrentPassword.Clear();
            TxtNewPassword.Clear();
            TxtConfirmPassword.Clear();
            TxtCurrentPassword.Focus();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            lblsifredegisikligi.Text = Localization.lblsifredegisikliği;
            lblcurrentpassword.Text = Localization.lblcurrentpassword;
            lblnewpassword.Text = Localization.lblnewpassword;
            lblconfirmpassword.Text = Localization.lblconfirmpassword;
            BtnChange.Text = Localization.BtnChange;
            BtnCancel.Text = Localization.BtnCancel;
            ChkCurrentPassword.Text = Localization.ChkCurrentPassword;
            ChkNewPassword.Text = Localization.ChkNewPassword;
            ChkConfirmPassword.Text = Localization.ChkConfirmPassword;
        }
    }
}
