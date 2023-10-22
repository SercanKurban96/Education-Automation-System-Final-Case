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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EducationAutomationSystem.Entity;

namespace EducationAutomationSystem.Department
{
    public partial class FrmEditDepartment : Form
    {
        public FrmEditDepartment()
        {
            InitializeComponent();
        }

        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmDepartment fr = new FrmDepartment();
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

        public int varMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select Count(DepartmentName) from TBLDEPARTMENT where DepartmentName= '" + TxtDepartmentName.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu, conn.connection());

            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            conn.connection().Close();
            return sonuc;
        }
        void kayitsayisi()
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            SqlCommand komut = new SqlCommand("select count(*) from TBLDEPARTMENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblDepartmentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }

        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgDepartment.DataSource = ds.Tables[0];
        }

        private void DtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedValue = DtgDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                TxtDepartmentName.Text = selectedValue;
                TxtDepartmentName.Enabled = true;
                TxtDepartmentName.Focus();
            }
            try
            {
                TxtDepartmentID.Text = DtgDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtDepartmentName.Text = DtgDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void FrmEditDepartment_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            TxtDepartmentName.Focus();
            kayitsayisi();
            verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
            lblbolumadi.Text = Localization.lblbolumadi;
            lblbolumduzenlemenu.Text = Localization.lblbolumduzenlemenu;
            lblbolumsayisi.Text = Localization.lblbolumsayisi;
            BtnEdit.Text = Localization.BtnEdit;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtDepartmentName.Focus();
            TxtDepartmentID.Clear();
            TxtDepartmentName.Clear();
            TxtDepartmentName.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtDepartmentName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.bolumbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
                TxtDepartmentName.Clear();
                TxtDepartmentName.Enabled = false;
            }
            else if (TxtDepartmentName.Text.Length < 5)
            {
                MessageBox.Show(String.Format(Localization.bolum5karakterdenaz), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
                TxtDepartmentName.Clear();
                TxtDepartmentName.Enabled = false;
            }
            else
            {
                if (varMi(TxtDepartmentName.Text) != 0)
                {
                    MessageBox.Show(String.Format(Localization.aynibolum, TxtDepartmentName.Text), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtDepartmentName.Focus();
                    TxtDepartmentName.Clear();
                    TxtDepartmentName.Enabled = false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update TBLDEPARTMENT set DepartmentName=@p1 where DepartmentID=@p2", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtDepartmentName.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtDepartmentID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.bolumguncellendi, TxtDepartmentName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
                    TxtDepartmentName.Clear();
                    TxtDepartmentName.Focus();
                    TxtDepartmentName.Enabled = false;
                }
            }
        }
    }
}
