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

namespace EducationAutomationSystem.Notification
{
    public partial class FrmEditNotification : Form
    {
        public FrmEditNotification()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgNotification.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
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
            NotificationDisabled();
        }

        private void FrmEditNotification_Load(object sender, EventArgs e)
        {
            verilerigoster("select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı',NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION");
            kayitsayisi();
            TxtNotificationTitle.Focus();

            lblduyurubasligi.Text = Localization.lblduyurubasligi;
            lblduyuruicerik.Text = Localization.lblduyuruicerik;
            lblduyuruduzenleformu.Text = Localization.lblduyuruduzenleformu;
            lblduyurusayisi.Text = Localization.lblduyurusayisi;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
            NotificationDisabled();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtNotificationTitle.Text == "")
            {
                MessageBox.Show(String.Format(Localization.duyurubasligibos, TxtNotificationTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNotificationTitle.Focus();
                Temizle();
                NotificationDisabled();
            }
            else if (RchNotificationContent.Text == "")
            {
                MessageBox.Show(String.Format(Localization.duyuruicerigibos, RchNotificationContent.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update TBLNOTIFICATION set NotificationTitle=@p1,NotificationDescription=@p2 where NotificationID=@p3", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtNotificationTitle.Text);
                cmd.Parameters.AddWithValue("@p2", RchNotificationContent.Text);
                cmd.Parameters.AddWithValue("@p3", TxtID.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.duyuruguncellendi, TxtNotificationTitle.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster("select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı',NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION");
                Temizle();
                kayitsayisi();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            TxtNotificationTitle.Focus();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmNotification fr = new FrmNotification();
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

        public void NotificationEnabled()
        {
            TxtNotificationTitle.Enabled = true;
            RchNotificationContent.Enabled = true;
        }

        public void NotificationDisabled()
        {
            TxtNotificationTitle.Enabled = false;
            RchNotificationContent.Enabled = false;
        }

        private void DtgNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgNotification.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                NotificationEnabled();
            }
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
    }
}
