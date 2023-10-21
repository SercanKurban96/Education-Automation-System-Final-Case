using EducationAutomationSystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Applications
{
    public partial class FrmMusic : Form
    {
        public FrmMusic()
        {
            InitializeComponent();
        }

        private void enabledFalse()
        {
            BtnPause.Enabled = false;
            BtnStop.Enabled = false;
            BtnVolumeIncrease.Enabled = false;
            BtnVolumeReduce.Enabled = false;
            BtnFastBackward.Enabled = false;
            BtnFastForward.Enabled = false;
            trackBar1.Enabled = false;
            BtnClearAll.Enabled = false;
        }

        bool _playing = false;

        public bool isplaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    BtnPause.Image = pictureBox1.Image;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    BtnPause.Image = pictureBox2.Image;
                }
            }
        }

        private void BtnAddMusic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                {
                    listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                    listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());
                }
            }           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            BtnPause.Enabled = true;
            BtnStop.Enabled = true;
            BtnVolumeIncrease.Enabled = true;
            BtnVolumeReduce.Enabled = true;
            BtnFastForward.Enabled = true;
            BtnFastBackward.Enabled = true;
            trackBar1.Enabled = true;
            BtnClearAll.Enabled = true;
        }

        public EventHandler onAction = null;

        private void BtnPause_Click(object sender, EventArgs e)
        {
            isplaying = !isplaying;
            if (onAction != null)
            {
                onAction.Invoke(this, e);            
            }
        }

        private void FrmMusic_Load(object sender, EventArgs e)
        {
            BtnPause.Image = pictureBox2.Image;
            enabledFalse();

            lblmuzikler.Text = Localization.lblmuzikler;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            BtnPause.Image = pictureBox2.Image;
            enabledFalse();
        }

        private void BtnVolumeIncrease_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 2;
        }

        private void BtnVolumeReduce_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 2;
        }

        private void FrmMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                BtnVolumeIncrease.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                BtnVolumeReduce.PerformClick();
            }
            if (e.KeyCode == Keys.Space)
            {
                BtnPause.PerformClick();
            }
            if (e.KeyCode == Keys.Right)
            {
                BtnFastForward.PerformClick();
            }
            if (e.KeyCode == Keys.Left)
            {
                BtnFastBackward.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                BtnClearAll.PerformClick();
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void BtnFastForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void BtnFastBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            enabledFalse();
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
