namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter rows for Pascal's triangle: ");
         int n = int.Parse (Console.ReadLine ());
         for (int i = 0; i < n; i++) {
            for (int j = n; j > i; j--) {
               Console.Write ("  ");
            }
            int a = 1;
            for (int k = 0; k <= i; k++) {
               a = (k == 0 ? 1 : a * (i - k + 1) / k);
               Console.Write ($"{a,-3} ");
            }
            Console.WriteLine ();
         }
      }
   }
}