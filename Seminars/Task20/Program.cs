// Напишите программу, которая:
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 2D
// пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



// int n = 12345;
// double res = Math.Sqrt(n);

// double n1 = 5.099985645;
// double nRound = Math.Round(n1, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xFirst, int yFirst, int xSecond, int ySecond)
{
    int distanceX = xFirst - xSecond;
    int distanceY = yFirst - ySecond;
    double hypotenuse = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
    return hypotenuse;
}
double distance = Distance (x1, y1, x2, y2);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(result);