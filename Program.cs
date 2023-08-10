namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter pharse or word: ");
         string input_word = Console.ReadLine ();
         string word = input_word.Replace (" ", string.Empty);
         string rev = "";
         int w = word.Length - 1;
         for (int i = 0; i <= w; w--) {
            rev = rev + word[w];
         }
         if (word.ToLower () == rev.ToLower ()) {
            Console.WriteLine ("palindrome");
         } else Console.WriteLine ("not palindrome");
      }
   }
}