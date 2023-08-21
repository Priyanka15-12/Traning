using System;
internal class Program {
   private static void Main (string[] args) {
      int a = 1, z = 100, attempt = 1, guess;
      Console.Write ($"Guess random number from {a} to {z+1} and press enter key.");
      Console.ReadKey ();
      while (true) {
         guess = (a + z) / 2;
         char key;
         Console.Write ($"\nIs {guess} your answer?(Y/N): ");
         key = Console.ReadKey ().KeyChar;
         if (key == 'Y' || key == 'y') {
            Console.Write ($"\n{guess} is your guessed random number and I found it in {attempt} {(attempt > 1 ? "attempts" : "attempt")}.");
            break;
         } else if (key == 'N' || key == 'n') {
            attempt++;
            Console.Write ($"\nIs that lesser than {guess}? Y/N: ");
            key = Console.ReadKey ().KeyChar;
            if (key == 'Y' || key == 'y')
               z = guess - 1;
            else if (key == 'N' || key == 'n')
               a = guess + 1;
            else
               Console.Write ("\nInvalid info. Enter 'y' or 'n'.");
         } else
            Console.WriteLine ("\nInvalid character. Press 'Y' or 'N'.");
      }
   }
}