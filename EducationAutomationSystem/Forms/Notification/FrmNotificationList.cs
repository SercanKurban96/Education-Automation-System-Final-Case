﻿using System;
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
    public partial class FrmNotificationList : Form
    {
        public FrmNotificationList()
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
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

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