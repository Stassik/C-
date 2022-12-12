﻿// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numM, int numN)
{
    if (numM > numN) return numM + SumNumbers(numM - 1, numN);
    if (numN > numM) return numM + SumNumbers(numM + 1, numN);
    return numM;
}

if (numberM <= 0 || numberN <= 0) Console.WriteLine(" Введите натуральные числа!");
else
{
    Console.WriteLine(SumNumbers(numberM, numberN));
}