// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// SORT AND SWAP SPECIAL CHARACTERS
// Given a character array A, along with special character S and sort order O (default order is Ascending),
// print the sorted array by keeping the elements matching S to the last of the array. 


// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Sort and swap special characters</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Shows descending order or ascending order of elements, by special characters appended at last</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Provide some character elements:");
         string characters = Console.ReadLine ().ToLower () ?? "";
         if (characters.Length == 0) Console.WriteLine ("Provide some characters");
         else {
            var CharacterArr = characters.ToCharArray ();
            Console.Write ("Pick a character from your input to print at the last: ");
            char.TryParse (Console.ReadLine (), out char splChar);
            Console.Write ("Enter D or d for descending order otherwise press Enter key. ");
            char key = Console.ReadKey ().KeyChar;
            Console.WriteLine ();
            SortAndSwap (CharacterArr, key, splChar);
         }
      }

      /// <summary>By enter D/d, it gives descending order or else ascending order, by special characters appended at last</summary>
      /// <param name="inputArr">input array</param>
      /// <param name="order">key for deciding descending or ascending</param>
      /// <param name="find">char which added at last</param>
      static void SortAndSwap (char[] inputArr, char order, char find) {
         inputArr = (order == 'D' || order == 'd' ? inputArr.OrderDescending ().ToArray () : inputArr.OrderBy (x => x).ToArray ());
         var charList = inputArr.ToList ();
         int findCount = charList.RemoveAll (x => x == find);
         for (int i = 0; i < findCount; i++)
            charList.Add (find);
         foreach (char x in charList)
            Console.Write (x + " ");
      }
      #endregion
   }
   #endregion
}