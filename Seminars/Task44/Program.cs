// Не используя рекурсию, выведите первые N чиселФибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateFibonacciArray (int numb)
{
   int[] arr = new int[numb];
   arr[1] = 1;
   for (int i = 2; i < arr.Length; i++)
   {
        arr[i] = arr[i - 1] + arr[i -2];   
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

int[] array = CreateFibonacciArray(num);
PrintArray(array);
