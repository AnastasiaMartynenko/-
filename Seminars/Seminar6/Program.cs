// Задача 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
//a < b + c
/*
bool CheckTriangle(int a, int b, int c)
{
    bool result = true;
    if(a < b + c || b < a + c || c < a + b)
    {
        return result;
    }
    else return false;
}
Console.WriteLine($"Input first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input third side: ");
int c = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle(a,b,c)) Console.WriteLine ("It is a triangle");
else Console.WriteLine ("It is not a triangle");
*/
//Задача 2.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void Fibonachchi (int n, int a, int b)
{
    Console.Write($"{a} {b} ");
    int fib = a + b;
    int fib2 = b;
    int fib3 = 0;
    for (int i = 0; i <= n; i++)
    {
        Console.Write($"{fib} ");
        fib3 = fib + fib2;
        fib2 = fib;
        fib = fib3;
    }

}
Console.Write("Введи сколько цифр надо: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи первое число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Fibonachchi(n, a, b);

*/