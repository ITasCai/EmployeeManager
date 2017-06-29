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
using EmployeeManagerModer;

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
        public void getDeptName()
        {
            DataSet ds = EmployeeBLL.GetDeptNameDAL();
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.InsertAt(row, 0);
            cmbdeptName.DataSource = ds.Tables[0];
            cmbdeptName.ValueMember = "deptId";
            cmbdeptName.DisplayMember = "deptName";
        }

        /// <summary>
        /// 根据员工姓名查询内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnempname_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet da = new DataSet();
                da = EmployeeBLL.GetEmpNameBLL(txtempname.Text.Trim());
                dgvshow.DataSource = da.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            IfNull();

            try
            {

                
                    Employee em = new Employee();
                    em.EmpName = txtname.Text.Trim();
                    em.DeptID = Convert.ToInt32(cmbdeptName.SelectedValue);
                    em.EmpBirthday = Convert.ToDateTime(txtEmpBirthday.Text.Trim());
                    em.Empphone = txtEmpphone.Text.Trim();

                    int num = EmployeeBLL.AddBLL(em);
                    if (num > 0)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        public void IfNull()
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("姓名不能为空");
                return;

            }
            if (string.IsNullOrEmpty(txtEmpBirthday.Text))
            {
                MessageBox.Show("出生日期不能为空");
                return;

            }
            if (string.IsNullOrEmpty(txtEmpphone.Text))
            {
                MessageBox.Show("手机号不能为空");
                return;
            }
         
        }

        private void dgvshow_Click(object sender, EventArgs e)
        {
            int index = dgvshow.CurrentCell.RowIndex;
            txtEmpID.Text = dgvshow.Rows[index].Cells[0].Value.ToString();
            txtname.Text = dgvshow.Rows[index].Cells[1].Value.ToString();
            cmbdeptName.Text = dgvshow.Rows[index].Cells[2].Value.ToString();
            txtEmpBirthday.Text = dgvshow.Rows[index].Cells[3].Value.ToString();
            txtEmpphone.Text = dgvshow.Rows[index].Cells[4].Value.ToString();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnxg_Click(object sender, EventArgs e)
        {

            IfNull();

            try
            {
                    Employee em = new Employee();
                    em.EmpName = txtname.Text.Trim();
                    em.DeptID = Convert.ToInt32(cmbdeptName.SelectedValue);
                    em.EmpBirthday = Convert.ToDateTime(txtEmpBirthday.Text.Trim());
                    em.Empphone = txtEmpphone.Text.Trim();
                    em.EmpID = Convert.ToInt32(txtEmpID.Text.Trim());

                    int num = EmployeeBLL.ModificationBLL(em);
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            IfNull();
            try
            {
                Employee em = new Employee();
                em.EmpID = Convert.ToInt32(txtEmpID.Text.Trim());

                int num = EmployeeBLL.DeleteBLL(em);
                if (num > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
