// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"Max: {a}, Min: {b}");
else if (b > a)
    Console.WriteLine($"Max: {b}, Min: {a}");
else
    Console.WriteLine("Числа равны");