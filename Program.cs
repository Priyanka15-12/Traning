using System;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a string: ");
         string iso = Console.ReadLine ();
         bool isogram = Isogram (iso);
         Console.WriteLine ($"{iso} is {(Isogram (iso) ? "" : "not ")}an isogram.");
      }

      static bool Isogram (string iso) {
         iso = iso.ToLower ();
         HashSet<char> chars = new HashSet<char> ();
         foreach (char c in iso) {
            if (chars.Contains (c))
               return false;
            chars.Add (c);
         }
         return true;
      }
   }
}