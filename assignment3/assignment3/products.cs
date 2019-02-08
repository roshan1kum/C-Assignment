using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class products
    {
        public string name, type;
        public int quantity;
        public double price;
        public products(string name,double price,int quantity,string type)
        {
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.price = price;
        }
        public void ListofProducts(products[] productList) {
            foreach (var i in productList)
            {
                Console.WriteLine(i.name, i.type, i.quantity, i.price);
            }
            }
    }
}
