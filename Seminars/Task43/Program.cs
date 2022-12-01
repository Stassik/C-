// Напишите программу, которая:
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double GetX(double bA, double bB, double kA, double kB)
{
    double x1 = (bB - bA) / (kA - kB);
    return x1;
}

double GetY(double bA, double kA, double x1)
{
    double y1 = kA * x1 + bA;
    return y1;
}

double x = Math.Round(GetX(b1, b2, k1, k2), 2, MidpointRounding.ToZero); // В принципе и без округления получается как в условии задачи
double y = Math.Round(GetY(b1, k1, x), 2, MidpointRounding.ToZero);
Console.WriteLine($"({x}; {y})");