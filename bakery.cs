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
        public static int totalBreadPrice(int totalItems)
        {
            int breadPrice = 3;
            int currentBreadTotal = breadPrice * totalItems;
            int finalBreadTotal = currentBreadTotal;
            if (totalItems > 2)
            {
                if (totalItems % 2 == 0)
                {
                    finalBreadTotal = (finalBreadTotal / 2);
                }
                else
                {
                    finalBreadTotal = ((finalBreadTotal / 2) + ((totalItems % 2) * breadPrice));
                }
            }
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

        public static int totalPastryPrice(int totalItems)
        {
            int pastryPrice = 2;
            int currentPastryTotal = pastryPrice * totalItems;
            double finalPastryTotal = (double)currentPastryTotal;
            if (totalItems >= 3)
            {
                finalPastryTotal = (finalPastryTotal * .66) + ((totalItems % 3) * pastryPrice);
            }
            return (int)finalPastryTotal;
        }
    }
}



