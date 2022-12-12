// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ступень: ");
int stepNumber = Convert.ToInt32(Console.ReadLine());


int NumberStep (int num, int step)
{

    if (step > 0) return num * NumberStep(num, step -1 );
    return 1;
}

int newNumber = NumberStep(number, stepNumber);
Console.WriteLine($"Число {number} в степени {stepNumber} равно {newNumber}");