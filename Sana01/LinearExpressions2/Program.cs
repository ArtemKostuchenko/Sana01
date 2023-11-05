double m, n, x, a, b;

Console.WriteLine("Input m:");
m = double.Parse(Console.ReadLine());

Console.WriteLine("Input n:");
n = double.Parse(Console.ReadLine());

Console.WriteLine("Input x:");
x = double.Parse(Console.ReadLine());

Console.WriteLine("Input a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input b:");
b = double.Parse(Console.ReadLine());




double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);


Console.WriteLine("\nResults:");
Console.Write("z1 = ");
Console.WriteLine(z1);
Console.Write("z2 = ");
Console.WriteLine(z2);
Console.Write("y = ");
Console.WriteLine(y);