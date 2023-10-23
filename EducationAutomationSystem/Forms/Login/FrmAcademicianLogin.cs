﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using EducationAutomationSystem.Academician;
using EducationAutomationSystem.Forms.Academician;
using EducationAutomationSystem.Entity;
using System.Linq;

namespace EducationAutomationSystem
{
    public partial class FrmAcademicianLogin : Form
    {
        public FrmAcademicianLogin()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        public int academicianid, departmentid;
        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
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

        private void LnkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TBLACADEMICIAN where AcademicianTRNumber=@p1 and AcademicianPassword=@p2", conn.connection());
            command.Parameters.AddWithValue("@p1", MskTRNumber.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (TxtSecurityCode.Text == SecurityCode)
                {
                    MessageBox.Show(String.Format(Localization.metin3), String.Format(Localization.hosgeldiniz), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAcademicianPanel fr = new FrmAcademicianPanel();
                    fr.number = MskTRNumber.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(String.Format(Localization.hataliguvenlikkodugirisi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (MskTRNumber.Text == "" || TxtPassword.Text == "" || TxtSecurityCode.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.hatalitcnosifre), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string SecurityCode;
        public void CreateSecurityCode()
        {
            SecurityCode = "";
            int letter, bigletter, which;
            Random Rletter = new Random();
            Random Rnumber = new Random();
            Random Rbigletter = new Random();
            Random Rwhich = new Random();

            for (int b = 0; b < 8; b++)
            {
                int a = 0;
                which = Rwhich.Next(1, 3);

                if (which == 1)
                {
                    SecurityCode += Rnumber.Next(0, 10).ToString();
                }
                if (which == 2)
                {
                    letter = Rletter.Next(1, 27);
                    for (char i = 'a'; i < 'z'; i++)
                    {
                        a++;
                        if (a == letter)
                        {
                            bigletter = Rbigletter.Next(1, 3);
                            if (bigletter == 1)
                            {
                                SecurityCode += i;
                            }
                            if (bigletter == 2)
                            {
                                SecurityCode += i.ToString().ToUpper();
                            }
                        }
                    }
                }
            }
            LblSecurityCode.Text = SecurityCode;
        }

        private void FrmTeacherLogin_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            CreateSecurityCode();
            lbltcno.Text = Localization.lbltcno;
            lblparola.Text = Localization.lblparola;
            ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            lblguvenlikkodu.Text = Localization.lblguvenlikkodu;
            LnkLblLogin.Text = Localization.LnkLblLogin;
            LnkLblClear.Text = Localization.LnkLblClear;
            lblakademisyengirispaneli.Text = Localization.lblakademisyengirispaneli;
            lblparolamiunuttum.Text = Localization.lblparolamiunuttum;
        }

        private void LnkLblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MskTRNumber.Clear();
            TxtPassword.Clear();
            TxtSecurityCode.Clear();
            MskTRNumber.Focus();
        }

        private void ChkShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                ChkShowHidePassword.Text = Localization.ChkShowHidePassword;
            }
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

        private void lblparolamiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPasswordChangeForm fr = new FrmPasswordChangeForm();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
    }
}
