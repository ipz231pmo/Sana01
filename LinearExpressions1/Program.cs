Console.WriteLine("Enter number(float point) a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) d:");
double d = double.Parse(Console.ReadLine());

double
    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b),
    y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + d * d * (a * a - b * b) / (b - a),
    z = (Math.Pow(x * x - 2 * x, 3) - 4 * (x * x * x * x + 1)) * (1 - b) / (5 * a + 3 * b),
    r = (1.0/2*a + 3.0/4*b - 7.0/5) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine($"x is + {x}");
Console.WriteLine($"y is + {y}");
Console.WriteLine($"z is + {z}");
Console.WriteLine($"r is + {r}");