//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

                                                // Первый вариант решения                                               

Console.WriteLine("Введите число: ");                          
int lengthNumber = Convert.ToInt32(Console.ReadLine());

int CountNum (int lengthNumb)
{
    int count = 0;
    for (int i = 1; i <= lengthNumb; i++)
    {
        Console.Write($"Введите {i} число: ");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb > 0) count++;
    }
    return count;
}

if (lengthNumber > 0)
{
    int res = CountNum(lengthNumber);
    Console.WriteLine($"Количество чисел больше нуля среди введеных  - {res}");
}
else
{
    Console.WriteLine("Введите положительное число!");
}

                                                // Второй вариант решения

Console.Write("Введите число: ");                          // Сперва запрашиваем число (длину массива)
int lengthNum = Convert.ToInt32(Console.ReadLine());


int RequestNum(int length, int index)                      // Можно создать отдельный метод для получения чисел,
{                                                           // а после вызывать этот метод в методе генерации массива.
    Console.Write($"Введите {index + 1} число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int[] CreateArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        int numb = RequestNum(length, i);
        // Console.Write($"Введите {i + 1} число: ");              // <--или же запрашивать число в методе генерации массива
        // int numb = Convert.ToInt32(Console.ReadLine());         
        arr[i] = numb;
    }
    return arr;
}

int CountPositiveNum (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

if (lengthNum > 0)
{
    int[] array = CreateArray(lengthNum);
    PrintArray(array);
    int result = CountPositiveNum(array);
    Console.WriteLine($"В полученном массиве чисел больше нуля - {result}");
}
else
{
    Console.WriteLine("Введите положительное число!");
}


                                                 