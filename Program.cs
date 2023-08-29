namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number for a= ");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number for b= ");
         int b = int.Parse (Console.ReadLine ());
         swap (a, b);
         Console.Write($"After swapping,\na = {b}\nb = {a}");
      }
      static void swap (int x, int y) {
         (x, y) = (y, x);
      }
   }
}