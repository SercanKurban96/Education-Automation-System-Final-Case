using EducationAutomationSystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Applications
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnKralPop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void BtnKralFM_Click(object sender, EventArgs e)
        {  
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
        }

        private void BtnIstanbulFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://45.32.154.169:9300/";
        }

        private void BtnBestFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        }

        private void BtnPalNostalji_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1010/";
        }

        private void BtnDreamturkFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/dreamturk";
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
