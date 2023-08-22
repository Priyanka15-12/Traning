namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter half the number of rows: ");
         int n = int.Parse (Console.ReadLine ());
         for (int i = 0; i <= n; i++) {
            for (int j = n; j > i; j--)
               Console.Write (" ");
            for (int j = 0; j <= i; j++)
               Console.Write ("*");
            for (int j = 0; j < i; j++)
               Console.Write ("*");
            Console.WriteLine ();
         }
         for (int i = 1; i <= n; i++) {
            for (int j = 0; j < i; j++)
               Console.Write (" ");
            for (int j = n; j >= i; j--)
               Console.Write ("*");
            for (int j = n; j > i; j--)
               Console.Write ("*");
            Console.WriteLine ();
         }
      }
   }
}

