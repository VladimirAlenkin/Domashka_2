Console.WriteLine("Задача 4: найти расстояние между точками в пространстве 2D/3D");
Console.WriteLine("Выберите в какой системе будем искать расстояние (2D/3D). Введите 2 или 3.");
int N = int.Parse(Console.ReadLine()!);
if (N == 2)
{
    Console.WriteLine("Задайте координату X точки A");
    int X1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Y точки A");
    int Y1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату X точки B");
    int X2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Y точки B");
    int Y2 = int.Parse(Console.ReadLine()!);
    double result = MathF.Sqrt ((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1));
    Console.Write("Расстояние от точкт А до точки B равно: ");
    Console.Write(result);
}
if (N == 3)
{
    Console.WriteLine("Задайте координату X точки A");
    int X1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Y точки A");
    int Y1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Z точки A");
    int Z1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату X точки B");
    int X2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Y точки B");
    int Y2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Задайте координату Z точки B");
    int Z2 = int.Parse(Console.ReadLine()!);
    double result = MathF.Sqrt ((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1) + (Z2 - Z1)*(Z2 - Z1));
    Console.Write("Расстояние от точкт А до точки B равно: ");
    Console.Write(result);
}
if (N < 2 | N > 3)
{
    Console.WriteLine("Вы ввели неверное значение. Попробуйте ещё раз.");
}

