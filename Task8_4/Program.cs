/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/
Console.WriteLine("Зададим трехмерный массив:");
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array = new int[x, y, z];
int size = x * y * z;
int deep = 89;
int intervalCount = deep / size;
if (size > deep)
{
    Console.WriteLine("Заполнение не будет уникальным!");
}
else
{
    InitArray(array);
    FillArray(array);
}


void InitArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = 0;
            }
        }
    }

}

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GetArrayUniqueValue(array);
                Console.WriteLine($"({i}, {j}, {k}) = {array[i, j, k]}");
            }
        }
    }
}

int GetArrayUniqueValue(int[,,] array)
{
    Random generator = new Random();
    
    int value = 0;
    while (true)
    {
        bool found = false;
        value = generator.Next(10, 100);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (array[i, j, k] == value)
                    {
                        found = true;
                    }
                }
            }
        }

        if (!found)
        {
            break;
        }
    }
    return value;
}