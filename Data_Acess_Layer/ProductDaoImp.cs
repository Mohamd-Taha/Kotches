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
        public void addProduct(string product_code, string product_name, string product_type, int product_size, string product_color, int product_number, double product_cost, double product_price)
        {
            DALConection dal = new DALConection();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@product_code", SqlDbType.NChar, 30);
            param[0].Value = product_code;

            param[1] = new SqlParameter("@product_name", SqlDbType.NChar, 30);
            param[1].Value = product_name;

            param[2] = new SqlParameter("@product_type", SqlDbType.NChar, 30);
            param[2].Value = product_type;


            param[3] = new SqlParameter("@product_size", SqlDbType.Int);
            param[3].Value = product_size;

            param[4] = new SqlParameter("@product_color", SqlDbType.NChar, 30);
            param[4].Value = product_color;


            param[5] = new SqlParameter("@product_number", SqlDbType.Int);
            param[5].Value = product_number;



            param[6] = new SqlParameter("@product_cost", SqlDbType.Float);
            param[6].Value = product_cost;


            param[7] = new SqlParameter("@product_price", SqlDbType.Float);
            param[7].Value = product_price;


            dal.ExecuteComand("addProduct", param);
            dal.close();
        }

        public void deleteProduct(string code, string color)
        {
            throw new NotImplementedException();
        }

        public void editProduct(ProductDto product, int id)
        {
            throw new NotImplementedException();
        }

        public DataTable getProducts()
        {
            DALConection dal = new DALConection();
            dal.open();


            DataTable dt = new DataTable();
            
            dt = dal.selectData("get_products", null);
            dal.close();
            return dt;

        }

        public DataTable searchByIndex(string search_word)
        {
            throw new NotImplementedException();
        }
    }
}
