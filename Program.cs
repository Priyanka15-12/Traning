using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a string: ");
         string iso = Console.ReadLine ();
         Console.WriteLine ($"{iso} is {(Isogram (iso) ? "" : "not ")}an isogram.");
      }

      static bool Isogram (string iso) {
         HashSet<char> chars = new ();
         foreach (char c in iso.ToLower ())
            if (chars.Contains (c)) return false;
            else chars.Add (c);
         return true;
      }
   }
}
