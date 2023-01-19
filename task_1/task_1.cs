Console.WriteLine("Задача 1: Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
Console.WriteLine("Введите число от 1 до 7");
int day = int.Parse(Console.ReadLine()!);
if (day > 7 | day < 1) 
{
    Console.WriteLine("Введено некорректное число");
}

else if (day == 6 | day == 7)
{
    Console.WriteLine("Этот день - выходной");
}
else 
{
    Console.WriteLine("Этот день - точно не выходной");
}

