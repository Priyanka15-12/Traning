namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number to find digit root: ");
         int n = int.Parse (Console.ReadLine ()); 
         int quo, rem ;
         while (n > 9) {
            int add = 0;
            while (n > 0) {
               quo = n / 10;
               rem = n % 10;
               add += rem;
               n = quo;
            }
            n = add;
         }
         Console.WriteLine ($"The digit root of given number is {n}");
      }
   }
}