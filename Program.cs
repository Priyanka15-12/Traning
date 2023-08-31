namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter decimal number: ");
         decimal dec = decimal.Parse (Console.ReadLine ());
         Console.WriteLine (DeciDigit (dec)); 
      }
      static string DeciDigit (decimal d) {
         int whole = (int)d;
         decimal frac = (d - whole);
         int len = frac.ToString ().Length;
         int power = (int)Math.Pow (10, (len - 2));
         int zeroDigit = ((int)(frac * power)).ToString ().Length;
         var res = ((len - 2) > zeroDigit) ? string.Concat (Enumerable.Repeat ("0", ((len - 2) - zeroDigit))) : "";
         return ($"Integral part: {whole}\nFactorial part: {res}{(int)(frac * power)}");
      }
   }
}