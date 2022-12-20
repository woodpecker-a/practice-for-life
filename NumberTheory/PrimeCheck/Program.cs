bool IsPrime(double? n)
{
    if(n < 2) return false;
    else if(n <= 3) return true;
    else if(n % 2 == 0) return false;
    else for (int i = 3; i * i <= n; i += 2) if (n % i == 0) return false;
    return true;
}

static double? GetInput() => double.Parse(Console.ReadLine());

var n = GetInput();

if (n.HasValue)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write($"{n.Value} is");
    Console.Write(IsPrime(n) ? " Prime" : " Not Prime");
    Console.ForegroundColor= ConsoleColor.White;
}