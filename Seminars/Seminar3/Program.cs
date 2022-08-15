//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void FindCooardinats (int quarter)
{
   if(quarter == 1) 
   Console.WriteLine("Диапазон (х+, y+)");
   if(qquarter == 2)
   Console.WriteLine("Диапазон (х-, y+)");
   if(quarter == 3)
   Console.WriteLine("Диапазон (х-, y-)");
   if(quarter == 4)
   Console.WriteLine("Диапазон (х+, y-)");
}
Console.Write("Input number of quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());
FindCooardinats(quarter);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double FindDistance (double x1, double y1, double x2, double y2)
{

   return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)); 
  

}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistance(xa, xb, ya, yb);
Console.WriteLine($"Distance is {coordinate}");
*/
//Задача №4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.
/*
void ShowSquare (int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Квадрат числа {current} = {current * current}");
        current++;
    }

}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquare(number);
*/