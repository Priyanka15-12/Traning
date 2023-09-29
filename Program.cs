using System.Text;
//--------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// STRONG PASSWORD
// Password considered to be strong if it satisfies the following criteria: 
// Its length is at least 6. 
// It contains at least one digit. 
// It contains at least one lowercase English character. 
// It contains at least one uppercase English character. 
// It contains at least one special character. The special characters are: !@#$%^&*()-+ 
// Input: Password string, Output: Returns whether the password is strong or not with reasons.  
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Strong password</summary>
   internal class Program {
      #region Methods ------------------------------------------------
      /// <summary>This method shows whether the password is strong and not, which is given by user</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Enter Password: ");
         string password = Console.ReadLine () ?? "";
         (bool isStrong, string errorMsg) = IsStrongPassword (password);
         Console.WriteLine (isStrong ? "Strong psssword" : $"Not a strong password \n{errorMsg}");
      }

      /// <summary>Checks if character is lowercase or not</summary>
      /// <param name="c">char of password</param>
      /// <returns>Its returns bool value true, if c is lowercase</returns>
      static bool IsLower (char c) => (c >= 'a' && c <= 'z');

      /// <summary>Checks if the character is uppercase or not</summary>
      /// <param name="c">char od password</param>
      /// <returns>Its returns bool value true, if c is uppercase</returns>
      static bool IsUpper (char c) => (c >= 'A' && c <= 'Z');

      /// <summary>Checks if the character is digit or not</summary>
      /// <param name="c">char of password</param>
      /// <returns>Its returns bool value true, if c is digit</returns>
      /// 
      static bool IsDigit (char c) => (c >= '0' && c <= '9');

      /// <summary>Check whether password is strong or not and finds the reasons for weak password</summary>
      /// <param name="password">string password</param>
      /// <returns>Its returns bool value true for strong password or false for not a strong password with string of error message</returns>
      static (bool, string ) IsStrongPassword (string password) {
         StringBuilder errorMsg = new ();
         string spl = "!@#$%^&*()-+";
         bool lower = false, upper = false, digit = false, splChar = false;
         bool flag = password.All(c=> char.IsLetter (c) || char.IsDigit (c) || spl.Contains (c));
         if (flag) {
            foreach (char c in password) {
               if (IsLower (c)) lower = true;
               else if (IsUpper (c)) upper = true;
               else if (IsDigit (c)) digit = true;
               else if (spl.Contains (c)) splChar = true;
            }
            if (password.Length < 6) errorMsg.Append ("Password must have atleast six characters.\n");
            if (!upper) errorMsg.Append ("Password must have atleast one uppercase character.\n");
            if (!lower) errorMsg.Append ("Password must have atleast one lowercase character.\n");
            if (!digit) errorMsg.Append ("Password must have atleast one digit.\n");
            if (!splChar) errorMsg.Append ($"Password must have atleast one special character. The special characters are:{spl}");
         } else errorMsg.Append ($"Please choose characters within :{spl}");
         return (errorMsg.Length == 0, errorMsg.ToString ());
      }
      #endregion
   }
   #endregion
}
