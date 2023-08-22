namespace Training {
   internal class Program {
      static void Main (string[] args) {
         //Multiplication upto n
         Console.Write ("Enter num: ");
         int i=0, n = int.Parse (Console.ReadLine ());
         while (n > i++) {
            Console.WriteLine ($"3 * {i,2} = {3*i}");
         }
      }
   }
}