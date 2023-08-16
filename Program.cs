namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter num1: ");
         int n1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter num2: ");
         int n2 = int.Parse (Console.ReadLine ());
         int a = n1, b = n2;
         while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
         }
         Console.WriteLine ($"GCD of {n1} and {n2} is {a}");
         int lcm = n1 * n2 / a;
         Console.WriteLine ($"LCM of {n1} and {n2} is {lcm}");
      }
   }
}