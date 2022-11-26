// Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

void InverseArray(int[] arrInv)
{
    for (int i = 0; i < arrInv.Length; i++)
    {
        arrInv[i] *= (-1); 
    }
}

void PrintInverseArray(int[] arrInv)
{
    Console.Write("[");
    for (int i = 0; i < arrInv.Length; i++)
    {
        if (i < arrInv.Length - 1) Console.Write($"{arrInv[i]}, ");
        else Console.Write($"{arrInv[i]}");
    }
    Console.WriteLine("]");
}



int[] array = CreateArray(5, -9, 9);
PrintArray(array);
InverseArray(array);
PrintInverseArray(array);
