Console.Clear(); // Отчистка консоли


// Зададим переменные (координаты трех точек)

int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //Будем рисовать, аргументы (отступ от левого края(количество символов), отступ от верхнего края(количество строк))
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 100000) {
    int what = new Random().Next(0, 3); //числа 0, 1, 2
    if (what == 0) {
        x = (x + xa)/2; // находим середину отрезка
        y = (y + ya)/2;
    };
    if (what == 1) {
        x = (x + xb)/2;
        y = (y + yb)/2;
    };
    if (what == 2) {
        x = (x + xc)/2;
        y = (y + yc)/2;
    };

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++ ;
};
