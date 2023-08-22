namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter number: ");
         int a = int.Parse (Console.ReadLine ());
         int num = a, reversed_num = 0;
         while (a > 0) {
            reversed_num = reversed_num * 10 + a % 10;
            a /= 10;
         }
         string res=(num == reversed_num ? $"{num} is a palindrome number." : $"{num} is not a palindrome number.");
         Console.WriteLine ($"Reversed number {reversed_num}.{res}");
      }
   }
}