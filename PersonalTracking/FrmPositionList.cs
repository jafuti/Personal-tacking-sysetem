﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmPosition frmPosition = new FrmPosition();
            this.Hide();
            frmPosition.ShowDialog();
            this.Visible = true;
           

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmPosition frmPosition = new FrmPosition();
            this.Hide();
            frmPosition.ShowDialog();
            this.Visible = true;
        }
    }
}
