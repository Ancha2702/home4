/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Ищем точку пересечения для уравнений вида y = k * x + b");
Console.WriteLine("Введите значение коэффициента k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение коэффициента b1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение коэффициента k2:");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение коэффициента b2:");
double b2 = double.Parse(Console.ReadLine()!);

double[] Solve(double k1, double k2, double b1, double b2)
{
    double y = (b2 - b1) / (k2 - k1);
    double x = (b2 - y) / k2;
    double[] arr = new double[] { Math.Round(x, 3), Math.Round(y, 3) };
    return arr;
}
double[] res = Solve(k1, k2, b1, b2);
Console.WriteLine($"Две прямые пересекаются в координатах: x = {res[0]} b y= {res[1]}");