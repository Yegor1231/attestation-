void Main()
{
    int m = 4;

    int n = 12;

    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    Console.WriteLine(PrintNaturalNumbers(m, n));

}

string PrintNaturalNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + ", " + PrintNaturalNumbers(m + 1, n);
}

Main();