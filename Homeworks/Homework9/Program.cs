/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int sum = 0;
int FindSum(int a, int b)
{
    if(a <= b)
    {
        sum = a + sum;
        a++;
        FindSum(a, b);
    }
    return sum;
    
}
Console.WriteLine(FindSum(2, 7));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
/*
int Ackerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return Ackerman(m - 1, 1);
    else if(m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}
Console.WriteLine(Ackerman(2, 3));
*/
