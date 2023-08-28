namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a string: ");
         string iso = Console.ReadLine ();
         bool isogram = Isogram (iso);
         Console.WriteLine ($"{iso} is {(Isogram (iso) ?"":"not ")}an isogram.");
      }

      static bool Isogram (string iso) {
         iso = iso.ToLower ();
         for (int i = 0; i < iso.Length - 1; i++) {
            for (int j = i + 1; j < iso.Length; j++) {
               if (iso[i] == iso[j])
                  return false;
            }
         }
         return true;
      }
   }
}