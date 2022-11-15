void FillArray(int[] collection) // Задаем функцию, аргументом функции является массив
{
    int length = collection.Length;
    int index = 0;

    while (index < length) {
        collection[index] = new Random().Next(1, 10); // Добавим рандомное число от 1 до 10
        Console.WriteLine(collection[index]);         //в массив на позицию текущего индекса
        index++;                                      
    }
}

// void PrintArray(int[] col) 
// {
//     int count = col.Length;
//     int position = 0;

//     while (position < count) {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

int IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count) 
    {
        if (collection[index] == find) 
        {
            position = index;
            break;                       // Прерывание   
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Зададим массив из 10 элементов
FillArray(array);          // Вызываем функцию

Console.WriteLine();
int pos = IndexOf(array, 3);

Console.WriteLine(pos);



