using System;
using System.Diagnostics;

internal class Program {
   private static void Main (string[] args) {
      int a = 1, z = 100, attempt = 1, guess;
      Console.Write ($"Guess random number from {a} to {z} and press enter key.");
      while (attempt <= 7) {                  //find the number within 7 attempts.
         guess = (a + z) / 2;
         Console.Write ($"\nIs {guess} your answer?(Y/N): ");
         char key = Console.ReadKey ().KeyChar;
         if (key == 'Y' || key == 'y') {
            Console.Write ($"\n{guess} is your guessed number and I found it in {attempt} attempt{(attempt > 1 ? "s" : "")}.");
            break;
         } else if (key == 'N' || key == 'n') {
            attempt++;
            if (attempt <= 7) {
               Console.Write ($"\nIs that lesser than {guess}? Y/N: ");
               key = Console.ReadKey ().KeyChar;
               if (key == 'Y' || key == 'y') z = guess;
               else if (key == 'N' || key == 'n') a = guess + 1;
               else Console.Write ("\nInvalid key. Enter 'Y' or 'N'.");
            } else Console.Write ("\nI apologize for not successfully making your out-of-the-box guess!");
         } else Console.Write ("\nInvalid key. Press 'Y' or 'N'.");
      }
   }
}