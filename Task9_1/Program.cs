/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.*/
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
//int numbers = NatNum(num);
//Console.WriteLine(numbers);
NatNum(num);
void NatNum(int num)
{
    Console.Write($" {num} ");
    if (num == 1)
    {
        return;

    }
    else
    {

        NatNum(num - 1);

    }
}