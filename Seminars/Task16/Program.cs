// Напишите программу, которая
// 1. принимает на вход два числа
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    if ((num1 == num2 * num2) || (num2 == num1 * num1)) return true;
    return false;
}

bool result = Square(number1, number2);
Console.WriteLine(result ? $"Одно число является квадратом второго" : $"Одно число НЕ является квадратом второго.");