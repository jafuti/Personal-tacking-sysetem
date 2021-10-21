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
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DEPARTMENT> departmentLsit = new List<DEPARTMENT>();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
                MessageBox.Show("Please fill the position name");
            else if (cmpDepartment.SelectedIndex == -1)
                MessageBox.Show("please select department");
            else
            {

                POSITION position = new POSITION();
                position.PostionName = txtPosition.Text;
                position.DepartmentID = cmpDepartment.SelectedIndex;
                PositionBLL.AddPostion(position);
            }
        }
        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();
        private void FrmPosition_Load(object sender, EventArgs e)
        {
            
            departmentList = DepartmentBLL.GetDepartment();
            
            cmpDepartment.DataSource = departmentList;
            cmpDepartment.DisplayMember = "Department";
            cmpDepartment.ValueMember = "ID";
            cmpDepartment.SelectedIndex = -1;
        }
    }
}
