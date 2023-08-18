namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter number: ");
         int a = int.Parse (Console.ReadLine ());
         int num = a;
         int reversed_num = 0;
         while (a > 0) {
            int rem = a % 10;
            reversed_num = reversed_num * 10 + rem;
            a = a / 10;
         }
         Console.WriteLine ($"Reversed number {reversed_num}.");
         if (num == reversed_num) {
            Console.WriteLine ($"{num} is palindrome number.");
         } else
            Console.WriteLine ($"{num} is not a palindrome number.");
      }
   }
}