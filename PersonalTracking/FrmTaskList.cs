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
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            pnelForAdmin.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnelForAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void TxtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmTask frmTask = new FrmTask();
            frmTask.Hide();
            frmTask.ShowDialog();
            frmTask.Visible = true;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmTask frmTask = new FrmTask();
            frmTask.Hide();
            frmTask.ShowDialog();
            frmTask.Visible = true;
        }
    }
}
