namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number to find digit root: ");
         int.TryParse (Console.ReadLine (), out int n);
         if (n >= 0) {
            while (n > 9) {
               int add = 0;
               while (n > 0) {
                  add += n % 10;
                  n /= 10;
               }
               n = add;
            }
            Console.WriteLine ($"The digit root of given number is {n}");
         } else Console.WriteLine ("Enter a positive number.");
      }
   }
}