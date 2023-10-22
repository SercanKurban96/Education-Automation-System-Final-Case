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

namespace EducationAutomationSystem.Notification
{
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        private void PctAddNotification_Click(object sender, EventArgs e)
        {
            FrmAddNotification fr = new FrmAddNotification();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
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

        private void PctEditNotification_Click(object sender, EventArgs e)
        {
            FrmEditNotification fr = new FrmEditNotification();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctDeleteNotification_Click(object sender, EventArgs e)
        {
            FrmDeleteNotification fr = new FrmDeleteNotification();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void PctListNotification_Click(object sender, EventArgs e)
        {
            FrmNotificationList fr = new FrmNotificationList();
            fr.number = number;
            fr.Show();
        }

        private void PctSearchNotification_Click(object sender, EventArgs e)
        {
            FrmSearchNotification fr = new FrmSearchNotification();
            fr.number = number;
            fr.Show();
            this.Hide();
        }

        private void FrmNotification_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            lblduyuruara.Text = Localization.lblduyuruara;
            lblduyuruduzenle.Text = Localization.lblduyuruduzenle;
            lblduyuruolustur.Text = Localization.lblduyuruolustur;
            lblduyurularpanel.Text = Localization.lblduyurularpanel;
            lblduyurulistesi.Text = Localization.lblduyurulistesi;
            lblduyurusil.Text = Localization.lblduyurusil;
        }
    }
}
