internal class Program {
   private static void Main (string[] args) {
      int a = 1;
      int z = 101;
      Random r = new ();
      int n = r.Next (a, z);

      Console.WriteLine ($"GUESS RANDOM NUMBER FROM {a} TO {z}:");
      //Console.WriteLine (n);
      int attempt = 0;
      int p = 0;
      while (p != n) {
         // get user input as string
         Console.Write ("Guess number: ");    
         // Type cast - convert string to int
         if (int.TryParse (Console.ReadLine (), out p)) {
            // check if non-positive and print msg
            if (p < a || p > z)
               Console.WriteLine ("Enter the number within the range.");
            // check lesser than 
            if (n > p)
               Console.WriteLine ($"Your guess is too low. Enter a number greater than {p}");
            // check greater than 
            else if (n < p)
               Console.WriteLine ($"Your guess is too high. Enter a number smaller than {p}");
            // increment attempt count 
            attempt++;                                                                                                          
         }
      }
      Console.WriteLine ($"You got the answer at attempt {attempt}!");

   }
}
