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
using EducationAutomationSystem.Academician;
using System.Security;
using EducationAutomationSystem.Forms.Student;

namespace EducationAutomationSystem
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
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

        private void FrmStudentLogin_Load(object sender, EventArgs e)
        {
            CreateSecurityCode();
            lbltcno.Text = Localization.lbltcno;
            lblguvenlikkodu.Text = Localization.lblguvenlikkodu;
            LnkLblLogin.Text = Localization.LnkLblLogin;
            LnkLblClear.Text = Localization.LnkLblClear;
            lblogrencigirispaneli.Text = Localization.lblogrencigirispaneli;
            lblogrencino.Text = Localization.lblogrencino;
        }

        private void LnkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TBLSTUDENT where StudentTRNumber=@p1 and StudentNumber=@p2", conn.connection());
            command.Parameters.AddWithValue("@p1", MskTRNumber.Text);
            command.Parameters.AddWithValue("@p2", MskNumber.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (TxtSecurityCode.Text == SecurityCode)
                {
                    MessageBox.Show(String.Format(Localization.metin4), String.Format(Localization.hosgeldiniz), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmStudentPanel fr = new FrmStudentPanel();
                    fr.number = MskNumber.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(String.Format(Localization.hataliguvenlikkodugirisi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (MskTRNumber.Text == "" || MskNumber.Text == "" || TxtSecurityCode.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.hatalitcokulno), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkLblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MskTRNumber.Clear();
            MskNumber.Clear();
            TxtSecurityCode.Clear();
            MskTRNumber.Focus();
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
    }
}
