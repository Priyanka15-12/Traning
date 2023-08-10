namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         int n = int.Parse (Console.ReadLine ());
         int i = 1, count = 1;
         while (n >= i) {
            i++;
            if (n % i == 0) {
               count++;
            }
         }
         if (count == 2) {
            Console.WriteLine ($"The given number {n} is prime number.");
         } else Console.WriteLine ($"The given number {n} is not a prime number.");
      }
   }
}