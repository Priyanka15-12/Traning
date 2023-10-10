// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// REVERSE GUESSING GAME FROM LSB TO MSB
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Reverse guessing game from LSB to MSB</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Displays the number which user guessed</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         int divisor = 2;
         double remainder = 0;
         Console.Write ("Guess a number between 1 and 100.");// works upto 127
         for (double i = 0; i < 7;) {
            Console.Write ($"\nWhen number is divided by {divisor}, is the remainder {remainder} or not? (Y)es or (N)o: ");
            char key = char.ToLower (Console.ReadKey ().KeyChar);
            if (key == 'n' || key == 'y') {
               divisor *= 2;
               if (key == 'n') remainder += (Math.Pow (2, i)); i++;
            } else Console.Write ("\nEnter a valid key (y or n).");
         }
         Console.WriteLine ($"\nYour answer is {remainder}");
      }
      #endregion
   }
   #endregion
}