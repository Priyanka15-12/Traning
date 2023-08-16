using System;
Console.Write ("Enter input: ");
int n = int.Parse (Console.ReadLine ());
int a = 0, b = 1, i = 2;
Console.Write ($"{a} {b} ");
while (n > i) {
   i++; int c = a + b;
   a = b;
   b = c;
   Console.Write ($"{c} ");
}