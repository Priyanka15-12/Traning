namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Random randomNum = new ();
         int[] numArr = new int[6];
         for (int i = 0; i < 6; ++i)
            numArr[i] = randomNum.Next (1, 10);
         Array.ForEach (numArr, i => Console.Write ($"{i} "));
         Console.Write ("\nEnter index a: ");
         int.TryParse (Console.ReadLine (), out int a);
         Console.Write ("Enter index b: ");
         int.TryParse (Console.ReadLine (), out int b);
         void indexSwap (int[] arr, int a, int b) => (arr[a], arr[b]) = (arr[b], arr[a]);
         if (a >= 0 && a <= 5 && b >= 0 && b <= 5) {
            indexSwap (numArr, a, b);
            Console.WriteLine ("Swapped series of numbers");
            Array.ForEach (numArr, i => Console.Write ($"{i} "));
         } else Console.Write ($"Provide indices whithin the range. From 0 to 5.");
      }
   }
}