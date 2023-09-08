namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter number: ");
         int.TryParse (Console.ReadLine (), out int a);
         int num = a, reversedNum = 0;
         while (a > 0) {
            reversedNum = reversedNum * 10 + a % 10;
            a /= 10;
         }
         string res = (num == reversedNum ? $"{num} is a palindrome number." : $"{num} is not a palindrome number.");
         Console.WriteLine ($"Reversed number: {reversedNum}.\n{res}");
      }
   }
}