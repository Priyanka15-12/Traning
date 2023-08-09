using System;
Console.Write ("Enter input: ");
int n = int.Parse (Console.ReadLine ());
int a = 0, b = 1, c, i = 2;
Console.Write ($"{a} ");
Console.Write ($"{b} ");
while (n > i) {
   i++;
   c = a + b;
   a = b;
   b = c;
   Console.Write ($"{c} ");
}