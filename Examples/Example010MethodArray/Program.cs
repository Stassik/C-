int[] array = {1, 26, 30, 94, 65, 16, 77, 84};

int n = array.Length;
Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (index < n)
{
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    };

    index++;
}