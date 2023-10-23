using EducationAutomationSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EducationAutomationSystem.Forms.Admin
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        DbEducationEntities4 db = new DbEducationEntities4();
        public string number, username;
        public int adminid;
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

        private void PctOgrenciSirala_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                               select new
                               {
                                   ID = x.StudentID,
                                   TC = x.StudentTRNumber,
                                   Numara = x.StudentNumber,
                                   Adı = x.StudentName,
                                   Soyadı = x.StudentSurname
                               }).OrderBy(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctOgrenciSiralaTers_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                               select new
                               {
                                   ID = x.StudentID,
                                   TC = x.StudentTRNumber,
                                   Numara = x.StudentNumber,
                                   Adı = x.StudentName,
                                   Soyadı = x.StudentSurname
                               }).OrderByDescending(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctAkademisyenSirala_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                                   select new
                                   {
                                       ID = x.AcademicianID,
                                       TC = x.AcademicianTRNumber,
                                       Adı = x.AcademicianName,
                                       Soyadı = x.AcademicianSurname
                                   }).OrderBy(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctAkademisyenSiralaTers_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                                   select new
                                   {
                                       ID = x.AcademicianID,
                                       TC = x.AcademicianTRNumber,
                                       Adı = x.AcademicianName,
                                       Soyadı = x.AcademicianSurname
                                   }).OrderByDescending(x => x.Adı + " " + x.Soyadı).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctDersSirala_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                              select new
                              {
                                  ID = x.LessonID,
                                  Ders = x.LessonName
                              }).OrderBy(x => x.Ders).ToList();
            DtgReport.DataSource = lessonList;
        }

        private void PctDersSiralaTers_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                              select new
                              {
                                  ID = x.LessonID,
                                  Ders = x.LessonName
                              }).OrderByDescending(x => x.Ders).ToList();
            DtgReport.DataSource = lessonList;
        }

        private void PctBolumSirala_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                                  select new
                                  {
                                      ID = x.DepartmentID,
                                      Bölüm = x.DepartmentName
                                  }).OrderBy(x => x.Bölüm).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctBolumSiralaTers_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                                  select new
                                  {
                                      ID = x.DepartmentID,
                                      Bölüm = x.DepartmentName
                                  }).OrderByDescending(x => x.Bölüm).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctToplamOgrenciSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamogrencisayisi) + " " + db.TBLSTUDENT.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamAkademisyenSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamakademisyensayisi) + " " + db.TBLACADEMICIAN.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamDersSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamderssayisi) + " " + db.TBLLESSON.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctToplamBolumSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplambolumsayisi) + " " + db.TBLDEPARTMENT.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctSon3OgrenciKayit_Click(object sender, EventArgs e)
        {
            var studentList = (from x in db.TBLSTUDENT
                               select new
                               {
                                   ID = x.StudentID,
                                   TC = x.StudentTRNumber,
                                   Numara = x.StudentNumber,
                                   Adı = x.StudentName,
                                   Soyadı = x.StudentSurname
                               }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = studentList;
        }

        private void PctSon3AkademisyenKayit_Click(object sender, EventArgs e)
        {
            var academicianList = (from x in db.TBLACADEMICIAN
                                   select new
                                   {
                                       ID = x.AcademicianID,
                                       TC = x.AcademicianTRNumber,
                                       Adı = x.AcademicianName,
                                       Soyadı = x.AcademicianSurname
                                   }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = academicianList;
        }

        private void PctSon3BolumKayit_Click(object sender, EventArgs e)
        {
            var departmentList = (from x in db.TBLDEPARTMENT
                                  select new
                                  {
                                      ID = x.DepartmentID,
                                      Bölüm = x.DepartmentName
                                  }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = departmentList;
        }

        private void PctSon3DersKayit_Click(object sender, EventArgs e)
        {
            var lessonList = (from x in db.TBLLESSON
                              select new
                              {
                                  ID = x.LessonID,
                                  Ders = x.LessonName
                              }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = lessonList;
        }

        public void BolumlerExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select DepartmentID as 'Bölüm ID', DepartmentName as 'Bölüm Adı' from TBLDEPARTMENT";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show(String.Format(Localization.bolumverilerikaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void OgrencilerExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select StudentID as 'Öğrenci ID',StudentTRNumber as 'T.C. Kimlik Numarası',StudentName as 'Öğrenci Adı',StudentSurname as 'Öğrenci Soyadı',StudentNumber as 'Okul Numarası',StudentBirthDate as 'Doğum Tarihi',StudentBirthPlace as 'Doğum Yeri',StudentGender as 'Cinsiyet',MothersName as 'Anne Adı',FathersName as 'Baba Adı',DepartmentName as 'Bölüm', sehiradi as 'İl', ilceadi as 'İlçe', Neighborhood as 'Semt', PostalCode as 'Posta Kodu', Address as 'Adres', PhoneNumber as 'Telefon Numarası', HomePhoneNumber as 'Ev Telefonu', StudentMail as 'Mail Adresi', StudentPicture as 'Fotoğraf' from TBLSTUDENT inner join TBLDEPARTMENT ON TBLSTUDENT.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLSTUDENT.City = iller.id inner join ilceler ON TBLSTUDENT.District = ilceler.id";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }

                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show(String.Format(Localization.ogrenciverilerikaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AkademisyenlerExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select AcademicianID as 'Akademisyen ID',AcademicianTRNumber as 'T.C. Kimlik Numarası',AcademicianName as 'Akademisyen Adı',AcademicianSurname as 'Akademisyen Soyadı',AcademicianBirthDate as 'Doğum Tarihi',AcademicianGender as 'Cinsiyet',AcademicianPassword as 'Şifre',AcademicianConfirmPassword as 'Şifre Tekrar',DepartmentName as 'Bölüm',sehiradi as 'İl',ilceadi as 'İlçe',AcademicianAddress as 'Adres',AcademicianPhoneNumber as 'Telefon Numarası',AcademicianMail as 'Mail Adresi',AcademicianImage as 'Fotoğraf' from TBLACADEMICIAN inner join TBLDEPARTMENT on TBLACADEMICIAN.Department = TBLDEPARTMENT.DepartmentID inner join iller on TBLACADEMICIAN.AcademicianCity = iller.id inner join ilceler on TBLACADEMICIAN.AcademicianDistrict = ilceler.id";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show(String.Format(Localization.akademisyenverilerkaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DuyurularExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select NotificationID as 'Duyuru ID', NotificationDate as 'Duyuru Tarihi', NotificationTitle as 'Duyuru Başlığı', NotificationDescription as 'Duyuru İçeriği' from TBLNOTIFICATION";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show(String.Format(Localization.duyuruverilerkaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void NotlarExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select NoteID as 'Not ID', MidtermExam as 'Vize Notu', FinalExam as 'Final Notu', Average as 'Ortalama', LetterGrade as 'Harf Notu', LessonName as 'Ders Adı', StudentName + ' ' + StudentSurname as 'Öğrenci Adı Soyadı', AcademicianName + ' ' + AcademicianSurname as 'Akademisyen Adı Soyadı' from TBLNOTE inner join TBLLESSON on TBLNOTE.Lesson = TBLLESSON.LessonID inner join TBLSTUDENT on TBLNOTE.Student = TBLSTUDENT.StudentID inner join TBLACADEMICIAN on TBLNOTE.Academician = TBLACADEMICIAN.AcademicianID";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show(String.Format(Localization.notverilerkaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DerslerExcelAktar()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = String.Format(Localization.exceldosyasi);
            saveDialog.Title = String.Format(Localization.exceldosyasinikaydet);

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

                string query = "select LessonID as 'Ders ID', LessonName as 'Ders Adı', DepartmentName as 'Bölüm', AcademicianName + ' ' + AcademicianSurname as 'Akademisyen Adı Soyadı' from TBLLESSON inner join TBLDEPARTMENT on TBLLESSON.Department = TBLDEPARTMENT.DepartmentID inner join TBLACADEMICIAN on TBLLESSON.Academician = TBLACADEMICIAN.AcademicianID";

                SqlCommand command = new SqlCommand(query, conn.connection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                workbook.SaveAs(saveDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show(String.Format(Localization.dersverilerkaydedildi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (RdbBolumListesi.Checked)
            {
                BolumlerExcelAktar();
            }
            else if (RdbOgrenciListesi.Checked)
            {
                OgrencilerExcelAktar();
            }
            else if (RdbAkademisyenListesi.Checked)
            {
                AkademisyenlerExcelAktar();
            }
            else if (RdbDersListesi.Checked)
            {
                DerslerExcelAktar();
            }
            else if (RdbDuyuruListesi.Checked)
            {
                DuyurularExcelAktar();
            }
            else if (RdbNotListesi.Checked)
            {
                NotlarExcelAktar();
            }
            else
            {
                MessageBox.Show(String.Format(Localization.verilerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctDuyuruSirala_Click(object sender, EventArgs e)
        {
            var notificationList = (from x in db.TBLNOTIFICATION
                                  select new
                                  {
                                      ID = x.NotificationID,
                                      Tarih = x.NotificationDate,
                                      Başlık = x.NotificationTitle,
                                      İçerik = x.NotificationDescription
                                  }).OrderBy(x => x.Başlık).ToList();
            DtgReport.DataSource = notificationList;
        }

        private void PctDuyuruSiralaTers_Click(object sender, EventArgs e)
        {
            var notificationList = (from x in db.TBLNOTIFICATION
                                    select new
                                    {
                                        ID = x.NotificationID,
                                        Tarih = x.NotificationDate,
                                        Başlık = x.NotificationTitle,
                                        İçerik = x.NotificationDescription
                                    }).OrderByDescending(x => x.Başlık).ToList();
            DtgReport.DataSource = notificationList;
        }

        private void PctToplamDuyuruSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Localization.lbltoplamduyurusayisi) + " " + db.TBLNOTIFICATION.Count().ToString(), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PctSon3Duyuru_Click(object sender, EventArgs e)
        {
            var notificationList = (from x in db.TBLNOTIFICATION
                                  select new
                                  {
                                      ID = x.NotificationID,
                                      Tarih = x.NotificationDate,
                                      Başlık = x.NotificationTitle,
                                      İçerik = x.NotificationDescription
                                  }).OrderByDescending(x => x.ID).Take(3).ToList();
            DtgReport.DataSource = notificationList;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            adminid = db.TBLADMINLOGIN.Where(x => x.AdminTRNumber == number).Select(y => y.AdminID).FirstOrDefault();

            label1.Text = adminid.ToString();

            lblakademisyensirala.Text = Localization.lblakademisyensirala;
            lblakademisyensiralaters.Text = Localization.lblakademisyensiralaters;
            lblbolumsirala.Text = Localization.lblbolumsirala;
            lblbolumsiralaters.Text = Localization.lblbolumsiralaters;
            lblderssirala.Text = Localization.lblderssirala;
            lblderssiralaters.Text = Localization.lblderssiralaters;
            lblogrencisirala.Text = Localization.lblogrencisirala;
            lblogrencisiralaters.Text = Localization.lblogrencisiralaters;
            lblraporlarpaneli.Text = Localization.lblraporlarpaneli;
            lbltoplamakademisyensayisi.Text = Localization.lbltoplamakademisyensayisi;
            lbltoplambolumsayisi.Text = Localization.lbltoplambolumsayisi;
            lbltoplamderssayisi.Text = Localization.lbltoplamderssayisi;
            lbltoplamogrencisayisi.Text = Localization.lbltoplamogrencisayisi;
            lblson3akademisyenkayit.Text = Localization.lblson3akademisyenkayit;
            lblson3bolumkayit.Text = Localization.lblson3bolumkayit;
            lblson3derskayit.Text = Localization.lblson3derskayit;
            lblson3ogrencikayit.Text = Localization.lblson3ogrencikayit;
            BtnExcel.Text = Localization.BtnExcel;
            RdbAkademisyenListesi.Text = Localization.RdbAkademisyenListesi;
            RdbBolumListesi.Text = Localization.RdbBolumListesi;
            RdbDersListesi.Text = Localization.RdbDersListesi;
            RdbDuyuruListesi.Text = Localization.RdbDuyuruListesi;
            RdbNotListesi.Text = Localization.RdbNotListesi;
            RdbOgrenciListesi.Text = Localization.RdbOgrenciListesi;
            lblson3duyuru.Text = Localization.lblson3duyuru;
            lbltoplamduyurusayisi.Text = Localization.lbltoplamduyurusayisi;
            lblduyurusirala.Text = Localization.lblduyurusirala;
            lblduyurusiralaters.Text = Localization.lblduyurusiralaters;
        }
    }
}
