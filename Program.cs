using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         string[] words = { "glory", "floor", "ant", "victory", "aegilops", "access" };
         wordsLength = new int[words.Length];
         int index = 0;
         foreach (string word in words) {
            if (abecedarian (word, index))
               Console.WriteLine ($"Abecedarian word :{word}");
            index++;
         }
         if (maxIndex != -1)
            Console.WriteLine ($"'{words[maxIndex]}' is the longest abecedarian word of given array.");
         else Console.WriteLine ("No abecedarian word here.");
      }
      static bool abecedarian (string word, int index) {
         for (int i = 1; i < word.Length; i++) {
            if (word[i] < word[i - 1])
               return false;
         }
         if (word.Length > maxLength) {
            maxLength = word.Length;
            maxIndex = index;
         }
         return true;
      }
      static int maxLength = 0;
      static int maxIndex = -1;
      static int[] wordsLength;
   }
}