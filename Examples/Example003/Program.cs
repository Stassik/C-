Console.WriteLine("Здравствуйте! Пожалуйста представьтесь.");
string username = Console.ReadLine();
Console.WriteLine(username + ", чтобы произвести сложение, Вам необходимо ввести два числа");
Console.WriteLine("Введите первое число.");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма введенных чисел равна " + (firstNumber + secondNumber));
