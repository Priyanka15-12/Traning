using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter pharse or word: ");
         string inputPhrase = Console.ReadLine ();
         string words = inputPhrase.Replace (" ", string.Empty);
         int left = 0;
         int right = words.Length - 1;
         while (left<= right) {
            if (char.ToUpper (words[left]) != char.ToUpper (words[right])) break;
            left++; right--;
         }
         Console.WriteLine (char.ToUpper (words[left]) == char.ToUpper (words[right]) ?"Palindrome" : "Not a palindrome.");
      }
   }
}