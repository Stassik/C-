// Напишите программу, которая:
// 1. принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// 2. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter (int xc, int yc)
{
    if ((xc > 0) && (yc > 0)) return 1;
    if ((xc < 0) && (yc > 0)) return 2;
    if ((xc < 0) && (yc < 0)) return 3;
    if ((xc > 0) && (yc < 0)) return 4;
    return 0;
}

int quarter = Quarter(x, y);
Console.WriteLine(quarter > 0 ? $"Координаты точки соотвествуют {quarter} четверти." : "Неверные координаты.");
