//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите 2 неотрицательных числа:");
Console.WriteLine("Введите первое число n:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана для чисел {n} и {m} равна {Akkerman(n, m)}");

int Akkerman(int n, int m)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Числа не подходят, нужны неотрицательные");
        return 0;
    }
    else if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}