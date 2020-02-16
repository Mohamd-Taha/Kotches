using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Kotches.Data_Acess_Layer;
using Kotches.Data_Acess_Layer_Interfaces;

namespace Kotches.Data_Acess_Layer
{
    class EmployeeDAOImp : EmployeeDao

{
    public bool addEmployee( string empName, string empUserName, string empPassword, string empAcessibility)
    {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];


            

            param[0] = new SqlParameter("@empName", SqlDbType.NChar, 30);
            param[0].Value = empName;

            param[1] = new SqlParameter("@empUserName", SqlDbType.NChar, 30);
            param[1].Value = empUserName;



            param[2] = new SqlParameter("@empPassword", SqlDbType.NChar, 30);
            param[2].Value = empPassword;


            param[3] = new SqlParameter("@empAcessibility", SqlDbType.NChar, 30);
            param[3].Value = empAcessibility;


            dal.ExecuteComand("addEmployee", param);
            dal.close();
            return true;
        }

    public bool deleteEmployee(int empID)
    {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@empID", SqlDbType.Int);
            param[0].Value = empID;



            dal.ExecuteComand("deleteEmployee", param);
            dal.close();
            return true;
        }

    public bool updateEmployee( string empName, string empUserName, string empPassword, string empAcessibility, int empId)
    {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];


           

            param[0] = new SqlParameter("@empName", SqlDbType.NChar, 30);
            param[0].Value = empName;

            param[1] = new SqlParameter("@empUserName", SqlDbType.NChar, 30);
            param[1].Value = empUserName;



            param[2] = new SqlParameter("@empPassword", SqlDbType.NChar, 30);
            param[2].Value = empPassword;


            param[3] = new SqlParameter("@empAcessibility", SqlDbType.NChar, 30);
            param[3].Value = empAcessibility;

            param[4] = new SqlParameter("@empId", SqlDbType.Int);
            param[4].Value = empId;

            dal.ExecuteComand("updateEmployee", param);
            dal.close();
            return true;
        }

    public bool logIn(string empUserName, string empPassword)
    {
        throw new NotImplementedException();
    }

        public DataTable getEmployee()
        {
            DALConection dal = new DALConection();
            dal.open();


            DataTable dt = new DataTable();

            dt = dal.selectData("getEmployee", null);
            dal.close();
            return dt;
        }
    }
}
