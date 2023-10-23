using EducationAutomationSystem.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace EducationAutomationSystem.Department
{
    public partial class FrmListDepartment : Form
    {
        public FrmListDepartment()
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
            DtgDepartment.DataSource = ds.Tables[0];
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

        private void FrmListDepartment_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

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
