/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{ double[,] newArray = new double[rows, columns];
   
   for(int i = 0; i < rows; i++) 
   {
      for(int j = 0; j < columns; j++)
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();;//без этой дополнительной пристройки не будет работать
      }
   }
   return newArray;
}  
void Show2dArray(double[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}                               
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нeт. Тут говорится, что элемента с позициями[1, 7] нет, типа элемента, который расположен в первой строке
и 7 столбце, очевидно у нас в примере нет 7го столбца. Т.е. нам надо попросить пользователя ввести номер строки, а потом номер столбца. И найти
элемент по этим двум индексам. Если элемента нет, то пишем "такого элемента нет", а если есть, то обратимся к нему напрямую. 
*/
/*
int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{ int[,] newArray = new int[rows, columns];
   
   for(int i = 0; i < rows; i++) 
   {
      for(int j = 0; j < columns; j++)
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return newArray;
}  
void Show2dArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}                               
void FindElementByCoordinats (int[,] array, int indexOfRow, int indexOfColumn)
{
  if(indexOfRow > array.GetLength(0) || indexOfColumn > array.GetLength(1)) 
   {
     Console.WriteLine($"This element doesn't exist.");
   }
   else 
   Console.WriteLine($"{array[indexOfRow - 1, indexOfColumn - 1]} is the element of array under your coordinates");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input position of the row: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position of the column: ");
int column1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
FindElementByCoordinats(myArray, row1, column1);
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{ int[,] newArray = new int[rows, columns];
   
   for(int i = 0; i < rows; i++) 
   {
      for(int j = 0; j < columns; j++)
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return newArray;
}  
void Show2dArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}         
void FindColumnsAVG (int[,] array) 
{
   int count = array.GetLength(1);
   int sum = 0;
   int avg = sum / count;
    
      for(int j = 0; j < array.GetLength(1); j++)
      {
         for (int i = 0; i < array.GetLength(0); i++)
         {
            sum = sum + array[0, j];
         }
         avg = sum / count;
        
      }
      Console.WriteLine($"Average number of elements of that column is {avg}");
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
FindColumnsAVG(myArray);
*/
//Второй способ решения, но тоже не получается ничего

  int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)
{ 
   int[,] newArray = new int[rows, columns];
   for(int i = 0; i < rows; i++) 
   {
      for(int j = 0; j < columns; j++)
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return newArray;
}  
void Show2dArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}   
void FindColumnAVG ([]int array)
{
   int count = 1;
   int sum = 0;
   for (int current = 0; current < count; current++)
   {
      sum = sum + current;
      int avg = sum / count;
      count++;
   }
   Console.WriteLine($"Average of numbers in that column is {sum / count}");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
FindColumnAVG(myArray);
