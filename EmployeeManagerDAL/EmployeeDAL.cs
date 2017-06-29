using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagerCommon;
using EmployeeManagerModer;

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

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int AddDAL(Employee Emp) {
            string str = @"INSERT INTO dbo.Employee ( EmpName , deptID , EmpBirthday , Empphone )
                          VALUES  (@EmpName,@deptID,@EmpBirthday,@Empphone)";
            SqlParameter[] pa = new SqlParameter[] {
                 new SqlParameter("@EmpName",Emp.EmpName),
                 new SqlParameter("@deptID",Emp.DeptID),
                 new SqlParameter("@EmpBirthday",Emp.EmpBirthday),
                 new SqlParameter("@Empphone",Emp.Empphone),
            };
            int num = SqlHelper.ExecuteNonQuery(CommandType.Text,str,pa);
            return num;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int ModificationDAL(Employee Emp) {
            string str = @"UPDATE dbo.Employee SET EmpName=@EmpName,deptID=@deptID,
                            EmpBirthday=@EmpBirthday, Empphone=@Empphone WHERE EmpID=@EmpID";
            SqlParameter[] pa = new SqlParameter[] {
                 new SqlParameter("@EmpName",Emp.EmpName),
                 new SqlParameter("@deptID",Emp.DeptID),
                 new SqlParameter("@EmpBirthday",Emp.EmpBirthday),
                 new SqlParameter("@Empphone",Emp.Empphone),
                 new SqlParameter("@EmpID",Emp.EmpID)
            };
            int num = SqlHelper.ExecuteNonQuery(CommandType.Text, str, pa);
            return num;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Emp"></param>
        /// <returns></returns>
        public static int DeleteDAL(Employee Emp)
        {
            string str = "DELETE FROM dbo.Employee WHERE EmpID=@EmpID";
            SqlParameter pa = new SqlParameter("@EmpID",Emp.EmpID);
            int num = SqlHelper.ExecuteNonQuery(CommandType.Text, str, pa);
            return num;
        }

        }
   }
