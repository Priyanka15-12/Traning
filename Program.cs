namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number for a = ");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number for b = ");
         int b = int.Parse (Console.ReadLine ());
         void Swap (int x, int y) => (a, b) = (b, a);
         Swap (a, b);
         Console.Write ($"After swapping,\na = {a}\nb = {b}");
      }
   }
}