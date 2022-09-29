/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

double[] array = new double[arrayLenght];

FillArray(array);
PrintArray(array);
double result = Max(array) - Min(array);
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным значением {Max(array)} и минимальным {Min(array)}: {result}");

void FillArray(double[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.NextDouble();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
}

double Min(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

double Max(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

