// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32 (Console.ReadLine());

if ((number1 == number2) && (number2 == number3)) { //Если все числа равны
    Console.WriteLine("Числа равны!");
} else {

    if (number1 > number2) {
        if (number1 > number3) {
            Console.WriteLine("Первое число является максимальным!");
        } else if (number1 < number3){
            Console.WriteLine("Третье число является максимальным!");
        } else {
            Console.WriteLine("Первое и третье числа являются максимальными!"); //Если первое и третье числа равны
        }

    } else if (number1 < number2) {
        if (number2 > number3) {
            Console.WriteLine("Второе число является максимальным!");
        } else if (number2 < number3) {
            Console.WriteLine("Третье число является максимальным!");
        } else {
            Console.WriteLine("Второе и третье числа являются максимальными!"); //Если второе и третье числа равны
        }

    } else {                                                       //Если первое и второе числа равны 
        if (number1 > number3) {
            Console.WriteLine("Первое и второе числа являются максимальными!");
        } else {
            Console.WriteLine("Третье число является максимальным!");
        }
    }
}    