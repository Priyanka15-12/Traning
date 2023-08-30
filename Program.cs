namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int[] num = { 2, 4, 3, 5, 7, 10, 15 };
         Array.ForEach (num, i => Console.Write ($"{i} "));
         Console.Write ("\nEnter index a: ");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter index b: ");
         int b = int.Parse (Console.ReadLine ());
         if (a >= 0 && a <= num.Length && b >= 0 && b <= num.Length) {
            indexswap (num, a, b);
            Console.WriteLine ("Swapped series of numbers");
            Array.ForEach (num, i => Console.Write ($"{i} "));
         } else Console.Write ("Provide indices within range.");
      }
      static void indexswap (int[] arr, int x, int y) {
         (arr[x], arr[y]) = (arr[y], arr[x]);
      }
   }
}