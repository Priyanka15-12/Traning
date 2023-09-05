namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a positive number: ");
         if(int.TryParse (Console.ReadLine (),out int n) && n >= 0)
            Console.Write ($"{n} is a {(Armstrong (n) == n ? "" : "In")}valid armstrong number.");
         else Console.WriteLine ("Invalid input. Enter a positive number.");
      }

      static int Armstrong (int n) {
         int sum = 0, intLen = n.ToString ().Length;
         while (n > 0) {
            sum += (int)Math.Pow (n % 10, intLen);
            n /= 10;
         }
         return sum;
      }
   }
}