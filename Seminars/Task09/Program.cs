// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] --> {number}");

// int firstDigit = number / 10;           // Находим первую цифру числа
// int secondDigit = number % 10;          // Находим вторую цифру числа

// if (firstDigit > secondDigit) {
//     Console.WriteLine($"Наибольшая цифра числа {number} --> {firstDigit}");
// }else {
//     Console.WriteLine($"Наибольшая цифра числа {number} --> {secondDigit}");
// }

int MaxDigit(int num)
{
    int firstDigit = num / 10;           // Находим первую цифру числа
    int secondDigit = num % 10;          // Находим вторую цифру числа

    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;

    return firstDigit > secondDigit ? firstDigit : secondDigit; // Тернарные операторы. ? - тогда, : - иначе
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} --> {maxDigit}");
