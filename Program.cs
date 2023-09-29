// --------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// STRING PERMUTATIONS
// Generate all string character permutations. 
// For example, Input: "NOT", Output: "NOT NTO ONT OTN TNO TON"
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>String permutation</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Displays all string string permutation</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         string word = "NOT";
         Permute (word.ToCharArray (), 0);
      }

      /// <summary>Permutate the given word and print all string permutation</summary>
      /// <param name="wordArr">Char array</param>
      /// <param name="fixedChar">index of char</param>
      static void Permute (char[] wordArr, int fixedChar) {
         if (fixedChar == wordArr.Length - 1)
            Console.WriteLine (wordArr);
         else {
            for (int i = fixedChar; i < wordArr.Length; i++) {
               Swap (wordArr, fixedChar, i);
               Permute (wordArr, fixedChar + 1);
               Swap (wordArr, fixedChar, i);
            }
         }
      }

      /// <summary>Swap char of the word with indices</summary>
      /// <param name="wordArr">string word</param>
      /// <param name="i">index of char</param>
      /// <param name="j">index of char</param>
      static void Swap (char[] wordArr, int i, int j) {
         (wordArr[i], wordArr[j]) = (wordArr[j], wordArr[i]);
      }
      #endregion
   }
   #endregion
}