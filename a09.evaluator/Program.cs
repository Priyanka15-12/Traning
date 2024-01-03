// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ---------------------------------------------------------------------------------------
// Program.cs
// Implement the ParseDouble function. Here’s an example function that does the simpler
// job of parsing an integer from forms like 12, -123, +1234. Use this as a way of getting started.
// This assignment is very important, please do try to create a solution.
// ---------------------------------------------------------------------------------------
using static System.Console;
namespace Eval {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Expression Evaluator</summary>
   class Program {
      #region Method ------------------------------------------------
      /// <summary>Evaluate the expressions</summary>
      static void Main () {
         var eval = new Evaluator ();
         for (; ; ) {
            Write ("> ");
            string input = (ReadLine () ?? "").Trim ().ToLower ();
            if (input == "exit") break; // Exits from the evaluator
            try {
               var result = eval.Evaluate (input);
               ForegroundColor = ConsoleColor.Green;
               WriteLine (Math.Round (result, 10));
            } catch (Exception e) {
               ForegroundColor = ConsoleColor.Red;
               WriteLine (e.Message);
            }
            ResetColor ();
         }
      }
      #endregion
   }
   #endregion
}