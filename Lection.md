# Лекция 1. Знакомство с языком программирования С#
> В конце 90-х - начале 00-х Microsoft решила конкурировать с Sun microsystems и её набиравшим популярность языком Java. Аналогом платформы Java RE стала платформа Dot.net, а соперником языка Java — язык С#. На старте С# очень многое взял из других языков, например, из С++ и Java, поэтому они очень похожи. Однако позднее, уже Java, начала многое заимствовать у С#.  

`dotnet new console` – создать новый проект  
`dotnet run` – запустить проект

## Синтаксис
`//` - комментарии к коду;  
`Console.` - обращение к консоли;   
`WriteLine()` - вывод данных в консоли с переносом на новую строку;   
`Write()` - вывод данных в консоли в одну строку;   
`ReadLine()` - cчитать строку из терминала;   
`new Random().Next(мin, маx)` - случайное целое число от min до max-1.

Пример кода:
```C#
// Приветствие
Console.Write("Здравствуйте! Пожалуйста представьтесь.");
string username = Console.ReadLine();
Console.WriteLine("Очень приятно, "+ username + " !"); 

// Сложение двух чисел
int firstNumber = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Первое число - " + firstNumber);

int secondNumber = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Второе число число - " + secondNumber);

Console.WriteLine("Сумма чисел равна " + (firstNumber + secondNumber));

// Деление двух чисел
double firstNumberDel = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Числитель - " + firstNumberDel);

double secondNumberDel = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Знаменатель - " + secondNumberDel);

Console.WriteLine("Частное двух чисел равно " + (firstNumberDel / secondNumberDel))
```

### Типы данных

**string** - строки;   
**int** - целые числа;   
**double** - вещественные числа;   
**bool** - логический тип данных (либо истина, либо ложь);

### Операторы для арифметических действий в С#   
**+** - сложение;   
**-** - разность;   
__*__ - произведение;      
**/** - деление;   
**%** - нахождение остатка;   
**()** - классические скобки, которые могут менять приоритет операций.   

# Лекция 2. Знакомство с функциями и массивами
## Функции (методы)
Примеры функций:  
1. Next(1, 10);
2. WriteLine("Привет")
>**Функция** - это подпрограмма, которая получает входные аргументы и выдает результат.   

У каждой функции есть:   
* индентификатор (имя);
* может иметь входные аргументы;
* может возвращать значение.
>Некоторые функции могут и не возвращать значение (`void`). Такие функции называются **процедурами**.

Общее описание функции:  
```C#
ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ТипДанных2 ИмяАргумента2...])
{
    Тело Метода
    return ЗначениеСоответствующееЗаданномуТипуДанных
}
```
Например:
```C#
// f(x) = x^2 + 1

double f(double x) 
{
    double result = x * x + 1; //Тело Метода
    return result
}
```

## Массивы
Общее описание массива:   
```C#
ТипДанных имя = {Значение1, Значение2, ...};
int[] array = {9, 38, 1, 32, 1990};

int[] array = {0, 0, 0, 0, 0};
int[] array = new int[5];
int[] array = new int[]{0, 0, 0, 0, 0};
int[] array = new int[5]{1, 0, 2, 0, 3};
```
Например:
```C#
//             0  1  2  3  4  5  6  7  8
int[] array = {1, 2, 3, 2, 5, 8, 7, 1, 2}; // Задаем массив
array[0] = 12;                             // Задаем значение элементу с индексом 0

int n = array.Length;                      // Определяем длинну массива
```
# Лекция 3. Функции: продолжение
## Виды функций (методов)
1. Ничего не принимают и ничего не возвращают
```C#
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();
```
2. Что-то принимают и ничего не возвращают;
```C#
                                //Первый вариант
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Автор ...");

                                //Второй вариант
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count>)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Автор ...", count: 4);
```
3. Ничего не принимают и что-то возвращают;
```C#
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
```
4. Что-то принимают и что-то возвращают.
```C#
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "Автор ...");
Console.WriteLine(res);
```
## Цикл `for`
```C#
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```
>Возможно использовать цикл в цикле.
```C#
for(int i = 2; i <= 10; i++)
{
   for(int j = 2; j <= 10; j++)
   {
    Console.WriteLine($"{i} x {j} = {i*j}");
   }
   Console.WriteLine(); 
}
```

# Лекция 4. Двумерные массивы. Рекурсия
Двумерные массивы задаются:
```C#
string[,] table = new string[2, 3];
int[,] matrix = new int[2, 3];

// , указывает на то что будет две размерности (строки и столбцы)
// первое число - количнство строк
// второе число - количество столбцов
```
Для того чтобы обратиться к нужному элементу необходимо указать строку и столбец.
Например:
```C#
string[,] table = new string[2, 3];
table[1, 2] = "слово";
```
Для получения количества строк и столбцов массива используют метод `.GetLength()`.  
В качестве параметра передается 0, если необходимо получить количество строк, и 1, если необходимо получить количество столбцов.
