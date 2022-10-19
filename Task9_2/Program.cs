/* Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.*/
Console.WriteLine("Введите первое число m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число n:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {SumNatNum(n, m)}");

int SumNatNum(int m, int n)
{

    if (m == 0)
    {
        return (n * (n + 1) / 2);
    }
    else if (n == 0)
    {
        return (m * (m + 1) / 2);
    }
    else if (n == m)
    {
        return m;
    }
    else if (m < n)
    {
        return n + SumNatNum(m, n - 1);
    }
    else return n + SumNatNum(m, n + 1);
}