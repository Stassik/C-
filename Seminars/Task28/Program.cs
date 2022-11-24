// Напишите программу, которая:
// 1. принимает на вход число N
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiplication(int num)
{
    int multiple = 1;
    for(int i = 1; i <= num; i++)
    {
        multiple = multiple * i;
    }
    return multiple;
}

int result = Multiplication(number);
Console.WriteLine((number > 0) ? result : $"Введите натуральное число");