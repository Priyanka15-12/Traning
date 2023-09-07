namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter decimal number: ");
         decimal.TryParse (Console.ReadLine (), out decimal dec);
         Console.Write ("Integral Part: ");
         DeciDigit (dec);
         Console.Write ("\nFractional Part: ");
         Fraction (dec);
      }
      static void DeciDigit (decimal d) {
         int whole = (int)d;
         int[] wholeArr = new int[whole.ToString ().Length];
         for (int i = whole.ToString ().Length - 1; i >= 0; i--) {
            wholeArr[i] = whole % 10;
            whole /= 10;
         }
         Array.ForEach (wholeArr, i => Console.Write ($"{i} "));
      }
      static void Fraction (decimal d) {
         decimal frac = (d - (int)d);
         if (frac > 0) {
            string fracStr = frac.ToString ().Substring (2);
            int[] fracArr = new int[fracStr.Length];
            for (int i = 0; i < fracStr.Length; i++)
               fracArr[i] = int.Parse (fracStr[i].ToString ());
            Array.ForEach (fracArr, i => Console.Write ($"{i} "));
         } else Console.WriteLine (0);
      }
   }
}