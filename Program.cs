namespace Training {
    internal class Program {
        static void Main (string[] args) {
         string[] words = File.ReadAllLines ("C:\\Users\\priyanka.s\\Downloads\\words.txt");
         char[] letters = { 'U', 'X', 'L', 'T', 'A', 'E', 'N' };
         int total = 0, total2 = 0, total1 = 0, index = 0; ;
         string[] wordarray = new string[words.Length];
         int[] point = new int[words.Length];
         foreach (string word in words) {
            if (word.Length >= 4 && word.Contains (letters[0]) && word.All (letters.Contains)) {
               int marks = 0;
               if (word.Length == 4) {
                  marks = 1;
                  total1 = total1 + marks;
               } else if (word.Length > 4) {
                  if (letters.All (word.Contains)) {
                     marks = word.Length + 7; Console.ForegroundColor = ConsoleColor.Green;
                  } else
                     marks = word.Length;
                  total2 = total2 + marks;
               }
               point[index] = marks;
               wordarray[index] = word;
               index++;
            }
         }
         Array.Sort (point, wordarray, 0, index, Comparer<int>.Create ((a, b) => b.CompareTo (a)));
         for (int i = 0; i < index; i++) {
            Console.WriteLine ($"{point[i],2}. {wordarray[i]}");
            Console.ResetColor ();
         }
         total = total1 + total2;
         Console.WriteLine ("---");
         Console.WriteLine ($"{total} =Total");
        }
    }
}