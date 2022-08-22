//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
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
int DifferenceBetweenElements(int[] array, int max_element, int min_element)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
       result = max_element - min_element;
    }
    return result;
}
