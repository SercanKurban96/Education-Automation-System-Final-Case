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
    public partial class FrmAddNotification : Form
    {
        public FrmAddNotification()
        {
            InitializeComponent();
        }
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;

        sqlconnection conn = new sqlconnection();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DateTime notificationDate = DateTime.Now;
            if (TxtNotificationTitle.Text == "")
            {
                MessageBox.Show(String.Format(Localization.duyurubasligibos, TxtNotificationTitle.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNotificationTitle.Focus();
            }
            else if (RchNotificationContent.Text == "")
            {
                MessageBox.Show(String.Format(Localization.duyuruicerigibos, RchNotificationContent.Text), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into TBLNOTIFICATION (NotificationDate,NotificationTitle,NotificationDescription) values (@p1,@p2,@p3)", conn.connection());
                cmd.Parameters.AddWithValue("@p1", notificationDate);
                cmd.Parameters.AddWithValue("@p2", TxtNotificationTitle.Text);
                cmd.Parameters.AddWithValue("@p3", RchNotificationContent.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show(String.Format(Localization.duyurueklendi, TxtNotificationTitle.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                TxtNotificationTitle.Focus();
                kayitsayisi();
            }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Temizle();
            TxtNotificationTitle.Focus();
        }

        private void FrmAddNotification_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            TxtNotificationTitle.Focus();
            kayitsayisi();

            lblduyurubasligi.Text = Localization.lblduyurubasligi;
            lblduyuruicerik.Text = Localization.lblduyuruicerik;
            lblduyuruolusturformu.Text = Localization.lblduyuruolusturformu;
            lblduyurusayisi.Text = Localization.lblduyurusayisi;
            BtnAdd.Text = Localization.BtnAdd;
            BtnCancel.Text = Localization.BtnCancel;
        }
    }
}
