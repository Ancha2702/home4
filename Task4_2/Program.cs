/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int lenght = NumberLen(num);
int NumberLen(int num)// длина числа
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}
int Sum(int num, int lenght)// расчет суммы
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
         sum += num % 10;
        num /= 10;
    }
    return sum;
}
int res = Sum(num, lenght);
Console.WriteLine($"Cумма {res}");