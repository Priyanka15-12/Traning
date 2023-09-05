namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a positive number: ");
         if (int.TryParse (Console.ReadLine (), out int n))
            Console.Write ($"Factorial of {n} is {Factorial (n)}.");
         else Console.WriteLine ("Invalid character. Enter a positive integer.");
      }
      static long Factorial (int n) {
         //works upto 20
         long fact = 1;
         for (int i = 1; i <= n; i++)
            fact *= i;
         return fact;
      }
   }
}