using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotches.Model
{
    class ProductDto
    {
        private string product_code, product_name, product_type, product_color;
        private int product_size, product_number;
        private double product_cost, product_price;

        public int Size { get => product_size; set => product_size = value; }
        public int Number { get => product_number; set => product_number = value; }
        public double Cost { get => product_cost; set => product_cost = value; }
        public double Price { get => product_price; set => product_price = value; }
        public string Product_code { get => product_code; set => product_code = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public string Type { get => product_type; set => product_type = value; }
        public string Color { get => product_color; set => product_color = value; }

        public bool addProduct(string product_code, string product_name, string product_type, int product_size, string product_color, int product_number, double product_cost, double product_price)
        {
            this.product_code = product_code;
            this.product_name = product_name;
            this.product_type = product_type;
            this.product_size = product_size;
            this.product_color = product_color;
            this.product_number = product_number;
            this.product_cost = product_cost;
            this.product_price = product_price;
            return true;
        }

        public void deleteProduct(string product_code)
        {
            this.product_code = product_code;
        }


    }
  

}
