/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/
Console.WriteLine("Введите число, которое нужно возвести в степень:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int num2 = int.Parse(Console.ReadLine()!);
if (num2 < 0) // проверка степени на неотрицательность
{
    Console.WriteLine("Степень должна быть натуральной!");
}
else
{
    int result = FuncCount(num1, num2);
    Console.WriteLine($"Результат: {result}");
}

int FuncCount(int num1, int num2)//Рассчет
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res = res * num1;
    }
    return res;
}
