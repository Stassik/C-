// Напишите программу, которая:
// 1. принимает на вход три числа 
// 2. проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число (сторона треугольника 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (сторона треугольника 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число (сторона треугольника 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Check (int numA, int numB, int numC)
{
    if ((numA < (numB + numC)) && (numB < (numA + numC)) && (numC < (numA + numB))) return true;
    return false;
}


if ((num1 <= 0) || (num2 <= 0) || (num3 <= 0)) 
{
    Console.WriteLine("Вы ввели отрицательное число. Введите положительное число!.");
}
else {
    bool result = Check(num1, num2, num3);
    Console.WriteLine(result ? "Существует." : "Не существует.");
}
