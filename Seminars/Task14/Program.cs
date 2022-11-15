//     Напишите программу, которая:
// 1. принимает на вход число 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num) 
{
    if ((num % 7 == 0)&& (num % 23 == 0)) return true;
    return false;
}

bool result = Multiplicity(number);
Console.WriteLine(result ? $"Число {number} кратно и 7 и 23" : $"Условие не выполняется.");