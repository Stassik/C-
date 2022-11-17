// Напишите программу, которая:
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindThirdNumber(int num) {
    while ((num > 999) || (num < -999))
    {
       num = num / 10;
    }
    int threeDigit = num % 10;
    return threeDigit;
}

if ((number > 99))
{
    Console.WriteLine($"Третья цифра числа {number} --> {FindThirdNumber(number)}");
}
else if ((number < -99))
{
    Console.WriteLine($"Третья цифра числа {number} --> {FindThirdNumber(number) * (-1)}");
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}