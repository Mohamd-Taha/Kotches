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
        void addProduct(string product_code, string product_name, string product_type, int product_size, string product_color, int product_number, double product_cost, double product_price);
        void deleteProduct(string product_code, string product_color);
        void editProduct(ProductDto product, int product_code);
        DataTable searchByIndex(string search_word);
        DataTable getProducts();

    }
}
