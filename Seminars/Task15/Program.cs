// Напишите программу, которая:
// 1. принимает на вход цифру, обозначающую день недели
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

bool DayWeek( int day) {
    if (day >= 6) return true;
    return false;
}

bool result = DayWeek(dayWeek);

if ((dayWeek > 0) && (dayWeek <= 7)) 
{
    Console.WriteLine(result ? $"Выходной!" : "Рабочий!");
}
else {
    Console.WriteLine("Неверное число.");
}

