using EducationAutomationSystem.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EducationAutomationSystem
{
    public partial class FrmPasswordChangeForm : Form
    {
        public FrmPasswordChangeForm()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        sqlconnection conn = new sqlconnection();
        public string number, namesurname, picture;
        public string birthdate, email;

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAcademicianLogin fr = new FrmAcademicianLogin();
            fr.number = number;
            fr.Show();
            this.Hide();
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
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            SqlCommand command = new SqlCommand("select * from TBLACADEMICIAN where AcademicianTRNumber=@p1 and AcademicianMail=@p2 and AcademicianBirthDate=@p3", conn.connection());
            command.Parameters.AddWithValue("@p1", MskTRNumber.Text);
            command.Parameters.AddWithValue("@p2", TxtMail.Text);
            command.Parameters.AddWithValue("@p3", DtpBirthDate.Value.ToString("yyyy-MM-dd"));
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (TxtSecurityCode.Text == SecurityCode)
                {
                    MessageBox.Show(String.Format(Localization.metin5), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmNewPassword fr = new FrmNewPassword();
                    fr.number = MskTRNumber.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(String.Format(Localization.hataliguvenlikkodugirisi), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (MskTRNumber.Text == "" || TxtMail.Text == "" || TxtSecurityCode.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.bilgilerhatali), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int academicianid, departmentid;
        private void FrmPasswordChangeForm_Load(object sender, EventArgs e)
        {
            academicianid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.AcademicianID).FirstOrDefault();

            departmentid = db.TBLACADEMICIAN.Where(x => x.AcademicianTRNumber == number).Select(y => y.TBLDEPARTMENT.DepartmentID).FirstOrDefault();

            label1.Text = academicianid.ToString();
            label2.Text = departmentid.ToString();

            CreateSecurityCode();
            MskTRNumber.Focus();

            lblakademisyentcno.Text = Localization.lblakademisyentcno;
            lblbirthdate.Text = Localization.lblbirthdate;
            lblguvenlikkodu.Text = Localization.lblguvenlikkodu;
            lblmail.Text = Localization.lblmail;
            lblpasswordchangeform.Text = Localization.lblpasswordchangeform;
            BtnCancel.Text = Localization.BtnCancel;
            BtnCheck.Text = Localization.BtnCheck;
        }
    }
}
