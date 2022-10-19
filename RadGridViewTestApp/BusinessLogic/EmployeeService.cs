using RadGridViewTestApp.Data.Helper;
using RadGridViewTestApp.Data.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewTestApp.BusinessLogic
{
    public static class EmployeeService
    {
        public static DataSet GetEmployee(int Id) { 
             DbHelper dbHelper = new DbHelper();
            SqlParameter[] parameters = {
                new SqlParameter("@Id",Id) 
            };
            DataSet ds = dbHelper.GetDataset(StoreProcedureConstant.GET_EMPLOYEE, parameters);  
            return ds;
        }
        public static int SaveAndUpdateEmployee(EmployeeDto employeeObj)
        {
            DbHelper dbHelper = new DbHelper();
            SqlParameter[] parameters = {
                new SqlParameter("@Id",employeeObj.Id),
                new SqlParameter("@TitleOfCourtsey",employeeObj.TitleOfCourtesy),
                new SqlParameter("@FirstName",employeeObj.FirstName),
                new SqlParameter("@LastName",employeeObj.LastName),
                new SqlParameter("@Title",employeeObj.Title),
                new SqlParameter("@BirthDate",employeeObj.DateOfBirth),
                new SqlParameter("@HireDate",employeeObj.HireDate),
                new SqlParameter("@Address",employeeObj.Address),
                new SqlParameter("@City",employeeObj.City),
                new SqlParameter("@Region",employeeObj.Region),
                new SqlParameter("@PostalCode",employeeObj.PostalCode),
            };
           int id = dbHelper.ExecuteQuery(StoreProcedureConstant.INSERT_UPDATE_EMPLOYEE, parameters);
            return id;
        }
        public static int DeleteEmployee(int Id)
        {
            DbHelper dbHelper = new DbHelper();
            SqlParameter[] parameters = {
                new SqlParameter("@Id",Id),
            };
            int id = dbHelper.ExecuteQuery(StoreProcedureConstant.DELETE_EMPLOYEE, parameters);
            return id;
        }
    }
}
