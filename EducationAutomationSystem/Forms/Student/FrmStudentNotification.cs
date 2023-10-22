using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Forms.Student
{
    public partial class FrmStudentNotification : Form
    {
        public FrmStudentNotification()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, namesurname, picture;
        int studentid;

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void FrmStudentNotification_Load(object sender, EventArgs e)
        {
            studentid = db.TBLSTUDENT.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            label1.Text = studentid.ToString();

            var values = from x in db.TBLNOTIFICATION
                         select new
                         {
                            ID = x.NotificationID,
                            Tarih = x.NotificationDate,
                            Başlık = x.NotificationTitle,
                            Açıklama = x.NotificationDescription
                         };
            DtgNotifications.DataSource = values.ToList();

            lblduyurularpanel.Text = Localization.lblduyurularpanel;
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmStudentPanel fr = new FrmStudentPanel();
            fr.number = number;
            fr.Show();
            this.Hide();
        }
    }
}
