// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// CHOCOLATE WRAPPERS 
// Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange,
// return the maximum number of chocolates C you can get along with any unused money X and wrappers W. 
// Example, Input: (X = 15, P = 4, W = 3) ; Output: (C = 4, X = 3, W = 1) 
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Chocolate wrappers</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>It determines number of chocolate, unused money and number of unused wrappers</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Enter the amount: ");
         int.TryParse (Console.ReadLine (), out int x);
         Console.Write ("Enter the price of chocolate: ");
         int.TryParse (Console.ReadLine (), out int p);
         Console.Write ("Enter number of wrappers to exchange chocolate which should greater than one: ");
         int.TryParse (Console.ReadLine (), out int w);
         if (x > 0 && p > 0 && w > 1) ChocolateWrappers (x, p, w);
         else Console.WriteLine ("Provide natural numbers");
      }

      /// <summary>It shows number of chocolate, unused money and number of unused wrappers</summary>
      /// <param name="amount">int - amount of chocolate</param>
      /// <param name="chocoPrice">int - chocolate price</param>
      /// <param name="wrapper">int - wrapper to exchange</param>
      static void ChocolateWrappers (int amount, int chocoPrice, int wrapper) {
         int totalChoco, unusedWrapper, exchange;
         int chocolate = amount / chocoPrice;
         int balance = amount % chocoPrice;
         unusedWrapper = chocolate;
         while (unusedWrapper >= wrapper) {
            exchange = unusedWrapper / wrapper;
            chocolate += exchange;
            unusedWrapper = unusedWrapper % wrapper + exchange;
         }
         totalChoco = chocolate;
         Console.WriteLine ($"Chocolate = {totalChoco}, Unused money = {balance}, Wrappers = {unusedWrapper}");
      }
      #endregion
   }
   #endregion
}