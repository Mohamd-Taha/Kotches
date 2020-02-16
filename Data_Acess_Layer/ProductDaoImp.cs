using Kotches.Data_Acess_Layer_Interfaces;
using Kotches.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Kotches.Data_Acess_Layer
{
    class ProductDaoImp : ProductDao
    {
        public bool addProduct(string product_code, string product_name, string product_type,  double product_cost, double product_price)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;

            param[1] = new SqlParameter("@product_name", SqlDbType.NChar, 30);
            param[1].Value = product_name;

            param[2] = new SqlParameter("@product_type", SqlDbType.NChar, 30);
            param[2].Value = product_type;



            param[3] = new SqlParameter("@product_cost", SqlDbType.Float);
            param[3].Value = product_cost;


            param[4] = new SqlParameter("@product_price", SqlDbType.Float);
            param[4].Value = product_price;


            dal.ExecuteComand("addProduct", param);
            dal.close();
            return true;
        }
        public bool addProductDiscription(int product_size, string product_color, int product_number, string product_code)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@product_size", SqlDbType.Int);
            param[0].Value = product_size;

            param[1] = new SqlParameter("@product_color", SqlDbType.NChar, 30);
            param[1].Value = product_color;


            param[2] = new SqlParameter("@product_number", SqlDbType.Int);
            param[2].Value = product_number;

            param[3] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[3].Value = product_code;





            dal.ExecuteComand("addProductDiscription", param);
            dal.close();
            return true;
        }
        public void deleteProduct(string product_code)
        {

            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;



            dal.ExecuteComand("deleteProduct", param);
            dal.close();


        }
        

        public DataTable getProducts()
        {
            DALConection dal = new DALConection();
            dal.open();


            DataTable dt = new DataTable();

            dt = dal.selectData("getProducts", null);
            dal.close();
            return dt;

        }
        public DataTable getProductId(string product_code, string product_color, int product_number, int product_size)
        {
            DALConection dal = new DALConection();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;

            param[1] = new SqlParameter("@product_color", SqlDbType.NChar, 30);
            param[1].Value = product_color;

            param[2] = new SqlParameter("@product_number", SqlDbType.Int);
            param[2].Value = product_number;

            param[3] = new SqlParameter("@product_size", SqlDbType.Int);
            param[3].Value = product_size;

            DataTable dt = new DataTable();
            dt = dal.selectData("getProductId", param);
            dal.close();
            return dt;
        }

        public DataTable getProductForCode(string product_code)
        {
            DALConection dal = new DALConection();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;
            DataTable dt = new DataTable();
            dt = dal.selectData("getProductForCode", param);
            dal.close();
            return dt;
        }

        public DataTable getLastProductId()
        {
            DALConection dal = new DALConection();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getLastProductId", null);
            dal.close();
            return dt;

        }
        public DataTable getLastProduct()
        {
            DALConection dal = new DALConection();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("getLastProduct", null);
            dal.close();
            return dt;
        }
        public DataTable getProduct(string product_name,string product_type,double product_cost,double product_price, string product_color,  int product_size)
        {
            DALConection dal = new DALConection();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@product_name", SqlDbType.NChar, 30);
            param[0].Value = product_name;


            param[1] = new SqlParameter("@product_type", SqlDbType.NChar, 30);
            param[1].Value = product_type;

            param[2] = new SqlParameter("@product_cost", SqlDbType.Float);
            param[2].Value = product_cost;


            param[3] = new SqlParameter("@product_price", SqlDbType.Float);
            param[3].Value = product_price;

            param[4] = new SqlParameter("@product_color", SqlDbType.NChar, 30);
            param[4].Value = product_color;



            param[5] = new SqlParameter("@product_size", SqlDbType.Int);
            param[5].Value = product_size;

            DataTable dt = new DataTable();
            dt = dal.selectData("getProduct", param);
            dal.close();
            return dt;
        }



        public DataTable searchInProducts(string searchWord)
        {
            DALConection dal = new DALConection();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("searchWord", SqlDbType.NChar, 30);
            param[0].Value = searchWord;
            dt = dal.selectData("searchInProducts", param);

            return dt;

        }

        public bool updateProduct(string product_code, string product_name, string product_type,  double product_cost, double product_price)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];




            param[0] = new SqlParameter("@product_name", SqlDbType.NChar, 30);
            param[0].Value = product_name;

            param[1] = new SqlParameter("@product_type", SqlDbType.NChar, 30);
            param[1].Value = product_type;

            param[2] = new SqlParameter("@product_cost", SqlDbType.Float);
            param[2].Value = product_cost;


            param[3] = new SqlParameter("@product_price", SqlDbType.Float);
            param[3].Value = product_price;


            param[4] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[4].Value = product_code;

            dal.ExecuteComand("updateProduct", param);
            dal.close();
            return true;
        }
        public bool updateProductDiscription(string product_code, string product_color, int product_number, int product_size , int Id)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];




            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;

            param[1] = new SqlParameter("@product_color", SqlDbType.NChar, 30);
            param[1].Value = product_color;

            param[2] = new SqlParameter("@product_number", SqlDbType.Int);
            param[2].Value = product_number;


            param[3] = new SqlParameter("@product_size", SqlDbType.Int);
            param[3].Value = product_size;


            param[4] = new SqlParameter("@Id", SqlDbType.Int);
            param[4].Value = Id;

            dal.ExecuteComand("updateProductDiscription", param);
            dal.close();
            return true;
        }

        public void updateProductNumber(int product_number, string product_code)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@product_number", SqlDbType.Int);
            param[0].Value = product_number;

            param[1] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[1].Value = product_code;
            dal.ExecuteComand("updateProductNumber", param);
            dal.close();
        }
    }
}
