Console.WriteLine("Enter n: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Enter m: ");
double m = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter x: ");
double x = double.Parse(Console.ReadLine());

double
    z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + m * n + m * m - m),
    z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m,
    y = 2.4 * Math.Abs((x * x + b) / a) + (a-b)*Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2)*(x-b);
Console.WriteLine("z1 is " + z1.ToString());
Console.WriteLine("z1 is " + z2.ToString());
Console.WriteLine("z1 is " + y.ToString());
