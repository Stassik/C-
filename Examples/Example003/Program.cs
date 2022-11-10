// Приветствие
Console.WriteLine("Здравствуйте! Пожалуйста представьтесь.");
string username = Console.ReadLine();

// Сложение двух чисел
Console.WriteLine(username + ", чтобы произвести сложение, Вам необходимо ввести два числа");
Console.WriteLine("Введите первое число.");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма введенных чисел равна " + (firstNumber + secondNumber));

// Деление двух чисел

Console.WriteLine(username + ", чтобы произвести деление, Вам необходимо ввести два числа");
Console.WriteLine("Введите числитель.");
double firstNumberDel = int.Parse(Console.ReadLine());
Console.WriteLine("Введите знаменатель.");
double secondNumberDel = int.Parse(Console.ReadLine());
Console.WriteLine("Частное чисел равна " + (firstNumberDel / secondNumberDel));
