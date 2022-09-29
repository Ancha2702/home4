/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.*/
Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int[] array = Create(arrayLenght);
FillArray(array);
PrintArray(array);
int pos = Count(array);
Console.WriteLine("");
Console.WriteLine($"Четных чисел в массиве: {pos}");

int[] Create(int arrayLenght)// создание массива
{
    return new int[arrayLenght];
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(100, 1000);
    }
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}