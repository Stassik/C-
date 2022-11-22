// Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    int distanceX = xc1 - xc2;
    int distanceY = yc1 - yc2;
    int distanceZ = zc1 - zc2;
    double hypotenuse = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
    return hypotenuse;
}
double distance = Distance (x1, y1, z1, x2, y2, z2);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(result);