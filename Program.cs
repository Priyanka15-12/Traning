namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the value of n: ");
         int n = int.Parse (Console.ReadLine ());
         Console.WriteLine ($"The {n}th armstrong number is {armstrong (n)}");
      }
      static int armstrong (int n) {
         int count = 0;
         for (int i = 1; i > 0; i++) {
            int sum = 0, num = i;
            int length = num.ToString ().Length;
            while (num > 0) {
               sum += ((int)Math.Pow (num % 10, length));
               num /= 10;
            }
            if (i == sum) count++;
            if (count == n) 
               return sum;
         }
         return 0;
      }
   }
}