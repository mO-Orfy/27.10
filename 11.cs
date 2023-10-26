double res = 1;
for (double i = 0.1; i <= 10; i += 0.1)
{
    double sin = Math.Sin(i);
    res *= (1 + sin);
}

Console.WriteLine("Результат: " + res);