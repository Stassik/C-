// Напишите программу, которая:
// 1. принимает на вход число
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int sum = 0;
    if (num < 0) num = num * (-1);
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int result = SumNumber(number);
Console.WriteLine($"Сумма цифр числа {number} равна {result}");