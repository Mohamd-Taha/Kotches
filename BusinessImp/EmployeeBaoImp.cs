using Kotches.Business_Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Kotches.BusinessImp
{
    class EmployeeBaoImp : EmployeeBao
    {
        Data_Acess_Layer.EmployeeDAOImp Dao = new Data_Acess_Layer.EmployeeDAOImp();
        public bool addEmployee( string empName, string empUserName, string empPassword, string empAccessibility)
        {
            Dao.addEmployee(empName,empUserName,empPassword,empAccessibility);
            return true;
        }

        public bool deleteEmployee(int empID)
        {
            Dao.deleteEmployee(empID);
            return true;
        }

        public DataTable getEmployee()
        {
           return Dao.getEmployee();
            
        }

        public bool logIn(string empUserName, string empPassword)
        {
            throw new NotImplementedException();
        }

      

        public bool updateEmployee(int empId, string empName, string empUserName, string empPassword, string empAccessibility)
        {
            Dao.updateEmployee(empName, empUserName, empPassword, empAccessibility, empId);
            return true;
        }
    }
}
