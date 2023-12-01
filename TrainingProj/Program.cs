// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Implement double.Parse method that takes a string and returns a double.
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Double ------------------------------------------------------------------------------
   /// <summary>DoubleParse</summary>
   internal class Double {
      #region Methods -----------------------------------------------
      static void Main (string[] args) { }

      /// <summary>Checks if input string is in correct format or not, to implement Double.Parse</summary>
      /// <param name="input">Input string</param>
      /// <returns>True if it is valid string, else false</returns>
      public static bool IsValid (string input) {
         int eIndex = input.IndexOf ('e'), dotIndex = input.IndexOf ('.'),
            plusCount = input.Count (a => a == '+'), minusCount = input.Count (a => a == '-');
         if (!input.All (a => a is '.' or 'e' or '+' or '-' || char.IsDigit (a))) return false;
         if (input.StartsWith ('e') || input.EndsWith ('e')) return false;
         if (input.Any (a => a == 'e')) {
            if (!char.IsDigit (input[eIndex - 1]) && (input[eIndex - 1] != '.' && !char.IsDigit (input[eIndex - 2]))) return false;
            if (eIndex < dotIndex) return false;
         }
         if (!isValidPosition ('+')) return false;
         if (!isValidPosition ('-')) return false;
         return true;

         /// <summary>Checks if plus or minus is in correct position according to count</summary>
         /// <param name="c">char plus or minus</param>
         /// <returns>True if position of char is valid</returns>
         bool isValidPosition (char c) {
            int count = input.Count (a => a == c);
            switch (count) {
               case 2:
                  if (!(input[0] == c && input[eIndex + 1] == c)) return false; break;
               case 1:
                  if (!(input[0] == c || input[eIndex + 1] == c)) return false; break;
            }
            return true;
         }
      }

      /// <summary>Parse the given string into double with decimal point</summary>
      /// <param name="input">Input string</param>
      /// <returns>Returns parsed double</returns>
      static double ParseDecimalPart (string input) {
         string[] inputStringArr = input.Split ('.');
         double integralPart = int.Parse (inputStringArr[0]);
         int length = inputStringArr[1].Length;
         double fractionalPart = length == 0 ? 0 : (int.Parse (inputStringArr[1])) / Math.Pow (10, length);
         if (integralPart < 0) fractionalPart = -1 * fractionalPart;
         return integralPart + fractionalPart;
      }

      /// <summary>Parse the given string into double with exponent</summary>
      /// <param name="input">Input string</param>
      /// <returns>Returns parsed double</returns>
      static double ParseExponent (string input) {
         string[] inputStringArr = input.Split ('e');
         double beforeE = inputStringArr[0].Contains ('.') ? ParseDecimalPart (inputStringArr[0]) : int.Parse (inputStringArr[0]);
         return beforeE * Math.Pow (10, int.Parse (inputStringArr[1]));
      }

      /// <summary>Checks if string is valid or not</summary>
      /// <param name="input">Input string</param>
      /// <returns>Returns parsed double, if the string is valid</returns>
      /// <exception cref="FormatException">Throws exceptionm, when input the string is invalid</exception>
      public static double Parse (string input) {
         if (!IsValid (input)) throw new FormatException ($"The input string '{input}' was not in a correct format.'");
         double doubleValue = input.Contains ('e') ? ParseExponent (input) : (input.Contains ('.') ? ParseDecimalPart (input) : int.Parse (input));
         return doubleValue;
      }
      #endregion
   }
   #endregion
}