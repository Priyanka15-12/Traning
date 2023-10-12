namespace Training {
   internal class Program {
      static void Main (string[] args) {
         if (int.TryParse (args[0], out int n) && n > 0 && n <= 25)
            Console.WriteLine ($"The {n}th armstrong number is {NthArmstrong (n)}");
         else Console.WriteLine ("Out of range. Enter n value from 1 to 25.");
      }

      static int NthArmstrong (int n) {
         int count = 0;
         for (int i = 1; ; i++) {
            int sum = 0, num = i;
            int length = num.ToString ().Length;
            while (num > 0) {
               sum += (int)Math.Pow (num % 10, length);
               num /= 10;
            }
            if (i == sum) count++;
            if (count == n) return sum;
         }
      }
   }
}