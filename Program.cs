void Main()
{
    int m = 3;
    int n = 5;

    Console.WriteLine($"A({m}, {n}) = {AkkerFunc(m, n)}");
}

int AkkerFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkerFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
    }
    return(AkkerFunc(m,n));

}

Main();