using System.Text;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         //Enter a string to delete a pair of same and adajacent letters.
         Console.Write ("Enter a string: ");
         string original = Console.ReadLine ();
         string reduced = ReducedString (original);
         Console.WriteLine ((reduced.Length > 0) ? $"Reduced string: {reduced}" : "Empty string, after reduction reduced string is empty.");
      }

      static string ReducedString (string original) {
         StringBuilder reduced = new ();
         int i = 0;
         while (i < original.Length)
            if (i == original.Length - 1 || original[i] != original[i + 1]) {
               reduced.Append (original[i]);
               i++;
            } else
               i += 2;
         return reduced.ToString ();
      }
   }
}