// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void PrintRandomArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
        Console.Write($"{arr[i]} ");
    }
}
PrintRandomArray(array);


