// Напишите программу, которая:
// 1. по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть (от 1 до 4): ");
string quarterNumber = Console.ReadLine();

string Quarter (string quarter)
{
    if (quarter == "1") return "x > 0 и y > 0";
    if (quarter == "2") return "x < 0 и y > 0";
    if (quarter == "3") return "x < 0 и y < 0";
    if (quarter == "4") return "x > 0 и y < 0";
    return "Введены неверные данные";
}

string result = Quarter(quarterNumber);
Console.WriteLine(result);