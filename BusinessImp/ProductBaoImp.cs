using Kotches.Data_Acess_Layer;
using Kotches.Data_Acess_Layer_Interfaces;
using Kotches.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Kotches.BusinessImp
{
    class ProductBaoImp : ProductDao
    {
        ProductDaoImp Dao = new ProductDaoImp();
        public void addProduct(string product_code, string product_name, string product_type, int product_size, string product_color, int product_number, double product_cost, double product_price)
        {
            Dao.addProduct(product_code, product_name, product_type, product_size, product_color, product_number, product_cost, product_price);
        }


        public void deleteProduct(string product_code, string product_color)
        {
            throw new NotImplementedException();
        }

        public void editProduct(ProductDto product, int product_code)
        {
            throw new NotImplementedException();
        }

        public DataTable getProducts()
        {
            return Dao.getProducts();
        }

        public DataTable searchByIndex(string search_word)
        {
            throw new NotImplementedException();
        }
    }
}
