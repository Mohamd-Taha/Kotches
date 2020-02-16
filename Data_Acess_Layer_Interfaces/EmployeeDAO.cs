using Kotches.Data_Transfare_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Kotches.Data_Acess_Layer_Interfaces
{
    interface EmployeeDao
    {
        bool addEmployee( string empName, string empUserName, string empPassword, string empAcessibility);
        bool logIn(string empUserName, string empPassword);
        bool updateEmployee( string empName, String empUserName, string empPassword, string empAcessibility, int empId);
        bool deleteEmployee(int empID);
        DataTable getEmployee();
    }
}


// edit employee function take 