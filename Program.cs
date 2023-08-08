using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Input: ");
         string decimal_number = Console.ReadLine ();
         if (int.TryParse (decimal_number, out int dec)) {
            string hexa = dec.ToString ("X");
            Console.WriteLine ($"HEX: {hexa}");
            string bin = "";
            while (dec > 0) {
               int rem = dec % 2;
               bin = rem + bin;
               dec/= 2;
            }
            Console.WriteLine ($"Binary: {bin}");
         } else Console.WriteLine ("Enter numerical value");
      }
   }
}