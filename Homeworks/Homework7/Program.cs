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

