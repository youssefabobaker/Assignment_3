using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1)
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = new int[2,2] { {3, 5}, {1, 4} };
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion

            #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code"
            //PrintBookTitle("Clean Code");
            #endregion

            #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine($"pages afterward: {pages}"); //Total pages after bonus = 400, bacause the method called by pass by value so the main value doesnot change
            #endregion

            #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect tosee, and why? 
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"price[0] afterward: {prices[0]}"); // Total price after discount = 20.5, because the method called by pass by value but the parameters are reference type so the main value changes
            #endregion

            #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine($"pages afterward: {pages}"); // Total pages after bonus = 450, because the method called by pass by reference so the main value changes
            #endregion

            #region Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine($"length afterward: {prices.Length}");
            #endregion

            #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it and print the price if found
            //double price;
            //bool found;
            //found = TryGetPrice("Clean Code", out price);
            //if (found) Console.WriteLine($"Price: {price}");
            //else Console.WriteLine("not found");
            #endregion

            #region Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code", 400);
            #endregion

            #region Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title. 
            //PrintBookInfo(pages: 400, title: "Clean Code");
            #endregion

            #region Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles. 
            //PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");
            #endregion

        }

        //public static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        //public static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book Title: {title}");
        //}

        //public static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        //public static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5.0;
        //}

        //public static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}

        //public static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}

        //public static bool TryGetPrice(string title, out double price)
        //{
        //    if ( title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    else
        //    {
        //        price = 0.0;
        //        return false;
        //    }
        //}

        //public static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"title: {title}, Pages: {pages}");
        //}

        //public static void PrintAllTitles(params string[] titles)
        //{
        //    foreach (string title in titles)
        //    {
        //        Console.WriteLine(title);
        //    }
        //}
    }
}
