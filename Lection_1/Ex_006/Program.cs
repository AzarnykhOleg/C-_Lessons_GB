int a = 1;
int b = 12;
int c = 8;
int d = 4;
int e = 24;

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число: ");
Console.WriteLine(max);