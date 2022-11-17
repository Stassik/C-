// Напишите программу, которая^
// 1. принимает на вход трёхзначное число 
// 2. на выходе показывает вторую цифру этого числа. 

// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberModification(int num)
{
    int result = (num / 10) % 10;
    return result;
}

if (((number > 99)&&(number < 1000))) 
    {
        Console.WriteLine($"Вторая цифра трехзначного числа --> {NumberModification(number)}"); 
    }
else if ((number > -1000)&&(number < -99)) 
    {
        Console.WriteLine($"Вторая цифра трехзначного числа --> {NumberModification(number) * (-1)}"); 
    }
else 
    {
        Console.WriteLine("Неверное число!");
    }
    

