// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// EXTENSION OF SPELLING BEE ASSIGNMENT
// Use the same word list given in the Spelling Bee assignment and build a frequency table with occurrence of all the letters.
// The output should be a list of a letters with its occurrence count in descending order.
// Display the first 7 letters to be used as the seed for the Spelling Bee program.
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Extension of Spelling Bee</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Display the 7 seed letters of the Spelling Bee.</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Dictionary<char, int> charAndCount = new ();
         foreach (char ch in File.ReadAllText ("D:/Work/words.txt"))
            if (ch is >= 'A' and <= 'Z')
               charAndCount[ch] = charAndCount.ContainsKey (ch) ? charAndCount[ch] + 1 : 1;
         var orderedCount = charAndCount.OrderByDescending (x => x.Value).Take (7);
         Console.Write ("Seed letters and their count of Spelling Bee:\n");
         foreach (var element in orderedCount) Console.WriteLine ($"{element.Key} - {element.Value}");
      }
      #endregion
   }
   #endregion
}