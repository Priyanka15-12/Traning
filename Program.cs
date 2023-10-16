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
      /// <summary>Display the 7 seed letters for the Spelling Bee.</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Dictionary<char, int> charAndCount = new ();
         string wordFile = File.ReadAllText ("D:/Work/words.txt");
         char[] letters = Enumerable.Range ('A', 26).Select (x => (char)x).ToArray ();
         for (int ch = 0; ch < letters.Length; ch++) {
            int count = wordFile.Count (x => x == letters[ch]);
            if (count > 0) charAndCount.Add (letters[ch], count);
         }
         var orderedCount = charAndCount.OrderByDescending (x => x.Value).Take (7);
         Console.Write ("Seed letters and their count for Spelling Bee:\n");
         foreach (var element in orderedCount) Console.WriteLine ($"{element.Key} - {element.Value}");

      }
      #endregion
   }
   #endregion
}