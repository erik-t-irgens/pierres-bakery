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
            // CONSTRUCTORS FOR ALL SHOP ITEMS AVAILABLE
            Pastry plainDonut = new Pastry("Plain Donut", 2, 450);
            Pastry glazedDonut = new Pastry("Glazed Donut", 2, 500);
            Pastry chocolateDonut = new Pastry("Chocolate Donut", 2, 550);
            Pastry vanillaCupcake = new Pastry("Vanilla Cupcake", 2, 350);
            Pastry chocolateCupcake = new Pastry("Chocolate Cupcake", 2, 355);
            Pastry strawberryCupcake = new Pastry("Strawberry Cupcake", 2, 320);
            // LIST FOR SHOP INVENTORY AND FOR USER CART CREATED
            List<Pastry> pastryInventory = new List<Pastry>() { plainDonut, glazedDonut, chocolateDonut, vanillaCupcake, chocolateCupcake, strawberryCupcake };
            List<Pastry> pastryCart = new List<Pastry>(0);
            Bread wholeGrain = new Bread("Whole Grain", 3, 300);
            Bread pumpernickel = new Bread("Pumpernickel", 3, 350);
            Bread sourdough = new Bread("Sourdough", 3, 300);
            Bread white = new Bread("White", 3, 400);
            Bread molasses = new Bread("Molasses", 3, 355);
            Bread saltedRosemary = new Bread("Salted Rosemary", 3, 310);
            // LIST FOR SHOP INVENTORY AND FOR USER CART CREATED
            List<Bread> breadInventory = new List<Bread>() { wholeGrain, pumpernickel, sourdough, white, molasses, saltedRosemary };
            List<Bread> breadCart = new List<Bread>(0);
            LandingPage(pastryInventory, pastryCart, breadInventory, breadCart);
        }
        public static void LandingPage(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {


            //    INTRODUCTORY AREA with STYLING (Centering lines, background color, etc)
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
            // DECIDES WHAT TO DO WHEN USER ANSWERS
            if (response == "Shop" || response == "shop")
            {
                Console.WriteLine("You chose Shop!");
                Thread.Sleep(1000);
                ShoppingMainPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else if (response == "Cart" || response == "cart")
            {
                Console.WriteLine("You chose Cart!");
                Thread.Sleep(1000);
                CartArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else if (response == "Checkout" || response == "checkout")
            {
                Console.WriteLine("You chose Checkout!");
                Thread.Sleep(1000);
                CheckoutArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                LandingPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
        }

        // MAIN AREA FOR ALL ITEMS ADDED TO CART
        public static void CartArea(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {
            Console.WriteLine("Items in your Cart: ");
            foreach (Bread item in breadCart)
            {
                Console.WriteLine(item.breadName + "- $" + item.breadPrice);
            }
            foreach (Pastry item in pastryCart)
            {
                Console.WriteLine(item.pastryName + "- $" + item.pastryPrice);
            }
            int pastryCount = pastryCart.Count;
            int breadCount = breadCart.Count;
            Console.WriteLine("Your current total is: $" + (Pastry.totalPastryPrice(pastryCount) + Bread.totalBreadPrice(breadCount)) + " --- Discounts Applied");
            string prompt1 = "What would you like to do?";
            Console.SetCursorPosition((Console.WindowWidth - prompt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt1);
            string prompt2 = "(Shop/Checkout)";
            Console.SetCursorPosition((Console.WindowWidth - prompt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt2);
            string response = Console.ReadLine();
            // DECIDES WHAT TO DO WHEN USER ANSWERS
            if (response == "Shop" || response == "shop")
            {
                Console.WriteLine("You chose Shop!");
                Thread.Sleep(1000);
                ShoppingMainPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else if (response == "Checkout" || response == "checkout")
            {
                Console.WriteLine("You chose Checkout!");
                Thread.Sleep(1000);
                CheckoutArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                CartArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
        }

        // MAIN PAGE FOR THE SHOPPING AREA
        public static void ShoppingMainPage(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            string shopIntro1 = "Please make a selection to browse!";
            Console.SetCursorPosition((Console.WindowWidth - shopIntro1.Length) / 2, Console.CursorTop);
            Console.WriteLine(shopIntro1);
            Console.WriteLine();
            string shopIntro2 = "(Bread/Pastries/Back)";
            Console.SetCursorPosition((Console.WindowWidth - shopIntro2.Length) / 2, Console.CursorTop);
            Console.WriteLine(shopIntro2);
            Console.WriteLine();
            var shopResponse = Console.ReadLine();
            if (shopResponse == "Bread" || shopResponse == "bread")
            {
                BreadArea(pastryInventory, pastryCart, breadInventory, breadCart);

            }
            else if (shopResponse == "Pastries" || shopResponse == "pastries")
            {
                PastryArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else if (shopResponse == "Back" || shopResponse == "back")
            {
                LandingPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                ShoppingMainPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
        }

        // AREA TO BROWSE AND ADD BREADS TO USER LIST
        public static void BreadArea(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {
            string breadIntro1 = "Here is a list of our bread items:";
            Console.SetCursorPosition((Console.WindowWidth - breadIntro1.Length) / 2, Console.CursorTop);
            Console.WriteLine(breadIntro1);
            Console.WriteLine();
            string breadSaleAnnouncement = "***BREAD IS CURRENTLY BOGO!!***";
            Console.SetCursorPosition((Console.WindowWidth - breadSaleAnnouncement.Length) / 2, Console.CursorTop);
            Console.WriteLine(breadSaleAnnouncement);
            Console.WriteLine();
            foreach (Bread item in breadInventory)
            {
                Thread.Sleep(500);
                Console.WriteLine("----------------------");
                Console.WriteLine(item.breadName);
                Console.WriteLine("$" + item.breadPrice);
                Console.WriteLine(item.breadCalories + " Calories");
            }
            string breadPrompt1 = "Would you like to add any items to your cart?";
            Console.SetCursorPosition((Console.WindowWidth - breadPrompt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(breadPrompt1);
            string breadPrompt2 = "(Yes/No)";
            Console.SetCursorPosition((Console.WindowWidth - breadPrompt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(breadPrompt2);
            Console.WriteLine();
            var breadPromptResponse = Console.ReadLine();
            if (breadPromptResponse == "Yes" || breadPromptResponse == "yes")
            {
                for (int i = 0; i < breadInventory.Count; i++)
                {
                    Console.WriteLine(" " + (i + 1) + "-" + breadInventory[i].breadName);
                }
                string breadSelectorPrompt = "First, select which item you'd like to add (with corrosponding number)";
                Console.SetCursorPosition((Console.WindowWidth - breadSelectorPrompt.Length) / 2, Console.CursorTop);
                Console.WriteLine(breadSelectorPrompt);
                int userBreadSelection = int.Parse(Console.ReadLine());
                string breadAddAmount = "How many of these items would you like to add? (Enter a whole number))";
                Console.SetCursorPosition((Console.WindowWidth - breadAddAmount.Length) / 2, Console.CursorTop);
                Console.WriteLine(breadAddAmount);
                int userSelectionAddAmount = int.Parse(Console.ReadLine());
                for (int i = 0; i < userSelectionAddAmount; i++)
                {
                    breadCart.Add(breadInventory[userBreadSelection - 1]);
                }
                Console.WriteLine("You've added " + userSelectionAddAmount + " " + breadInventory[userBreadSelection - 1].breadName + " to your cart!");

            }
            else if (breadPromptResponse == "No" || breadPromptResponse == "no")
            {
                BreadArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                BreadArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            ShoppingMainPage(pastryInventory, pastryCart, breadInventory, breadCart);
        }

        // AREA TO BROWSE AND ADD PASTRIES TO USER LIST
        public static void PastryArea(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {
            string pastryIntro1 = "Here is a list of our pastry items:";
            Console.SetCursorPosition((Console.WindowWidth - pastryIntro1.Length) / 2, Console.CursorTop);
            Console.WriteLine(pastryIntro1);
            Console.WriteLine();
            string pastrySaleAnnouncement = "***PASTRIES ARE BUY 2 GET 1 FREE!!!***";
            Console.SetCursorPosition((Console.WindowWidth - pastrySaleAnnouncement.Length) / 2, Console.CursorTop);
            Console.WriteLine(pastrySaleAnnouncement);
            Console.WriteLine();
            foreach (Pastry item in pastryInventory)
            {
                Thread.Sleep(500);
                Console.WriteLine("----------------------");
                Console.WriteLine(item.pastryName);
                Console.WriteLine("$" + item.pastryPrice);
                Console.WriteLine(item.pastryCalories + " Calories");
            }
            string pastryPrompt1 = "Would you like to add any items to your cart?";
            Console.SetCursorPosition((Console.WindowWidth - pastryPrompt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(pastryPrompt1);
            string pastryPrompt2 = "(Yes/No)";
            Console.SetCursorPosition((Console.WindowWidth - pastryPrompt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(pastryPrompt2);
            Console.WriteLine();
            var pastryPromptResponse = Console.ReadLine();
            if (pastryPromptResponse == "Yes" || pastryPromptResponse == "yes")
            {
                for (int i = 0; i < pastryInventory.Count; i++)
                {
                    Console.WriteLine(" " + (i + 1) + "-" + pastryInventory[i].pastryName);
                }
                string pastrySelectorPrompt = "First, select which item you'd like to add (with corrosponding number)";
                Console.SetCursorPosition((Console.WindowWidth - pastrySelectorPrompt.Length) / 2, Console.CursorTop);
                Console.WriteLine(pastrySelectorPrompt);
                int userPastrySelection = int.Parse(Console.ReadLine());
                string pastryAddAmount = "How many of these items would you like to add? (Enter a whole number))";
                Console.SetCursorPosition((Console.WindowWidth - pastryAddAmount.Length) / 2, Console.CursorTop);
                Console.WriteLine(pastryAddAmount);
                int userSelectionAddAmount = int.Parse(Console.ReadLine());
                for (int i = 0; i < userSelectionAddAmount; i++)
                {
                    pastryCart.Add(pastryInventory[userPastrySelection - 1]);

                }
                Console.WriteLine("You've added " + userSelectionAddAmount + " " + pastryInventory[userPastrySelection - 1].pastryName + " to your cart!");

            }
            else if (pastryPromptResponse == "No" || pastryPromptResponse == "no")
            {
                PastryArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                PastryArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            ShoppingMainPage(pastryInventory, pastryCart, breadInventory, breadCart);
        }

        // MAIN AREA FOR CHECKOUT
        public static void CheckoutArea(List<Pastry> pastryInventory, List<Pastry> pastryCart, List<Bread> breadInventory, List<Bread> breadCart)
        {
            int pastryCount = pastryCart.Count;
            int breadCount = breadCart.Count;

            Console.WriteLine("You currently have " + pastryCount + " pastries and " + breadCount + " loaves of bread in your cart.");
            Console.WriteLine("Your current total is: $" + (Pastry.totalPastryPrice(pastryCount) + Bread.totalBreadPrice(breadCount)) + " --- Discounts Applied");

            string prompt1 = "What would you like to do?";
            Console.SetCursorPosition((Console.WindowWidth - prompt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt1);
            string prompt2 = "(Purchase/Back)";
            Console.SetCursorPosition((Console.WindowWidth - prompt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(prompt2);
            string response = Console.ReadLine();
            // DECIDES WHAT TO DO WHEN USER ANSWERS
            if (response == "Purchase" || response == "purchase")
            {
                Console.WriteLine("Your total today is $" + (Pastry.totalPastryPrice(pastryCount) + Bread.totalBreadPrice(breadCount)) + " --- Discounts Applied");
                Thread.Sleep(1000);
                Console.WriteLine("Thanks for shopping at Pierre's Today!");
            }
            else if (response == "Back" || response == "back")
            {
                Console.WriteLine("Taking you back!");
                Thread.Sleep(1000);
                LandingPage(pastryInventory, pastryCart, breadInventory, breadCart);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string errorCode = "You entered an incorrect command. Check your spelling!";
                Console.SetCursorPosition((Console.WindowWidth - errorCode.Length) / 2, Console.CursorTop);
                Console.WriteLine(errorCode);
                Thread.Sleep(2000);
                CheckoutArea(pastryInventory, pastryCart, breadInventory, breadCart);
            }
        }
    }
}