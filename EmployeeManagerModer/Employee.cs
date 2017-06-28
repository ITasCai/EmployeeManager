using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModer
{
    /// <summary>
    /// 员工类
    /// </summary>
    class Employee
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpID { set; get; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName { set; get; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public  int DeptID { set; get; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime EmpBirthday { set; get; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Empphone { set; get; }
    }
}
