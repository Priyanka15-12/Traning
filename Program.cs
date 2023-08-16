namespace Training {
   internal class Program {
      static void Main (string[] args) {
         //Multiplication upto n
         Console.Write ("Enter num: ");
         int n = int.Parse (Console.ReadLine ());
         int i = 0;
         while (n > i) {
            i++;
            int b = 3 * i;
            Console.WriteLine ($"3 * {i,2} = {b}");
         }
      }
   }
}