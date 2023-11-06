Console.WriteLine("Enter number(float point) a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number(float point) d:");
double d = double.Parse(Console.ReadLine());

double
    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / b / b,
    y = 10 * (a + b) * (c - d) / c + d * d * (a * a - b * b) / (b - a),
    z = (Math.Pow(x * x - 2 * x, 3) - 4 * (x * x * x * x + 1)) * (1 - b) / (5 * a + 3 * b),
    r = (1/2*a + 3/4*b - 7/5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(r);

