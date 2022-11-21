Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());
if ((a >= b) && (a >= c))
{
    Console.WriteLine($"Больше первое число - {a}");
}
else if ((b >= a) && (b >= c))
{
    Console.WriteLine($"Больше второе число - {b}");
}
else 
{
    Console.WriteLine($"Больше третье число - {c}");
}