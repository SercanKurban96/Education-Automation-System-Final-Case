using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblegitimotomasyonsistemi.Text = Localization.lblegitimotomasyonsistemi;
            lblyukleniyor.Text = Localization.lblyukleniyor;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "~ " + DateTime.Now.Year.ToString() + " ~";
            progressBar1.Increment(1);
            label4.Text = "%" + progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                FrmLogin fr = new FrmLogin();
                fr.Show();
                this.Hide();
            }
        }
    }
}
