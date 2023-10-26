Console.WriteLine("Введите размеры первого параллелепипеда:");
Console.Write("Длина: ");
double l1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ширина: ");
double w1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Высота: ");
double h1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите размеры второго параллелепипеда:");
Console.Write("Длина: ");
double l2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ширина: ");
double w2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Высота: ");
double h2 = Convert.ToDouble(Console.ReadLine());

double x = l1 * w1 * h1;
double y = l2 * w2 * h2;

Console.WriteLine($"Объем первого параллелепипеда: {x}");
Console.WriteLine($"Объем второго параллелепипеда: {y}");

if (x > y){
    Console.WriteLine("Объем первого параллелепипеда больше объема второго.");
}
else if (x < y){
    Console.WriteLine("Объем первого параллелепипеда меньше объема второго.");
}
else if (x==y) {
    Console.WriteLine("Объем первого параллелепипеда равен объема второго.");
}

 