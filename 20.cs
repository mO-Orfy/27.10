Console.WriteLine("Введите значение коэффициента a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента c:");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение координаты x точки:");
double m = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение координаты y точки:");
double n = Convert.ToDouble(Console.ReadLine());

double y = a * Math.Pow(m, 2) + b * m + c;

if (y == n)
{
    Console.WriteLine("График функции проходит через заданную точку.");
}
else
{
    Console.WriteLine("График функции не проходит через заданную точку.");
}
