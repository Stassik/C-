// Напишите программу, которая:
// 1. принимает на вход число 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Length(int num)
{   
    int count = 0;
    while(num != 0) {
        num = num / 10;
        count++;
    }
    return num == 0? 1 : count;
}

int result = Length(number);
Console.WriteLine(result);