/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);
int neg = Count(array);
Console.WriteLine("");
Console.WriteLine($"Сумма чисел в массиве: {neg}");

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
}

int Count(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}