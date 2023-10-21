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
    public partial class FrmNotificationList : Form
    {
        public FrmNotificationList()
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
        private void PctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctBack_MouseHover(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Green;
        }

        private void PctBack_MouseLeave(object sender, EventArgs e)
        {
            PctBack.BackColor = Color.Transparent;
        }

        private void FrmNotificationList_Load(object sender, EventArgs e)
        {
            verilerigoster("select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı',NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION");
            kayitsayisi();

            lblduyurulistesiformu.Text = Localization.lblduyurulistesiformu;
            lblduyurusayisi.Text = Localization.lblduyurusayisi;
        }

        private void DtgNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}