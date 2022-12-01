// Напишите программу, которая:
// 1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

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

int[] CreateArray(int num)
{
    int count = 0;
    int num1 = num;
    while (num1 > 0)
    {

        num1 /= 2;
        count++;

    }

    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[arr.Length - i - 1] = num % 2;
        num = num / 2;
    }
    return arr;
}

int[] array = CreateArray(numb);
PrintArray(array);
