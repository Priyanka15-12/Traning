using System.Text;

namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter Password: ");
         string Password = Console.ReadLine ();
         (bool isStrong, string errorMsg) = checkPassword (Password);
         if (isStrong) Console.WriteLine ("Strong password.");
         else Console.WriteLine ("Password is not strong.\n" + errorMsg);
      }
      static bool isLower (char c) {
         return (c > 'a' && c < 'z');
      }
      static bool isUpper (char c) {
         return (c > 'A' && c < 'Z');
      }
      static bool isDigit (char c) {
         return (c > '0' && c < '9');
      }
      static (bool isStrong, string errorMsg) checkPassword (string pass) {
         StringBuilder err = new ();
         string spl = "!@#$%^&*()-+";
         bool lower = false, upper = false, digit = false, splChar = false;
         foreach (char c in pass) {
            if (isLower (c)) lower = true;
            else if (isUpper (c)) upper = true;
            else if (isDigit (c)) digit = true;
            else if (spl.Contains (c)) splChar = true;
         }
         if (pass.Length < 6) err.Append ("Password must have atleast six characters.\n");
         if (!upper) err.Append ("Password must have atleast one uppercase character.\n");
         if (!lower) err.Append ("Password must have atleast one lowercase character.\n");
         if (!digit) err.Append ("Password must have atleast one digit.\n");
         if (!splChar) err.Append ("Password must have atleast one special character. The special characters are:!@#$%^&*()-+");
         return (lower && upper && digit && splChar && pass.Length >= 6, err.ToString ());
      }
   }
}