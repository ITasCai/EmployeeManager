﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmployeeManagerDAL;
using EmployeeManagerModer;

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

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int AddBLL(Employee Emp)
        {
            return EmployeeDAL.AddDAL(Emp);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int ModificationBLL(Employee Emp)
        {
            return EmployeeDAL.ModificationDAL(Emp);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int DeleteBLL(Employee Emp)
        {
            return EmployeeDAL.DeleteDAL(Emp);
        }

        }
}
