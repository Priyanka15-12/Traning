namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter Password: ");
         string Password = Console.ReadLine ();
         if (check (Password) == "true") Console.WriteLine ("Strong password.");
         else Console.WriteLine ("Not a strong password. \n" + check (Password)) ;
      }
      static string check (string pass) {
         string lower = "", upper = "", digit = "", splchar = "", notstrong = "";
         foreach (char c in pass) {
            if (char.IsLower (c))
               lower = "true";
         }
         foreach (char c in pass) {
            if (char.IsUpper (c))
               upper = "true";
         }
         foreach (char c in pass) {
            if (char.IsDigit (c))
               digit = "true";
         }
         foreach (char c in pass) {
            string spl = " !@#$%^&*()-+";
            if (spl.Contains (c))
               splchar = "true";
         }
         if (pass.Length >= 6 && lower == "true" && upper == "true" && splchar == "true" && digit == "true")
            return "true";
         else {
            if (upper != "true") notstrong = "Password must have atleast one upper character\n";
            if (lower != "true") notstrong += "Password must have atleast one lower character\n";
            if (digit != "true") notstrong += "Password must have atleast one digit \n";
            if (splchar != "true") notstrong += "Password must have atleast one special character.\n";
            if (pass.Length < 6) notstrong += "Password must have atleast six character.\n";
            return notstrong;
         }
      }
   } 
}
