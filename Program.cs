Random r = new Random ();
int n = r.Next (1, 101);
Console.Write ("Guess the random number: ");
for (; ; ) {
   int p = int.Parse (Console.ReadLine ());
   Console.WriteLine (p);
   if (p < n) {
      Console.Write ("Your guess is too low  ");
   } else if (p == n) {
      Console.Write ("You got it!");
      break;
   } else {
      Console.Write ("Your guess is too high  ");
   }
}