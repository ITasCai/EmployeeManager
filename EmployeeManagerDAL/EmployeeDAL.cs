using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagerCommon;

namespace EmployeeManagerDAL
{
    /// <summary>
    /// 数据访问类
    /// </summary>
    public class EmployeeDAL
    {
        /// <summary>
        /// 部门名称绑定
        /// </summary>
        /// <returns></returns>
        public static DataSet GetDeptNameDAL() {
            string str = "SELECT*FROM dbo.Department";
            DataSet da = SqlHelper.ExecuteDataSet(CommandType.Text,str,null);
            return da;
        }

        /// <summary>
        /// 根据员工姓名进行查询
        /// </summary>
        /// <returns></returns>
        public static DataSet GetEmpNameDAL(string name)
        {
            string str = string.Format("SELECT  emp.EmpID, emp.EmpName,dep.deptName,emp.EmpBirthday,emp.Empphone FROM dbo.Department dep,dbo.Employee emp WHERE  dep.deptId=emp.deptID AND emp.EmpName ='{0}'",name);

            DataSet da = SqlHelper.ExecuteDataSet(CommandType.Text,str,null);
            return da;
        }
        }
}
