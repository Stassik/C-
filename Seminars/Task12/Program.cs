// Напишите программу, которая будет:
// 1. принимать на вход два числа 
// 2. выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

                                                                        // Мой Вариант решения
// void CheckingMultiplicity(int numb1, int numb2)
// {
//     int quotient = numb1 % numb2;
//     if (quotient == 0) Console.WriteLine($"Число {numb1} кратно числу {numb2}");
//     else Console.WriteLine($"Число {numb1} не кратно числу {numb2}. Остаток равен {quotient}");
// }

// CheckingMultiplicity(num1, num2);

                                                                    // Первый вариант решения на семинаре

// bool CheckingMultiplicity(int numb1, int numb2) 
// {
//     if (numb1 % numb2 == 0) return true;
//     return false;
// }
// bool result = CheckingMultiplicity (num1, num2);
// Console.WriteLine(result ? $"Число {num1} кратно числу {num2}" : $"Число {num1} не кратно числу {num2}. Остаток равен {num1 % num2}");

                                                                     // Второй вариант решения на семинаре

int CheckingMultiplicity(int numb1, int numb2) {
    return numb1 % numb2;
}
int result = CheckingMultiplicity (num1, num2);
Console.WriteLine(result == 0 ? $"Число {num1} кратно числу {num2}" : $"Число {num1} не кратно числу {num2}. Остаток равен {result}");



