using System;
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
    public partial class FrmEmployList : Form
    {
        public FrmEmployList()
        {
            InitializeComponent();
        }

        private void TxtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.Hide();
            frmEmployee.ShowDialog();
            frmEmployee.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.Hide();
            frmEmployee.ShowDialog();
            frmEmployee.Visible = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
