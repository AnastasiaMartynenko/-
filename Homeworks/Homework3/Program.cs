//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

}

Console.Write("Input x1: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double zB = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance is {coordinate}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void ShowCubeTable (int n)
{
    int current_number = 0; //Первое число, с которого начнет отсчет (начнем с нуля, например)
    int cube; //просто переменная куба числа


    while(current_number < n || current_number <0)
       {
            cube = current_number * current_number * current_number;
            Console.WriteLine($"The cube of {current_number} is {cube} .");
            current_number++;
        }
}
Console.Write("Input any intenger number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCubeTable(number);//просто вставили метод(т.к. он у нас void)
*/
