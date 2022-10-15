Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int c = Convert.ToInt32(Console.ReadLine());


if (a > b && a > c)
    Console.WriteLine($"Max: {a}");
else if (b > a && b > c)
    Console.WriteLine($"Max: {b}");
else if (c > a && c > b)
    Console.WriteLine($"Max: {b}");
else
    Console.WriteLine("Числа равны");