namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number for a= ");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number for b= ");
         int b = int.Parse (Console.ReadLine ());
         swap (ref a, ref b);
         Console.Write($"After swapping,\na = {a}\nb = {b}");
      }
      static void swap (ref int x, ref int y) {
         (x, y) = (y, x);
      }
   }
}