// Напишите программу, которая
// 1. принимает на вход пятизначное число 
// 2. проверяет, является ли оно палиндромом.

// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;

    if ((num1 == num5) && (num4 == num2)) return true;
    return false;

}

if ((number > 9999) && (number < 100000))
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? $"Число является палиндромом" : $"Число НЕ является палиндромом.");
}
else
{
    Console.WriteLine("Введено неверное число.");
}



