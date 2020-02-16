using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Kotches.Business_Interfaces
{
    interface EmployeeBao
    {
        bool addEmployee( string empName, string empUserName, string empPassword, string empAccessibility);
        bool logIn(string empUserName, string empPassword);
        bool updateEmployee(int empId, string empName, String empUserName, string empPassword, string empAccessibility);
        bool deleteEmployee(int empID);
        DataTable getEmployee();
    }
}
