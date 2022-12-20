

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if (a > b) max = a; min = b;
if (b > a) max = b; min = a;
Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");

Console.WriteLine(min);