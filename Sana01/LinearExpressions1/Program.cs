double a, b, c, d;

Console.WriteLine("Input a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input c:");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Input d:");
d = double.Parse(Console.ReadLine());

double x, y, z, r;

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
y = (5 * (a + b) * (c - d)) / ((1 / 2.0) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = ((1 / 2.0) * a + (3 / 4.0) * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine("\nResults:");
Console.Write("x = ");
Console.WriteLine(x);
Console.Write("y = ");
Console.WriteLine(y);
Console.Write("z = ");
Console.WriteLine(z);
Console.Write("r = ");
Console.WriteLine(r);