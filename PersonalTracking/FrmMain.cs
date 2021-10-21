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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmEmployList employList = new FrmEmployList();
            this.Hide();
            employList.ShowDialog();
          
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTask_Click(object sender, EventArgs e)
        {
            FrmTaskList frmTaskList = new FrmTaskList();
            this.Hide();
            frmTaskList.ShowDialog();
            this.Visible = true;
        }

        private void BtnSalary_Click(object sender, EventArgs e)
        {
            FrmSalaryList frmSalaryList = new FrmSalaryList();
            this.Hide();
            frmSalaryList.ShowDialog();
            this.Visible = true;
        }

        private void BtnPermission_Click(object sender, EventArgs e)
        {
            FrmPermissionList permissionList = new FrmPermissionList();
            this.Hide();
            permissionList.ShowDialog();
            this.Visible = true;
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartmentList frmDepartmentList = new FrmDepartmentList();
            this.Hide();
            frmDepartmentList.ShowDialog();
            this.Visible = true;
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            FrmPositionList frmPositionList = new FrmPositionList();
            this.Hide();
            frmPositionList.ShowDialog();
            this.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Visible = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
