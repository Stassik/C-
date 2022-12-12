// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N.

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


void NaturalNumbers(int numM, int numN)
{
    if (numM > 0 && numN > 0)
    {
        
        if (numM > numN)
        {
            Console.Write($"{numM} ");
            NaturalNumbers(numM-1, numN);
        }
        else if(numN > numM) 
        {
            Console.Write($"{numM} ");
            NaturalNumbers(numM+1, numN);
        }
        else
        {
            Console.Write($"{numM}");
            return;
        }
    }
    else
    {
        Console.WriteLine("Введите натуральное число!");
    }
}
NaturalNumbers(numberM, numberN);