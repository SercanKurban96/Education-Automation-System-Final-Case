using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void FrmStudentNotification_Load(object sender, EventArgs e)
        {
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

        private void PctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctExit_MouseHover(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Red;
        }

        private void PctExit_MouseLeave(object sender, EventArgs e)
        {
            PctExit.BackColor = Color.Transparent;
        }
    }
}
