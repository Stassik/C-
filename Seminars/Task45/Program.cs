// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(sizeArray, minNum, maxNum);
PrintArray(arr);

int[] arrCopy = CopyArray(arr);
PrintArray(arrCopy);
