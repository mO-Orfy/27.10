Console.WriteLine("Введите Кол-во чисел последовательности");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введиет число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последнюю цифру");
int last = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;
for (int i = 0; i < n; i++)
{
 if (number % 10 == last)
 {
 sum += i;
 count++;
 }

}
if (count > 3)
{
 Console.WriteLine($"Сумма трех чисел, оканчивающихся на {last}, равна {sum}.");
}
else
{
 Console.WriteLine($"Недостаточно чисел, оканчивающихся на {last}, чтобы найти сумму трех членов.");
}