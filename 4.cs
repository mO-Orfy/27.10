Console.Write("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine());

double cos = 0;
double sin = 0;
double result = 1;

for (int i = 1; i <= N; i++)
{
    cos += Math.Cos(i);
    sin += Math.Sin(i);
    result *= cos / sin;
}

Console.WriteLine($"Результат: {result}");