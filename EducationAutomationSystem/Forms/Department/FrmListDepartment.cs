using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Department
{
    public partial class FrmListDepartment : Form
    {
        public FrmListDepartment()
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

        private void FrmListDepartment_Load(object sender, EventArgs e)
        {
            verilerigoster("select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT");
            kayitsayisi();
            lbllistdepartmentmenu.Text = Localization.lbllistdepartmentmenu;
            lblbolumsayisi.Text = Localization.lblbolumsayisi;
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
    }
}
