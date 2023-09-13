using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter decimal number: ");
         decimal.TryParse (Console.ReadLine (), out decimal dec);
         Console.Write ($"Integral Part: {(dec < 0 ? "-" : "")}");
         Array.ForEach (GetIntArrForIntegral ((int)dec), i => Console.Write ($"{i} "));
         Console.Write ("\nFractional Part: ");
         Fraction (dec);
      }
      static void Fraction (decimal d) {
         decimal frac = (d - (int)d);
         if (Math.Abs (frac) > 0) {
            string fracStr = frac.ToString ().Substring (2);
            Array.ForEach (fracStr.ToCharArray (), i => Console.Write ($"{i} "));
         } else Console.WriteLine (0);
      }
      static int[] GetIntArrForIntegral (int n) {
         n = Math.Abs (n);
         int[] wholeArr = new int[n.ToString ().Length];
         for (int i = n.ToString ().Length - 1; i >= 0; i--) {
            wholeArr[i] = n % 10;
            n /= 10;
         }
         return wholeArr;
      }
   }
}