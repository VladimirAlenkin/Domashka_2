﻿Console.WriteLine("Задача 3: задать номер четверти, показать диапазоны для возможных координат");
Console.WriteLine("Задайте номер координатной четверти (от 1 до 4)");
int N = int.Parse(Console.ReadLine()!);
if ( N < 1 | N > 4)
{
    Console.WriteLine("Вы ввели некорректное число");
}
if ( N ==1 )
{
    Console.WriteLine("Возможные координаты: X ( 0; + ∞ ), Y ( 0; + ∞ )"); // не знаю как отобразить знак бесконечности
}
if ( N ==2 )
{
    Console.WriteLine("Возможные координаты: X ( 0; - ∞ ), Y ( 0; + ∞ )");
}
if ( N == 3 )
{
    Console.WriteLine("Возможные координаты: X ( 0; - ∞ ), Y ( 0; - ∞ )");
}
if ( N == 4 )
{
    Console.WriteLine("Возможные координаты: X ( 0; + ∞ ), Y ( 0; - ∞ )");
}