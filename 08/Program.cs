Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1)
    Console.WriteLine("Недопустимое число");
else
{
    int count = 2;

    while (count <= a)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}