// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// The input.txt contains the results of several games. Each game records 3 sets of play;
// each separated by a semicolon.Find out the sum of all the game IDs that would be possible
// if the bag contained only 12 red cubes, 13 green cubes, and 14 blue cubes. 
// --------------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      #region Methods -----------------------------------------------
      static void Main (string[] args) {
         string[] read = File.ReadAllLines ("C:\\etc\\input.txt");
         Console.WriteLine ("Sum of all the possible game IDs: " + Games (read));
      }
      /// <summary>Add up the possible game IDs</summary>
      /// <param name="str">Games</param>
      /// <returns>Sum of all possible games</returns>
      static int Games (string[] str) {
         int sum = 0;
         for (int k = 0; k < str.Length; k++) {
            string[] games = str[k].Replace (',', ' ').Split (';');
            if (isValidGame (games)) sum += k + 1;
         }
         return sum;
      }

      /// <summary>Check if games is possible or not</summary>
      /// <param name="games">Games</param>
      /// <returns>True, if game is possible, else false</returns>
      static bool isValidGame (string[] games) {
         for (int j = 0; j < games.Length; j++) {
            string[] parts = games[j].Split (' ');
            for (int i = 0; i < parts.Length; i++) {
               if (parts[i] == "blue" && int.Parse (parts[i - 1]) > 14) return false;
               else if (parts[i] == "red" && int.Parse (parts[i - 1]) > 12) return false;
               else if (parts[i] == "green" && int.Parse (parts[i - 1]) > 13) return false;
            }
         }
         return true;
      }
      #endregion
   }
}