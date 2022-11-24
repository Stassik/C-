//Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text1, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text1[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text1[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);


int[] array = { 10, 4, 8, 7, 2, 3, 6, 4, 2, 5 };

void PrintArray(int[] array1)
{
    int count = array1.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array1)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);