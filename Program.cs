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
         iso = iso.ToLower ();
         foreach (char c in iso)
            if (chars.Contains (c) ? false : !chars.Add (c)) return false;
         return true;
      }
   }
}