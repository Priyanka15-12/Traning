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
         (char letters, int count)[] charAndCount = new (char, int)[26];
         foreach (char item in File.ReadAllText ("D:/Work/words.txt").ToUpper ())
            if (char.IsLetter (item))
               if (charAndCount.Any (x => x.letters == item))
                  charAndCount[item - 'A'].count += 1;
               else charAndCount[item - 'A'] = (item, 1);
         Console.Write ("Seed letters and their count of Spelling Bee:\n");
         var orderedCount = charAndCount.OrderByDescending (x => x.count).Take (7);
         foreach (var (letters, count) in orderedCount) Console.WriteLine ($"{letters} - {count}");
      }
      #endregion
   }
   #endregion
}