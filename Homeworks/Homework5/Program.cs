//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
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

void FindMaxMinElements (int[] array)
{
    int max_element = 0;
    int min_element = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(max_element > array[i])
           {
            max_element = array[i];
           }
           if(min_element < array[i])
           {
            min_element = array[i];
           }
    
    }
    Console.WriteLine($"Max element of array is {max_element}");
    Console.WriteLine($"Min element of array is {min_element}");
}   

int FindDifferenceBetweenMaxMin(int[] array, int max_element, int min_element)
{   
    int result;
    for (int i = 0; i < array.Length; i++)
    {
        result = max_element - min_element;

    }
    return result;
}   



Console.Write("Input size for array: ");
int user_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(user_size, min, max); 
ShowArray(myArray);
FindMaxMinElements(myArray);

int dif = FindDifferenceBetweenMaxMin(myArray, min1, max1);
Console.WriteLine($"Difference between {max1} and {min1} is {dif}");
