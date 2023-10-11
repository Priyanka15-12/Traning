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
            var characterList = characters.ToList ();
            Console.Write ("Pick a character from your input to print at the last: ");
            char.TryParse (Console.ReadLine (), out char splChar);
            Console.Write ("Enter D or d for descending order otherwise press Enter key. ");
            char key = Console.ReadKey ().KeyChar;
            Console.WriteLine ();
            SortAndSwap (characterList, key, splChar);
         }
      }

      /// <summary>By entering D/d, it gives descending order or otherwise ascending order, by special characters appended at last</summary>
      /// <param name="inputList">input array</param>
      /// <param name="order">key for deciding descending or ascending</param>
      /// <param name="splChar">char which added at last</param>
      static void SortAndSwap (List<char> inputList, char order, char splChar) {
         int splCharCount = inputList.RemoveAll (x => x == splChar);
         inputList = (order is 'D' or 'd' ? inputList.OrderDescending ().ToList () : inputList.OrderBy (x => x).ToList ());
         for (int i = 0; i < splCharCount; i++) inputList.Add (splChar);
         Console.WriteLine (String.Join (" ", inputList));
      }
      #endregion
   }
   #endregion
}