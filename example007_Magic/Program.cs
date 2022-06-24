﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya; //y = xb;
int count = 0;

int what = 0;
int color = 0;

while (count < 20000)
{
    //int what = new Random().Next(0, 3);
    what = new Random().Next(0, 3);

    if (what == 0) // выбираем срединную точку
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
    
    if ((count % 100) != 0) // меняем цвет текста случайным образом каждые сто итераций
    {
        color = new Random().Next(1, 15);
        Console.ForegroundColor = (ConsoleColor)color;
    }

Console.SetCursorPosition(1, yb);

}
// В итоге получается фрактальная фигура, т.н. треугольник Серпинского