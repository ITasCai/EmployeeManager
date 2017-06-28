using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmployeeManagerDAL;


namespace EmployeeManagerBLL
{
    /// <summary>
    /// 业务逻辑类
    /// </summary>
    public class EmployeeBLL
    {
        /// <summary>
        /// 部门名称绑定
        /// </summary>
        /// <returns></returns>
        public static DataSet GetDeptNameDAL()
        {
            return EmployeeDAL.GetDeptNameDAL();
        }

        /// <summary>
        /// 根据员工姓名进行查询
        /// </summary>
        /// <returns></returns>
        public static DataSet GetEmpNameBLL(string name)
        {
            return EmployeeDAL.GetEmpNameDAL(name);
        }
        }
}
