using System;
using System.Collections.Generic;

namespace Bakery.Goods
{
    public class Bread
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
        public int totalBreadPrice(int totalItems)
        {
            var currentBreadTotal = breadPrice * totalItems;
            var updatedBreadTotal = currentBreadTotal / 3;
            var finalBreadTotal = (updatedBreadTotal * (2 / 3)) + (currentBreadTotal % 3);
            return finalBreadTotal;
        }

    }
    public class Pastry
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

        public int totalPastryPrice(int totalItems)
        {
            var currentPastryTotal = pastryPrice * totalItems;
            var updatedPastryTotal = currentPastryTotal / 3;
            var finalPastryTotal = (updatedPastryTotal * (2 / 3)) + (currentPastryTotal % 3);
            return finalPastryTotal;
        }

    }
}



