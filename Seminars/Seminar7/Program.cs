//Двумерные массивы.

//Задача 1. Напишите программу. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray(int rows, int columns,int minValue, int maxValue)//создаем метод, который создаст двумерный массив рандомных чисел
{                                                                  //на вход принимаем 4 аргумента: строки, столбцы, мин значение и макс значение
   int[,] newArray = new int[rows, columns];//создаем переменную, где будем хранить массив
   
   for(int i = 0; i < rows; i++) //создаем первый цикл для строк, у этого цикла индекс(счетчик) - i
   {
      for(int j = 0; j < columns; j++)//создаем второй цикл для столбцов, у него индекс будет - j
      {
        newArray[i, j] = new Random().Next(minValue, maxValue + 1); //мы в элементы массива будем вставлять случайные числа в диапазоне от мин до макс


      }
   }
   return newArray;
}                                                            
//А сейчас создадим метод, который будет выводить наш массив на экран

void Show2dArray(int[,] array) //этот метод принимает на вход двумерный массив, который мы создали ранее
{
    for(int i = 0; i < array.GetLength(0); i++) // array.GetLength(0) - эта конструкция помогает обратиться к конкретному индексу строк
    {
        for(int j = 0; j < array.GetLength(1); j++)//array.GetLength(1) - эта конструкция помогате обратиться к конкретному индексу столбцов
        {
           Console.Write(array[i, j] + " "); //таким образом мы сможем выводить элементы массива поочереди через пробел
        }
        Console.WriteLine();//пустая строка
    }
}
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
*/
//Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Array ij = i+j. Выведите полученный массив на экран.
//На вход этот массив будеи брать строки и столбцы
/*
int[,] Create2dArray(int rows, int columns)
{
   int[,] newArray = new int[rows, columns];
   
   for(int i = 0; i < rows; i++) 
   {
      for(int j = 0; j < columns; j++)
      {
        newArray[i, j] = i + j;
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
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows, columns);
Show2dArray(myArray);
*/
//Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
//А сейчас создадим метод, который будет выводить наш массив на экран

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
int[,] ChangeElementsOfArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++) 
      for(int j = 0; j < array.GetLength(1); j++)
         if((i % 2 == 0) && (j % 2 == 0)) array[i, j] = array[i, j] * array[i, j];
      
   return array;
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
ChangeElementsOfArray(myArray);
Console.WriteLine();//пустая строка
Show2dArray(myArray);
*/
/*
//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
int SumOfElementsOfArray(int[,] array) 
{  int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++) 
     {
      for(int j = 0; j < array.GetLength(1); j++)
         if(i == j) 
         {
            sum = sum + array[i, j];
         }
      }
    return sum;
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
int sum = SumOfElementsOfArray(myArray);
SumOfElementsOfArray(myArray);
Console.WriteLine($"Sum of elements main diagonale is {sum}");
*/
//Задача 4. Второй способ решения. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
int SumOfElementsOfArray(int[,] array) 
{  int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
      sum = sum + array[i, i];
    }
      
   return sum;
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
int sum = SumOfElementsOfArray(myArray);
SumOfElementsOfArray(myArray);
Console.WriteLine($"Sum of elements main diagonale is {sum}");
