//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int[] CreateNewArray(int size)
{
int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a number: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        count++;
    }
   return count;
}
Console.Write("Input size for array of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateNewArray (size);
ShowArray(myArray);

int positive_numbers = FindPositiveNumbers(myArray);
Console.WriteLine($"There are {positive_numbers} positive numbers");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Сначала надо сократить эти формулы y = k1 * x + b1, y = k2 * x + b2;
// y = k1 * x + b1, y = k2 * x + b2 
// k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)
//y = k1 * x + b1

void FindCrossingPoint (double b1, double k1, double b2, double k2) // это координаты, которые мы будем просить пользователя ввести
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
    if(k1 ==k2)
    Console.WriteLine($"Lines do not intersect");
    else
    Console.WriteLine($"The crossing points are: {x} and {y}");
}
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

FindCrossingPoint(k1, b1, k2, b2);

