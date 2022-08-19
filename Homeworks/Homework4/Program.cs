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
    
    return result;d
}
Console.Write("Input an intenger number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree in which you want to raise the number : ");
int user_degree = Convert.ToInt32(Console.ReadLine());

int final_result = FindNumberInDegree(user_number, user_degree);
Console.WriteLine($"{user_number} in {user_degree} degree equals {final_result}");
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
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int maxValue, int minValue) 
{
int[] newArray = new int[8]; // в начале нам нужно выделить под массив память, т.е. создать ему переменную массива - int[] newArra
                                 // new int[8] - это мы создали новую переменную, в которой есть память типа int для восьми ячеек массива (восемь - size)
{
    for (int index = 0; index < size; index++)
    {
        Console.Write($"Input any element of array: ");
        newArray[index] = Convert.ToInt32(Console.ReadLine());//то, что введет пользователь мы положим в массив под index-ом
    }
    
    return newArray; //массив возвращаем без скобок
} 

}
void PrintArray(int[] array) //этот новый метод нужен для того, чтобы вывести на экран уже сгенерированный ранее массив.
{
    for(int index = 0; index < 8; index++) 
        Console.Write(array[index] + " "); // - этo нужно для того, чтобы вывести на экран все элементы массива через пробел
        Console.WriteLine(); // это нужно, чтобы напечатать пустую строку
}


Console.WriteLine("Input size for array you want to see: ");
int user_array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value for the elements: ");
int max_value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value for the elements: ");
int min_value = Convert.ToInt32(Console.ReadLine());

int[]our_last_array = CreateRandomArray(user_array_size, max_value, min_value); //создали новую переменню и положили туда метод

PrintArray(our_last_array); //возвращем void метод, с массивом в скобках
