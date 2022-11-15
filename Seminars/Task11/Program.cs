// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число --> {number}");

// int firstDigit = number / 100; //Определяем первую цифру трехзначного числа
// int thirdDigit = number % 10; // Определяем третью цифру трехзначного числа

// Console.WriteLine($"Первая цифра --> {firstDigit}");
// Console.WriteLine($"Третья цифра --> {thirdDigit}");

// string first = Convert.ToString(firstDigit);
// string second = Convert.ToString(thirdDigit);

// int newNumber = Convert.ToInt32(first + second);
// Console.WriteLine(newNumber);


int Mixed(int num)
{
    Console.WriteLine($"Случайное трехзначное число --> {number}");
    int firstDigit = num / 100; //Определяем первую цифру трехзначного числа
    int thirdDigit = num % 10; // Определяем третью цифру трехзначного числа

    // string first = Convert.ToString(firstDigit);
    // string second = Convert.ToString(thirdDigit);

    // int newNum = Convert.ToInt32(first + second);

    int newNum = firstDigit * 10 + thirdDigit;
    return newNum;

}

Console.WriteLine(Mixed(number));