/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
 чисел больше 0 ввёл пользователь.*/
//Console.WriteLine("Введите количество чисел:");
//int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа через пробел:");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

Console.WriteLine(PositivNum(array));

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] res = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        res[i] = int.Parse(stringArray[i]);
    }
    return res;

}
int PositivNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
