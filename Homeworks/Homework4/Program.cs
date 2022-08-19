//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int FindNumberInDegree (int a, int b)
{
    int result = 1; //т.к. мы умножаем, а не складываем
    for(int i = 1; i <= b; i++) //i - это счетчик нашего цикла
    {
       result = result * a;
    }
    
    return result;
}
Console.Write("Input an intenger number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree in which you want to raise the number : ");
int user_degree = Convert.ToInt32(Console.ReadLine());

int final_result = FindNumberInDegree(user_number, user_degree);
Console.WriteLine($"{user_number} in degree of {user_degree} equals {final_result}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int FindSum (int number)
{
   int sum = 0;
   for(int current = 0; current <= number; current++)
   sum = current + sum;
   return sum;
}
Console.Write("Input an intenger number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int sum_of_digits = FindSum(user_number);
Console.WriteLine($"Sum of all digit from {user_number} is {sum_of_digits}");
*/

