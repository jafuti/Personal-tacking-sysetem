using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PersonalTracking
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            this.Hide();
            frmDepartment.ShowDialog();
            this.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            this.Hide();
            frmDepartment.ShowDialog();
            this.Visible = true;
            //To display new added departments
            //list = DepartmentBLL.GetDepartment();
            //dataGridView1.DataSource = list;
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;

        }

        //To display new added departments
         List<DEPARTMENT> list = new List<DEPARTMENT>();

        private void FrmDepartmentList_Load(object sender, EventArgs e)
        {
           //ist<DEPARTMENT> list = new List<DEPARTMENT>();
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;

            
            //to set greid view
            dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[1].HeaderText = "Department Name";

            //To hide the department ID

            //dataGridView1.Columns[0].Vissible = false;
            //dataGridView1.Columns[0].HeaderText = "Department Name";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
