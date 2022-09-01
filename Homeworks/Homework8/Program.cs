/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
int[,] MakeBubbleSort (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
            { 
                for (int current = j + 1; current < array.GetLength(1); current++)
                {
                    if (array[i, current] > array[i, j ])
                    {
                        int tmp = array[i, j];
                        array[i, j] = array[i, current ];
                        array[i, current ] = tmp;
                    }
                }
            }
            Console.WriteLine();
    return array;
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine();

MakeBubbleSort(myArray);
Show2dArray(myArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
void ShowMinSumOfElementsInRow(int[,] array)
{
    int minSum = 0;
    int minSumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
       minSum = array[0, j] + minSum;
       for (int i = 0; i < array.GetLength(0); i++)
       {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {  if(i == 0)
              {sum = array[i, j] + sum;
               minSum = sum;
               minSumRow = i;
              }
              else 
              {
                sum = array[i, j] + sum;
              }
        }
           if (sum < minSum)
           {
            minSum = sum;
            minSumRow = i;
           }
       }Console.WriteLine($"Min sum of elements is {minSum} and it's located on the {minSumRow + 1} row");
    }

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine();

ShowMinSumOfElementsInRow(myArray);
