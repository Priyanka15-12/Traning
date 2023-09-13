namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number for a = ");
         int.TryParse (Console.ReadLine (), out int a);
         Console.Write ("Enter a number for b = ");
         int.TryParse (Console.ReadLine (), out int b);
         Swap (ref a, ref b);
         Console.Write ($"After swapping,\na = {a}\nb = {b}");
      }
      static void Swap (ref int x, ref int y) => (x, y) = (y, x);
   }
}