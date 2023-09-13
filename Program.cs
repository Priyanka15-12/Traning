namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Random randomNum = new ();
         Console.Write ("Enter the length of series: ");
         if (int.TryParse (Console.ReadLine (), out int arrCapacity) && arrCapacity > 1) {
            int[] numArr = new int[arrCapacity];
            for (int i = 0; i < arrCapacity; i++)
               numArr[i] = randomNum.Next (1, 10);
            Array.ForEach (numArr, i => Console.Write ($"{i} "));
            Console.Write ("\nEnter index a: ");
            int.TryParse (Console.ReadLine (), out int a);
            Console.Write ("Enter index b: ");
            int.TryParse (Console.ReadLine (), out int b);
            if (a >= 0 && a <= arrCapacity - 1 && b >= 0 && b <= arrCapacity - 1) {
               indexSwap (numArr, a, b);
               Console.WriteLine ("Swapped series of numbers");
               Array.ForEach (numArr, i => Console.Write ($"{i} "));
            } else Console.Write ($"Provide indices whithin the range. From 0 to {arrCapacity - 1}.");
         } else Console.WriteLine ("Length of the series should be greater than 1.");
      }
      static void indexSwap (int[] arr, int a, int b) => (arr[a], arr[b]) = (arr[b], arr[a]);
   }
}