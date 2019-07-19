using System;
using System.Collections.Generic;

namespace Bakery.Goods
{
    class Bread
    {
        public string breadName { get; set; }
        public int breadPrice { get; set; }
        public int breadCalories { get; set; }
        public Bread(string name, int price, int cals)
        {
            breadName = name;
            breadPrice = price;
            breadCalories = cals;
        }

        public void SetPrice(int newPrice)
        {
            breadPrice = newPrice;
        }

    }
    class Pastry
    {
        public string pastryName { get; set; }
        public int pastryPrice { get; set; }
        public int pastryCalories { get; set; }
        public Pastry(string name, int price, int cals)
        {
            pastryName = name;
            pastryPrice = price;
            pastryCalories = cals;
        }

        public void SetPrice(int newPrice)
        {
            pastryPrice = newPrice;
        }

    }
}



