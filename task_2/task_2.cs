Console.WriteLine("Задача 2: по двум заданным числам проверять является ли одно квадратом другого");
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

if (B == A*A)
{
    Console.WriteLine("Число " + B + " - является квадратом числа " + A);
}
else if (A == B*B)
{
    Console.WriteLine("Число " + A + " - является квадратом числа " + B);
}
else{
    Console.WriteLine("Ни " + A +" , ни " + B + " не являются квадратом друг друга");
}
