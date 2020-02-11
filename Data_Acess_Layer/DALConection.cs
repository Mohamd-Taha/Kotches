using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Kotches.Data_Acess_Layer
{
    class DALConection
    {
       
        public SqlConnection sqlconnection;
        public SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        //انشاء الاتصال مابين قاعده البيانات
        public DALConection()
        {
           
            string mode = Properties.Settings.Default.Mode;
            if (mode == "sql")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = false; User ID=" + Properties.Settings.Default.User_Name + ";password=" + Properties.Settings.Default.Password + "");

            }
            else
            {


                //   sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = true ");

                //sqlconnection = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\kotches_log.ldf; Integrated Security = True; Connect Timeout = 30");

                  sqlconnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Mohamed Osama\Desktop\Kotches\Kotches\kotches.mdf; Database = kotches;
                Trusted_Connection = Yes ");


            }
        }
        //فتح الاتصال
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //غلق الاتصال
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();

            }
        }

        //قراءة البيانات

        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        {

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //طريقة الاضافة والحذف والتعديل في البيانات
        public void ExecuteComand(string stored_procedure, SqlParameter[] param)
        {
          
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    
}
}
