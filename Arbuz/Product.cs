using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    public class Product
    {
        //const int MIN_PRICE_LEVEL1 = 100;
        //const int MAX_PRICE_LEVEL1 = 999;

        //const int MIN_PRICE_LEVEL2 = 1000;
        //const int MAX_PRICE_LEVEL2 = 4999;

        //const int MIN_PRICE_LEVEL3 = 5000;
        //const int MAX_PRICE_LEVEL3 = 9999;

        //const int MIN_PRICE_LEVEL4 = 10000;
        //const int MAX_PRICE_LEVEL4 = 20000;

        //Random random = new Random();

        //public int RandomPrice(int minNum, int maxNum)
        //{
        //    return random.Next(minNum, maxNum);
        //}

        public string Section { get; set; } 
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product()
        {
            Section = null;
            Category = null;
            Subcategory = null;
            Name = null;
            Price = 0;
        }

        public Product(string section, string category,string subcategory, string name, int price)
        {
            Section = section;
            Category = category;
            Subcategory = subcategory;
            Name = name;
            Price = price;
        }

    }
}
