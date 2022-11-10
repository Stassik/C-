// Приветствие
Console.WriteLine("Здравствуйте! Пожалуйста представьтесь.");
string username = Console.ReadLine();

// Сложение двух чисел

/*
    Console.WriteLine(username + ", чтобы произвести сложение, Вам необходимо ввести два числа");
    Console.WriteLine("Введите первое число.");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число.");
    int secondNumber = int.Parse(Console.ReadLine());
*/
int firstNumber = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Первое число - " + firstNumber);
int secondNumber = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Второе число число - " + secondNumber);
Console.WriteLine("Сумма чисел равна " + (firstNumber + secondNumber));

// Деление двух чисел

/*
    Console.WriteLine(username + ", чтобы произвести деление, Вам необходимо ввести два числа");
    Console.WriteLine("Введите числитель.");
    double firstNumberDel = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите знаменатель.");
    double secondNumberDel = int.Parse(Console.ReadLine());
*/
double firstNumberDel = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Числитель - " + firstNumberDel);
double secondNumberDel = new Random().Next(1, 10); // 1, 2, 3 ... 9
Console.WriteLine("Знаменатель - " + secondNumberDel);
Console.WriteLine("Частное двух чисел равно " + (firstNumberDel / secondNumberDel));
