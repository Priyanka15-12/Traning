// --------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// SPELLING BEE
// char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' }
// Your program should find all valid Spelling Bee words form the given dictionary:
// Each word is at least 4 letters long
// Each word uses only the 7 seed letters
// Each word MUST use the first letter (in this case, Y)
// Any letter can be used more than once
// The score is then computed like this:
// 4 letter words score 1 point
// Longer words score as many points as there are letters
// Any word that uses all 7 seed letters (called pangrams) gets an additional 7 bonus points
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Spelling Bee</summary>
   internal class Program {
      #region Method ---------------------------------------------
      /// <summary>This method shows all valid Spelling Bee words with points</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         string[] words = File.ReadAllLines ("Resource\\words .txt");
         char[] letters = { 'U', 'X', 'L', 'T', 'A', 'E', 'N' };
         List<(int, string, bool)> wordsList = new ();
         foreach (string word in words) {
            if (word.Length >= 4 && word.Contains (letters[0]) && word.All (letters.Contains)) {
               int marks = (word.Length == 4 ? 1 : (IsPangram (letters, word) ? word.Length + 7 : word.Length));
               wordsList.Add ((marks, word, IsPangram (letters, word)));
            }
         }
         if (wordsList.Count == 0) throw new Exception ("Empty list");
         var descendingOrderedList = wordsList.OrderByDescending (x => x.Item1).ToList ();
         for (int i = 0; i < descendingOrderedList.Count; i++) {
            if (descendingOrderedList[i].Item3) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ($"{descendingOrderedList[i].Item1,3}. {descendingOrderedList[i].Item2}");
               Console.ResetColor ();
            } else
               Console.WriteLine ($"{descendingOrderedList[i].Item1,3}. {descendingOrderedList[i].Item2}");
         }
         Console.WriteLine ("----");
         Console.WriteLine ($"{descendingOrderedList.Sum (point => point.Item1)} total");
      }

      /// <summary>Checks if word is pangram or not</summary>
      /// <param name="letters"></param>
      /// <param name="word"></param>
      /// <returns>It returns true if word is pangram</returns>
      static bool IsPangram (char[] letters, string word) => letters.All (word.Contains);
      #endregion
   }
   #endregion
}