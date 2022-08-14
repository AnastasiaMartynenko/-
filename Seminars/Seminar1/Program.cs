/*
//Задача 1
int num;
Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

/*
//Задача 2. Напишите программу, где ользователь должен ввести число, а программа напечатать квадрат этого числа.

int num;
Console.WriteLine("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

int square = num * num;

Console.WriteLine("The square of " + num + " is " + square);
Console.WriteLine($"The square of {num} is {square}");
*/

/*
//Задача 3. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square2 = number2 * number2;

if(number1 == square2)
{
    Console.WriteLine($"{number1} is a quarde of {number2}");

}
else
{
    Console.WriteLine($"{number1} is not a square of {number2}");
}
*/

/*
// Задача 4. Напишите программу, которая на вход принимает одно число (n), а на выходе показывает все целые числа в промежутке отрицательной версии этого числа до самого этого числа.

Console.Write("Input an integer positive number: ");

int number = Convert.ToInt32(Console.ReadLine());

int current = number * - 1;

while (current <= number)
{
    Console.Write(current + " ");
    current++;
}

*/

// Задача 5. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three digit number: ");

int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number % 10;
Console.WriteLine($"The last digit of {number} is {last_digit}");
*/



