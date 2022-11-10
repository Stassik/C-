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
