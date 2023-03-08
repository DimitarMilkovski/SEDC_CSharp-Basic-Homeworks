using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class5.OOP.Classes
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }




    }
}
