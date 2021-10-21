using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim()==" ")
            
                MessageBox.Show("Please fill the name filed");
            
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.Department1 = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department was added");
                txtDepartment.Clear();
            }
           
           

        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
