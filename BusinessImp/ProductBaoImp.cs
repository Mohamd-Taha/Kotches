using Kotches.Business_Interfaces;
using Kotches.Data_Acess_Layer;
using Kotches.View;
using Kotches.Data_Acess_Layer_Interfaces;
using Kotches.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kotches.BusinessImp
{
    public class ProductBaoImp : ProductBao
    {

        ProductDaoImp Dao = new ProductDaoImp();


        public bool addProduct(string product_code, string product_name, string product_type, double product_cost, double product_price)
        {
          Dao.addProduct(product_code, product_name, product_type, product_cost, product_price);
           return true;
        }
        public bool addProductDiscription(int product_size, string product_color, int product_number, string product_code)
        {
            Dao.addProductDiscription(product_size, product_color, product_number, product_code);
            return true;
        }

        public void deleteProduct(string product_code)
        {
            Dao.deleteProduct(product_code);

        }

        public DataTable getLastProduct()
        {
            return Dao.getLastProduct();
        }

        public DataTable getLastProductId()
        {
            return Dao.getLastProductId();
        }

        public DataTable getProduct(string product_name, string product_type, double product_cost, double product_price, string product_color,  int product_size)
        {
            return Dao.getProduct(product_name,  product_type,product_cost, product_price,product_color, product_size);
        }

        public DataTable getProductForCode(string product_code)
        {
            return Dao.getProductForCode(product_code);
        }

        public DataTable getProductId(string product_code, string product_color, int product_number, int product_size)
        {
            return Dao.getProductId(product_code, product_color, product_number, product_size);
        }

        public DataTable getProducts()
        {
            return Dao.getProducts();
        }






        public DataTable searchInProducts(string searchWord)
        {
            return Dao.searchInProducts(searchWord);
        }

        public bool updateProduct(string product_code, string product_name, string product_type, double product_cost, double product_price)
        {
            Dao.updateProduct(product_code, product_name, product_type, product_cost,product_price);
            return true;
        }
        public bool updateProductDiscription(string product_code, string product_color, int product_number, int product_size, int Id)
        {

            Dao.updateProductDiscription(product_code, product_color, product_number, product_size, Id);
            return true;
        }

        public void updateProductNumber(int product_number, string product_code)
        {
            Dao.updateProductNumber(product_number, product_code);
        }
    }
}
