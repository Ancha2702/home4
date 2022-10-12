/*Задайте прямоугольный двумерный массив. Напишите программу,
  которая будет находить строку с наименьшей суммой элементов.*/

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
double[] sumrow = CalcSumRows(array);
Console.WriteLine($"Суммы элементов строки: {string.Join(" ", sumrow)}");
int indexrow = MinSumIndex(sumrow);

Console.WriteLine($"Строка с наименьшей суммой элементов под номером: {indexrow+1}");

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

double[] CalcSumRows(int[,] array)
{
    double[] sumrow = new double[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumrow[i] = sum;

    }
    return sumrow;
}

int MinSumIndex(double[] sumrow)
{
    double mins = sumrow[0];
    int indexrow = 0;
    for (int i = 0; i < sumrow.Length; i++)

        if (sumrow[i] < mins)
        {
            mins = sumrow[i];
            indexrow = i;
        }
    return indexrow;
}