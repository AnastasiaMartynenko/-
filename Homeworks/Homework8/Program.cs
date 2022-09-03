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
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] CreateFirstRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowFirst2dArray(int[,] array)
{
    {
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
        }
    }
}

int[,] CreateSecondRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowSecond2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
int[,] FindCompositionOfMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] composition  = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < composition.GetLength(0); i++)
        {
            for (int j = 0; j < composition.GetLength(1); j++)
            {
                composition[i, j] = matrix1[i, j] * matrix2[i, j];

            }
        }
        return composition;       
}
void ShowComposotion(int[,] array)
{
    {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
}
Console.Write("Input number of rows for the first matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns for the first matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for the first matrix: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value for the first matrix: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of rows for the second matrix: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns for the second matrix: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for the second matrix: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value for the second matrix: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myFirstArray = CreateFirstRandom2dArray(m, n, min, max);
ShowFirst2dArray(myFirstArray);
Console.WriteLine();

int[,] mySecondArray = CreateSecondRandom2dArray(k, l, min2, max2);
ShowSecond2dArray(mySecondArray);
Console.WriteLine();

int[,] matrixComposition = FindCompositionOfMatrixes(myFirstArray, mySecondArray);
ShowComposotion(matrixComposition);
*/
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
//Я просто создала трехмерный массив
int[,,] CreateRandom3DArray(int array1, int array2, int array3, int mint, int max) 
{
    int[,,] result = new int[array1, array2, array3];

    for (int i = 0; i < array1; i++)
    {
        for (int j = 0; j < array2; j++)
        {
            for (int k = 0; k < array3; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }

        }
    }

    return result;
}
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}
Console.Write("Input size for the first array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size for the second array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size for the third array: ");
int o = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[, ,] myArray = CreateRandom3DArray(m, n, o, min, max);
Show3DArray(myArray);


