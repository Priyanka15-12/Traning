using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         //Convert a positive decimal number into binary and hexadecimal.
         Console.Write ("Enter a positive number: ");
         if ((int.TryParse (Console.ReadLine (), out int dec)) && dec >= 0) {
            int num = dec; string hex = "", bin = "";
            if (dec == 0) Console.WriteLine ($"Hexadecimal: 0\nBinary: 0");
            else {
               while (dec > 0) {
                  hex = ConvertHexa (dec % 16) + hex;
                  dec /= 16;
               }
               Console.WriteLine ($"Hexadecimal: {hex}");
               while (num > 0) {
                  bin = num % 2 + bin;
                  num /= 2;
               }
               Console.WriteLine ($"Binary: {bin}");
            }
         } else Console.WriteLine ("Enter a positive numerical value");
      }
      static char ConvertHexa (int remainder) {
         return remainder < 10 ? (char)('0' + remainder) : (char)('A' + remainder - 10);
      }
   }
}