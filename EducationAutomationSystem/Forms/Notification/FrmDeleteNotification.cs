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

namespace EducationAutomationSystem.Notification
{
    public partial class FrmDeleteNotification : Form
    {
        public FrmDeleteNotification()
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
            DtgNotification.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            SqlCommand komut = new SqlCommand("select count(*) from TBLNOTIFICATION", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNotificationCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }
        public void Temizle()
        {
            TxtID.Clear();
            TxtNotificationTitle.Clear();
            RchNotificationContent.Clear();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtNotificationTitle.Text == "")
            {
                MessageBox.Show(String.Format(Localization.duyurubos, TxtNotificationTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNotificationTitle.Focus();
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.duyurusil, TxtNotificationTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {         
                SqlCommand cmd = new SqlCommand("delete from TBLNOTIFICATION where NotificationID=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtID.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.duyurusilindi, TxtNotificationTitle.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                TxtNotificationTitle.Focus();
                verilerigoster("select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı',NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION");
                kayitsayisi();
                }
            }
        }

        private void FrmDeleteNotification_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            TxtNotificationTitle.Focus();
            verilerigoster("select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı',NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION");
            kayitsayisi();

            lblduyurubasligi.Text = Localization.lblduyurubasligi;
            lblduyuruicerik.Text = Localization.lblduyuruicerik;
            lblduyurusilformu.Text = Localization.lblduyurusilformu;
            lblduyurusayisi.Text = Localization.lblduyurusayisi;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void DtgNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = DtgNotification.Rows[e.RowIndex].Cells[0].Value.ToString();
                DtpNotificationDate.Text = DtgNotification.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtNotificationTitle.Text = DtgNotification.Rows[e.RowIndex].Cells[2].Value.ToString();
                RchNotificationContent.Text = DtgNotification.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmNotification fr = new FrmNotification();
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
    }
}
