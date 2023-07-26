Random r = new();
int n = r.Next (1, 101);
Console.Write ("Guess the random number: ");
for (int i = 1; ; i++) {
   String a = Console.ReadLine ();
   if (int.TryParse (a, out int p)) {
      if (p < n)
         Console.Write ($"Your guess '{p}' is too low  ");
      else if (p == n) {
         Console.Write ($"You got the answer at {i} time of guess!");
         break;
      } 
      else
         Console.Write ($"Your guess '{p}' is too high  ");
   }
}