//Задача 1.  Напишите программу, которая перевернет одномерный массив (то есть просто запишет его задом-наперед: последний элемент будет на месте первого, первый элемент будет на месте последнего).
//Нам нужно создать метод, который будет менять элементы местами
/*

int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++) //i = array.Length / 2 - потому, что нам нужно дойти лишь до середины массива
    {
        int temp = array[i];//создаем переменную, чтобы с ее помощью менять местами элементы(первый и псоледний)
        array[i] = array[array.Length - 1 - i]; //то есть мы переставляем местами элементы начиная с послднего и продвигаясь на один вглубь массива
        array[array.Length - 1 - i] = temp;

    }
    return array;
} 
int[] CreateRandomArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

*/
//это был первый способ записи метода

//Теперь второй способ записи этого метода:
/*
int [] ReverseArray(int[] array)
{
    for(int i = 0, j= array.Length - 1; i < j; i++, j--)
//мы можем сделать так, чтобы у нас был второй индекс, который будет отвечать за элементы, который будут идти из конца в начало
//за элементы, который идут из начала в конец будет отвечать индекс i
//а за элементы, которые будут идти из конца в начало будет отвечать индекс j
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (size, min, max);
ShowArray(myArray);
ShowArray(ReverseArray(myArray));
*/
// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длинны
//a < b + c

/*
bool CheckTriangle(int a, int b, int c)
{
    bool result = true;
    if(a < b + c || b < a + c || c < a + b)
    {
        return result;
    }
    else return false;
}
Console.WriteLine($"Input first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input third side: ");
int c = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle(a,b,c)) Console.WriteLine ("It is a triangle");
else Console.WriteLine ("It is not a triangle");
*/
//Задача 2. (та же самая). Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длинны
/*l CheckTriangle(int a, int b, int c)
{ 
    if((a < b + c) && (b < a + c) && (c < a + b )) return true;
    else return false;
}

Console.WriteLine($"Input first side: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input second side: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input third side: ");
int z = Convert.ToInt32(Console.ReadLine());
bool result = CheckTriangle(x, y, z);
if (result == true) Console.WriteLine($"Triangle with sides: {x}, {y}, {z} exists");
else Console.WriteLine($"Triangle with sides: {x}, {y}, {z} doesn't exist");
*/

//Задача 3.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void Fibonachchi (int n, int a, int b)
{
    Console.Write($"{a} {b} ");
    int fib = a + b;
    int fib2 = b;
    int fib3 = 0;
    for (int i = 0; i <= n; i++)
    {
        Console.Write($"{fib} ");
        fib3 = fib + fib2;
        fib2 = fib;
        fib = fib3;
    }

}
Console.Write("Введи сколько цифр надо: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи первое число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Fibonachchi(n, a, b);
*/
//Задача 3.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] FindFibbonachi(int size, int firstNumber, int secondNumber) //на вход берем три числа:первое, второе и размер

{
    int[] array = new int[size];  // создаем переменную и кладем туда некий массив
    array[0] = firstNumber; //первые два числа будут постоянными
    array[1] = secondNumber;//эти числа мы запросим у пользователя
    for(int i = 2; i < size; i++)//поэтому счетчик начнем с 3го элемента под вторым индексом
    {
       array[i] = array[i - 2] + array[i - 1];//то есть начиная с третьего элемента мы каждыы последующий записываем как сумму двух предыдущих
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine($"Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());
ShowArray(FindFibbonachi(length, x, y));
*/
//Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
void DecimalToBinary (int number)
{
    string result = String.Empty;//мы хотим наше число в двоичной системе записать срокой, поэтому создаем переменную string result
                                 //и помещаем туда пустую строку. Когда у нас в цикле посчитается это число из десятичной системы в двоичную,
                                 //то мы запишем это в нашу пока еще пустую строку. И так после каждого прохода цикла образуется строка с цифрами.
    while(number > 0)
    {                                    //мы должны были написать result + number % 2, но сделали наоборот, потому что в конкатенации (соединении)
       result = number % 2 + result;     // перестановка слагаемых имеет значение. Т.к. в двоичной системе остаток записывается с конца, то мы должны
       number = number / 2;              //развернуть нашу строку и записать с конца, поэтому и меняем местами слагаемые result и number % 2 
    }    
    Console.WriteLine(result);     //метод void поэтому мы прям в методе и можем его записать                 
}
Console.WriteLine($"Input a number: ");//но нам все равно нужно вызвать метод и попросить пользователя ввести исходное число
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Number {num} to binary is ");
DecimalToBinary(num);
*/