static void Main(string[] args)
{
    int n = 534534623;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}

static int GetSecondDigit(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}