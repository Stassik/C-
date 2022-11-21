// Напишите программу, которая:
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


string Square(int number)
{
    int count = 1;
    string table ="";
    while (count <= number)
    {
        table = table + $"{count}   {count*count}\n";
        count++;
    }
    return table;
}

Console.WriteLine(Square(num));



// void Square (int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         Console.WriteLine($"{i}   {i*i}");  
//     }
// }
// Square(num);