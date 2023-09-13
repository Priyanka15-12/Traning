using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         string[] abecedarianArr = { "glory", "floor", "ant", "victory", "aegilops", "access" };
         for (int index = 0; index < abecedarianArr.Length; index++) {
            string word = abecedarianArr[index];
            if (isAbecedarian (word))
               Console.WriteLine ($"Abecedarian word :{word}");
            if (word.Length > maxLength) {
               maxLength = word.Length;
               maxIndex = index;
            }
         }
         if (maxIndex != -1)
            Console.WriteLine ($"\"{abecedarianArr[maxIndex]}\" is the longest abecedarian word of given array.");
         else Console.WriteLine ("No abecedarian word here.");
      }
      static bool isAbecedarian (string word) {
         for (int i = 1; i < word.Length; i++)
            if (word[i] < word[i - 1])
               return false;
         return true;
      }
      static int maxLength = 0;
      static int maxIndex = -1;
   }
}