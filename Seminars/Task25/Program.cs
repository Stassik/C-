// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число степени: ");
int degree = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num, int dgr)
{
    int cnst = num;
    for(int i = 2; i <= dgr; i++)
    {
        num = num*cnst;
    }
    return num;
}
int result = Exponentiation(number, degree);
Console.WriteLine((degree>0) ? result : "Введите положительное число степени.");