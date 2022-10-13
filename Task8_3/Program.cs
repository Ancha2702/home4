/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

Console.Write("Введите количество строк для матрицы 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы 1: ");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк для матрицы 2: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для матрицы 2: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] array1 = new int[row1, col1];
int[,] array2 = new int[row2, col2];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);

int[,] multiply = Multiply(array1, array2);
//Console.WriteLine($"Произведение матриц: {string.Join(" ", multiply)}");
if (array1.GetLength(1) == array2.GetLength(0))
{
    Console.WriteLine("Произведение двух матриц:");
    PrintArray(multiply);
}
else
{
    Console.WriteLine("Матрицы нельзя перемножить");

}

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
            array[i, j] = generator.Next(0, 10);
        }
    }
}

int[,] Multiply(int[,] array1, int[,] array2)
{
    int[,] multiply = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < multiply.GetLength(0); i++)
    {
        for (int j = 0; j < multiply.GetLength(1); j++)
        {
            multiply[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multiply[i, j] += (array1[i, k] * array2[k, j]);
            }

        }

    }
return multiply;
}
