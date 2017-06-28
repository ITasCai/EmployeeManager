using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EmployeeManagerBLL;

namespace EmployeeManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDeptName();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 部门名称绑定
        /// </summary>
        public void getDeptName() {
            DataSet ds = EmployeeBLL.GetDeptNameDAL();
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.InsertAt(row, 0);
            cmbdeptName.DataSource = ds.Tables[0];
            cmbdeptName.ValueMember = "deptId";
            cmbdeptName.DisplayMember = "deptName";
        }

        private void btnempname_Click(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            da = EmployeeBLL.GetEmpNameBLL(txtempname.Text.Trim());

        }
    }
}
