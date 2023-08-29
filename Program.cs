namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         int n = int.Parse (Console.ReadLine ());
         Console.Write ($"Factorial of {n} is {factorial (n)}.");
      }
      static int factorial (int n) {
         int fact = 1;
         for (int i = 1; i < n; i++) {
            fact *= i;
         }
         return fact;
      }
   }
}