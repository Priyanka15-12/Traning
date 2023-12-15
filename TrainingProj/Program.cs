// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Implement double.Parse method that takes a string and returns a double.
// --------------------------------------------------------------------------------------------
namespace Training {
   #region MyDouble ----------------------------------------------------------------------------
   /// <summary>MyDouble</summary>
   public class MyDouble {
      #region Methods -----------------------------------------------
      static void Main () { }

      /// <summary>Checks if input string is in correct format or not, to implement Double.Parse</summary>
      /// <param name="input">Input string</param>
      /// <returns>True if it is a valid string, else false</returns>
      static bool IsValid (string input) {
         int eIndex = input.IndexOf ('e'), dotIndex = input.IndexOf ('.');
         if (!input.All (a => a is '.' or 'e' or '+' or '-' || char.IsDigit (a))) return false;
         if (input.StartsWith ('e') || input.EndsWith ('e')) return false;
         if ((input.Count (a => a == 'e') > 1) || input.Count (a => a == '.') > 1) return false;
         if (input.Any (a => a == 'e')) {
            if (!char.IsDigit (input[eIndex - 1]) &&
                input[eIndex - 1] == '.' && input.StartsWith ('.')) return false;
            if (eIndex < dotIndex) return false;
         }
         if (!IsValidPlusMinus ('+') || !IsValidPlusMinus ('-')) return false;
         return true;

         /// <summary>Checks if plus or minus is in correct positions</summary>
         /// <param name="c">char plus or minus</param>
         /// <returns>True if positions are valid</returns>
         bool IsValidPlusMinus (char c) {
            switch (input.Count (a => a == c)) {
               case 2:
                  if (!(input[0] == c && input[eIndex + 1] == c)) return false; break;
               case 1:
                  if (!(input[0] == c || input[eIndex + 1] == c)) return false; break;
            }
            return true;
         }
      }

      /// <summary>Parse the given string with decimal point into double</summary>
      /// <param name="input">Input string</param>
      /// <returns>Returns parsed double</returns>
      static double GetParsedDecimal (string input) {
         string[] inputParts = input.Split ('.');
         double integralPart = inputParts[0].Length == 0
                               ? 0 : inputParts[0] is "-" or "+"
                               ? 0 : Math.Abs (int.Parse (inputParts[0]));
         int fracLength = inputParts[1].Length;
         double fractionalPart = fracLength == 0
                               ? 0 : int.Parse (inputParts[1]) / Math.Pow (10, fracLength);
         var result = integralPart + fractionalPart;
         return input[0] == '-' ? -result : result;
      }

      /// <summary>Parse the given string with exponent into double</summary>
      /// <param name="input">Input string</param>
      /// <returns>Returns parsed double</returns>
      static double GetParsedExponent (string input) {
         string[] parts = input.Split ('e');
         double beforeExpo = parts[0].Contains ('.')
                          ? GetParsedDecimal (parts[0]) : int.Parse (parts[0]);
         return beforeExpo * Math.Pow (10, int.Parse (parts[1]));
      }

      /// <summary>Parses the string into double, if valid</summary>
      /// <param name="str">Input string</param>
      /// <returns>Returns parsed double</returns>
      /// <exception cref="FormatException">Throws exception, when input string is invalid</exception>
      public double Parse (string str) {
         string input = str.ToLower ();
         if (!IsValid (input))
            throw new FormatException ($"The input string '{input}' was not in a correct format.'");
         return input.Contains ('e') ? GetParsedExponent (input) : (input.Contains ('.')
                                     ? GetParsedDecimal (input) : int.Parse (input));
      }
      #endregion
   }
   #endregion
}