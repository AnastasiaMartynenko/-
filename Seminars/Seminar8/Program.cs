//Задача1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
    Console.WriteLine();   
}
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))//если первая или вторая строка оказалась больше, чем возможно
      return array;//наш метод ничего не будет делать. Возвращаем весь массив, как и было изначально 
    else//если первая и вторая строка оказались меньше длин массивово, то начинаем менять их местами
    {
        for(int j = 0; j < array.GetLength(j); j++)
        {
            int temp = array[row1, j]; //переменная temp позволяет нам менять элементы местами, в нее мы положили первый элемент из необходимой строки)
            array[row1, j] = array[row2, j];//сюда кладем элемент из второй строки 
            array[row2, j] = temp;//теперь в элемент второй строки присваиваем элемент первой строки(что находится в temp)

        }
    }
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
myArray = ChangeRows(myArray, 0, m -1);//аргументы: массив, индекс первого элемента, индекс последнего элемента
Show2dArray(myArray); // выводим массив с уже поменяными местами элементами
*/
//Задача 2. Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//на вход - массив. на выход - массив.
//

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
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
      return array;
    else
    {
        for(int j = 0; j < array.GetLength(j); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;

        }
    }
    return array;
}
int[,] ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1;j < array.GetLength(1);j++)
        {
           int temp = array[i, j];
           array[i, j] = array[j, i];
           array[j, i] = temp;
        }
        

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

myArray = 
*/


//Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
//Задача 4. 
