using System;
using System.Collections.Generic;
using System.Threading;
using Bakery.Goods;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Pastry plainDonut = new Pastry("Plain Donut", 2, 450);
            Pastry glazedDonut = new Pastry("Glazed Donut", 2, 500);
            Pastry chocolateDonut = new Pastry("Chocolate Donut", 2, 550);
            Pastry vanillaCupcake = new Pastry("Vanilla Cupcake", 2, 350);
            Pastry chocolateCupcake = new Pastry("Chocolate Cupcake", 2, 355);
            Pastry strawberryCupcake = new Pastry("Strawberry Cupcake", 2, 320);
            var pastryInventory = new List(Pastry)(0);
            Bread wholeGrain = new Bread("Whole Grain", 3, 300);
            Bread pumpernickel = new Bread("Pumpernickel", 3, 350);
            Bread sourdough = new Bread("Sourdough", 3, 300);
            Bread white = new Bread("White", 3, 400);
            Bread molasses = new Bread("Molasses", 3, 355);
            Bread saltedRosemary = new Bread("Salted Rosemary", 3, 310);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            string styleSeparation = "--------------------------";
            Console.SetCursorPosition((Console.WindowWidth - styleSeparation.Length) / 2, Console.CursorTop);
            Console.WriteLine(styleSeparation);
            Console.WriteLine();
            string introduction1 = "Welcome to Pierre's Bakery!";
            Console.SetCursorPosition((Console.WindowWidth - introduction1.Length) / 2, Console.CursorTop);
            Console.WriteLine(introduction1);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - styleSeparation.Length) / 2, Console.CursorTop);
            Console.WriteLine(styleSeparation);
            Thread.Sleep(1000);
            string introduction2 = "Please make a selection in the following prompts!";
            Console.SetCursorPosition((Console.WindowWidth - introduction2.Length) / 2, Console.CursorTop);
            Console.WriteLine(introduction2);
            Thread.Sleep(1000);
            Console.WriteLine();
            string prompt1 = "What would you like to do?";
            Console.SetCursorPosition((Console.WindowWidth - prompt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt1);
            string prompt2 = "(Shop/Cart/Checkout)";
            Console.SetCursorPosition((Console.WindowWidth - prompt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt2);
            string response = Console.ReadLine();
            bool userSelecting = true;
            if (response == "Shop" || response == "shop")
            {
                userSelecting = false;
                Console.WriteLine("You chose Shop!");
                Thread.Sleep(1000);
                ShoppingArea();
            }
            else if (response == "Cart" || response == "cart")
            {
                userSelecting = false;
                Console.WriteLine("You chose Cart!");
                Thread.Sleep(1000);
                CartArea();
            }
            else if (response == "Checkout" || response == "checkout")
            {
                userSelecting = false;
                Console.WriteLine("You chose Checkout!");
                Thread.Sleep(1000);
                CheckoutArea();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                Main();
            }


        }
        public static void CartArea()
        {
            Console.WriteLine("TestCart");
        }
        public static void ShoppingArea()
        {
            string shopIntro1 = "Welcome to Pierre's Bakery!";
            Console.SetCursorPosition((Console.WindowWidth - shopIntro1.Length) / 2, Console.CursorTop);
            Console.WriteLine(shopIntro1);
            Console.WriteLine();

        }
        public static void CheckoutArea()
        {
            Console.WriteLine("TestCheckout");
        }
    }
}