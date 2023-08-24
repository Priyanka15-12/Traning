namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         if (int.TryParse (Console.ReadLine (), out int n)) {
            int count = 0;
            if (n <= 1) Console.WriteLine ($"{n} is neither composite nor prime number.");
            else if (n == 2) Console.WriteLine ($"The given number {n} is a prime number.");
            else if (n % 2 == 0) Console.WriteLine ($"The given number {n} is not a prime number.");
            else if (n % 2 != 0 && n > 2) {
               for (int i = 3; n >= i; i += 2)
                  if (n % i == 0) count++;
               Console.WriteLine ($"The given number {n} is{(count == 1 ? "" : " not")} a prime number");
            }
         } else Console.WriteLine ("Invalid input. Please provide a positive integer.");
      }
   }
}
