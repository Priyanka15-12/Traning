using System.Runtime.CompilerServices;

internal class Program {
   private static void Main (string[] args) {
      int a = 1, z = 100, guess;
      Console.Write ($"Guess random number from {a} to {z} and press enter key.");
      Console.ReadKey ();
      int attempt = 1;
      while (true) {
         guess = (a + z) / 2;
         char key;
         Console.Write ($"\nIs {guess} your answer?(Y/N): ");
         key = Console.ReadKey ().KeyChar;
         if (key == 'Y') {
            Console.Write ($"\n{guess} is your guessed random number and I found it in {attempt} attempt.");
            break;
         } 
         else if (key == 'N') {
            attempt++;  
            Console.Write ($"\nIs that lesser than {guess}? y/n: ");
            key = Console.ReadKey ().KeyChar;
            if (key == 'y')
               z = guess - 1;
            else if (key == 'n')
               a = guess + 1;
            else
               Console.WriteLine ("Invalid info. Enter 'y' or 'n'.");        
         } else
            Console.WriteLine ("\nInvalid character. Press 'Y' or 'N'.");
      }
   }
}