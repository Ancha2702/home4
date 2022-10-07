/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию элемента в массиве: ");
Console.Write("Введите позицию по строке: ");
int k = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию по столбцу: ");
int r = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ChoiceElement(array);



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
            // Console.Write(" | ");
        }


        Console.WriteLine();
    }
}



void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = generator.Next(0, 100);

        }
    }
}


void ChoiceElement(int[,] array)
{
    if (m < k+1 || n < r+1)
    {
        Console.Write("такого числа нет");
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == k && j == r)
            {
                Console.Write($"Выбранный элемент равен {array[i, j]} ");
                // Console.Write(" | ");
            }

        }
        //        Console.WriteLine();
    }
}
