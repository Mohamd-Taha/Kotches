using Kotches.Data_Transfare_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotches.Data_Acess_Layer_Interfaces
{
    interface EmployeeDAO
    {
         Boolean addEmployee(int empId, String empName, String empUserName, String empPassword, Boolean empAccessibility);
        Boolean logIn(String empUserName, String empPassword);
        Boolean editEmployee(int empId, String empName, String empUserName, String empPassword, Boolean empAccessibility);
        Boolean deleteEmployee(int empId);
    }
}


// edit employee function take 