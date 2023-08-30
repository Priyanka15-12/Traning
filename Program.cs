namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a positive number: ");
         int n = int.Parse (Console.ReadLine ());
         int temp = n;
         Console.Write ($"{n} is a {(armstrong (n) == temp ? "" : "in")}valid armstrong number.");
      }
      static int armstrong (int n) {
         int sum = 0, intlen = n.ToString ().Length;
         while (n > 0) {
            sum += (int)Math.Pow (n % 10, intlen);
            n /= 10;
         }
         return sum;
      }
   }
}