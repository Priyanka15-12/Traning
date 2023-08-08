using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Input: ");
         int dec = int.Parse (Console.ReadLine ());
         String hexa = dec.ToString ("X");
         Console.WriteLine ($"HEX: {hexa}");
         string bin = "";
         while (dec > 0) {
            int rem = dec % 2;
            bin = rem + bin;
            dec = dec / 2;
         }Console.WriteLine ($"Binary: {bin}");
      }
   }
}