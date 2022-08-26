//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int ShowCountEvenNumbers(int[] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
        count++;  
    }
    return count;
}
Console.Write("Input size for array: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(array_size);
ShowArray(myArray);
int count_even_numbers = ShowCountEvenNumbers(myArray);
Console.WriteLine($"The count of all even elements of array is {count_even_numbers}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindSumOddNumbers(int[] array)
{
  int sum = 0;
  
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0 || i % 2 < 0) 
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Input size for array: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(array_size, min, max);
ShowArray(myArray);
int sum_odd_numbers = FindSumOddNumbers(myArray);
Console.WriteLine($"Sum of all odd index elements of array is {sum_odd_numbers}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //когда я меняла int на double программа не срабатывала
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindDifBetweenMaxMin(int[] array)
{   
    
    int max_element = array[0];
    int min_element = array[0];
    int result;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max_element) max_element = array[i];
        if(array[i] < min_element) min_element = array[i];
        
    }
    result =  max_element - min_element;
    return result;
    
}   
Console.Write("Input size for array: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (array_size, min, max);
ShowArray(myArray);
int dif = FindDifBetweenMaxMin(myArray);
Console.WriteLine($"The difference between min and max elements is {dif}");
*/