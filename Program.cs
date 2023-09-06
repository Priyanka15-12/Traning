namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter the value of n: ");
         int.TryParse (args[0], out int n);
         if (Armstrong (n) != -1)
            Console.WriteLine ($"The {n}th armstrong number is {Armstrong (n)}");
         else Console.WriteLine ("Out of range. Enter n value from 1 to 25.");
      }

      static int Armstrong (int n) {
         int count = 0;
         for (int num = 1; ; num++) {
            int sum = 0;
            int length = num.ToString ().Length;
            while (num > 0) {
               sum += ((int)Math.Pow (num % 10, length));
               num /= 10;
            }
            if (num == sum) count++;
            if (count == n)
               if (count <= 25) return sum;
               else break;
         }
         return -1;
      }
   }
}