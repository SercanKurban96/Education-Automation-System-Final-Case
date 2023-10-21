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

namespace EducationAutomationSystem.Department
{
    public partial class FrmDeleteDepartment : Form
    {
        public FrmDeleteDepartment()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        void verilerigoster(string veriler)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn.connection());
            da.Fill(ds);
            DtgDepartment.DataSource = ds.Tables[0];
        }
        void kayitsayisi()
        {
            SqlCommand komut = new SqlCommand("select count(*) from TBLDEPARTMENT", conn.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblDepartmentCount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmDepartment fr = new FrmDepartment();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {       
            if (TxtDepartmentName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.bolumsilmebos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.bolumsil,TxtDepartmentName.Text), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from TBLDEPARTMENT where DepartmentID=@p1", conn.connection());
                    cmd.Parameters.AddWithValue("@p1", TxtDepartmentID.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show(String.Format(Localization.bolumsilindi, TxtDepartmentName.Text), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
                    TxtDepartmentID.Clear();
                    TxtDepartmentName.Clear();
                    TxtDepartmentName.Focus();
                    kayitsayisi();
                }
            }
        }

        private void FrmDeleteDepartment_Load(object sender, EventArgs e)
        {
            verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
            kayitsayisi();
            lblbolumadi.Text = Localization.lblbolumadi;
            lblbolumsilmenu.Text = Localization.lblbolumsilmenu;
            lblbolumsayisi.Text = Localization.lblbolumsayisi;
            BtnDelete.Text = Localization.BtnDelete;
            BtnCancel.Text = Localization.BtnCancel;
        }

        private void DtgDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtDepartmentID.Text = DtgDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtDepartmentName.Text = DtgDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtDepartmentName.Focus();
            TxtDepartmentID.Clear();
            TxtDepartmentName.Clear();
        }
    }
}
