// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// VOTING CONTEST
// Given a string S to a method, with each character in it representing a vote for a contestant, return the winner with the most votes.
// If 2 or more contestants have the same number of votes, the contestant who got the first vote among them is declared a winner. 
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Voting Contest</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>This method shows winner of contestants with votes</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Enter a string: ");
         string contestants = Console.ReadLine ().ToUpper () ?? "";
         Console.WriteLine (contestants.Length == 0 ? "Enter a valid string." : $"{VotingContest (contestants)}");
      }

      /// <summary>Determine the winner by which contestant has more votes</summary>
      /// <param name="contestants">string</param>
      /// <returns>It returns winner as char and voting as int data type</returns>
      static (char, int) VotingContest (string contestants) {
         List<(int Score, char Candidate)> voteCount = new ();
         foreach (char c in contestants) {
            if (char.IsLetter (c)) {
               int count = contestants.Count (f => f == c);
               voteCount.Add ((count, c));
            }
         }
         return (voteCount.MaxBy (x => x.Score).Candidate, voteCount.MaxBy (x => x.Score).Score);
      }
      #endregion
   }
   #endregion
}