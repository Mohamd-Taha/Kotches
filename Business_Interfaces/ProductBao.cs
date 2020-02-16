using Kotches.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Kotches.Business_Interfaces
{
    interface ProductBao
    {
        bool addProduct(string product_code, string product_name, string product_type, double product_cost, double product_price);
        bool addProductDiscription(int product_size, string product_color, int product_number, string product_code);

        void deleteProduct(string product_code);
        DataTable getProduct(string product_name, string product_type, double product_cost, double product_price, string product_color, int product_size);


        DataTable getProductId(string product_code, string product_color, int product_number, int product_size);
    
        DataTable getLastProductId();
        DataTable getProductForCode(string product_code);

        DataTable getLastProduct();

        DataTable getProducts();


        DataTable searchInProducts(string searchWord);
        bool updateProduct(string product_code, string product_name, string product_type, double product_cost, double product_price);

        bool updateProductDiscription(string product_code, string product_color, int product_number, int product_size, int Id);
        void updateProductNumber(int product_number, string product_code);


    }
}
