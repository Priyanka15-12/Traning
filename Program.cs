// --------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// An abecedarian word is a word where all its letters are arranged in alphabetical order.
// Given an array of words, create a function which returns the longest abecedarian word.
// If no word in an array matches the criteria, return an empty string. 
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program---------------------------------------------------------
   /// <summary>Abecedarian word</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Displays the longest abecedarian word from given array and
      /// shows no abecedarian word here, if doesn't matches the  criteria </summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         string[] wordArr = { "glory", "floor", "ant", "victory", "aegilops", "access" };
         int maxLength = 0, maxIndex = -1;
         for (int index = 0; index < wordArr.Length; index++) {
            string word = wordArr[index];
            if (IsAbecedarian (word)) {
               Console.WriteLine ($"Abecedarian word :{word}");
               if (word.Length > maxLength) (maxLength, maxIndex) = (word.Length, index);
            }
         }
         Console.WriteLine (maxIndex != -1 ? $"\"{wordArr[maxIndex]}\" is the longest abecedarian word of given array." : "No abecedarian word here.");
      }

      /// <summary>Checks, if word is abecedarian or not</summary>
      /// <param name="word">words of array</param>
      /// <returns>It returns bool value true for abecedarian word</returns>
      static bool IsAbecedarian (string word) {
         bool isAbecedarian = true;
         for (int i = 1; i < word.Length; i++)
            if (word[i] < word[i - 1]) isAbecedarian = false;
         return isAbecedarian;
      }
      #endregion
   }
   #endregion
}
