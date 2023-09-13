namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a positive number: ");
         if (int.TryParse (Console.ReadLine (), out int n) && n >= 0)
            Console.WriteLine ($"Factorial of {n} is {Factorial (n)}.");
         else Console.WriteLine ("Invalid character. Enter a positive integer.");
      }
      static int Factorial (int n) {
         //works upto 12!
         int fact = 1;
         if (n == 0) return 1;
         else if (n <= 2) return n;
         for (int i = 2; i <= n; i++)
            fact *= i;
         return fact;
      }
      /*static long Factorial (int n) {
      works upto 20!
         long fact = 1;
         for (int i = 2; i <= n; i++)
            fact *= i;
         return fact;
      }
      */
   }
}
