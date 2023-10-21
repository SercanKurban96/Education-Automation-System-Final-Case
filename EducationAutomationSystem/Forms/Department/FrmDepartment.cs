﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem.Department
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            FrmAdminPanel fr = new FrmAdminPanel();
            fr.Show();
            this.Hide();
        }

        private void PctAddDepartment_Click(object sender, EventArgs e)
        {
            FrmAddDepartment fr = new FrmAddDepartment();
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

        private void PctEditDepartment_Click(object sender, EventArgs e)
        {
            FrmEditDepartment fr = new FrmEditDepartment();
            fr.Show();
            this.Hide();
        }

        private void PctDeleteDepartment_Click(object sender, EventArgs e)
        {
            FrmDeleteDepartment fr = new FrmDeleteDepartment();
            fr.Show();
            this.Hide();
        }

        private void PctListDepartment_Click(object sender, EventArgs e)
        {
            FrmListDepartment fr = new FrmListDepartment();
            fr.Show();
        }

        private void PctSearchDepartment_Click(object sender, EventArgs e)
        {
            FrmSearchDepartment fr = new FrmSearchDepartment();
            fr.Show();
            this.Hide();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            lblbolumlerpanel.Text = Localization.lblbolumlerpanel;
            lblbolumekle.Text = Localization.lblbolumekle;
            lblbolumsil.Text = Localization.lblbolumsil;
            lblbolumduzenle.Text = Localization.lblbolumduzenle;
            lblbolumara.Text = Localization.lblbolumara;
            lblbolumlistesi.Text = Localization.lblbolumlistesi;
        }
    }
}
