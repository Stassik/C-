// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;
    int unit = 0;
    while (num > 0)
    {
        unit = num % 10;
        sum += unit;
        num /= 10;
        SumNumbers(num);
    }

    return sum;
}

int sumNumbers = SumNumbers(number);
Console.Write(sumNumbers);
