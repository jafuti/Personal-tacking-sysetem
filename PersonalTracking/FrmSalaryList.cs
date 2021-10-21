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
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmSalary frmSalary = new FrmSalary();
            this.Hide();
            frmSalary.ShowDialog();
            this.Visible = true;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmSalary frmSalary = new FrmSalary();
            this.Hide();
            frmSalary.ShowDialog();
            this.Visible = true;
        }
    }
}
