//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void FindPalindrome (int number)
{
    int five_digit_number = number;
    if(five_digit_number >= 10000 && five_digit_number <= 99999)
   {
    int first_digit = number /10000;
    int second_digit = (number % 10000) / 1000; 
    int forth_digit = (number % 100) / 10;
    int last_digit = number % 10;

        if(first_digit == last_digit && second_digit == forth_digit)
        {
            Console.WriteLine($"Number {number} is a palindrom");
        }
        else
        {
            Console.WriteLine($"It is not a palindrom");
        }             
    }
    else
    Console.WriteLine("It's not a five-digit number:) ");
}
Console.Write("Input a five-digit number: ");
int palindrom = Convert.ToInt32(Console.ReadLine());
FindPalindrome(palindrom);
*/

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
int ShowCubeTable (int n)
 {
    int current_number = 0; //Первое число, с которого начнет отсчет (начнем с нуля, например)
    int cube = current_number * current_number * current_number; //просто переменная куба числа


    while (current_number < n )
       {
            cube = current_number * current_number * current_number;
            Console.WriteLine($"The cube of {current_number} is {cube} .");
            current_number++;
        }
        return cube;
        
 }
Console.Write("Input any intenger number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCubeTable(number);//просто вставили метод(т.к. он у нас void)
*/