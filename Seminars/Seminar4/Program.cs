// Задача 1. Напишите программу, которая на вход принимает какое-то число и возвращает сумму всех чисел от единицы до этого числа.
/*
int FindSum(int number)
{
  int sum = 0;
  
  for(int current = 1; current <= number; current++)
  {
    sum = sum + current;
  }
  return sum;
}
Console.Write("Input an integer number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int sum_of_all_numbers = FindSum(user_number);
Console.WriteLine(sum_of_all_numbers);
Console.WriteLine($"sum of numbers from 1 to {user_number} is {sum_of_all_numbers}"); // - или еще можно вывысти так 
*/
//Задача 2. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
/*
int ShowDigits (int number)
{ int current = 0;
  while(number > 0)
  {
      number = number / 10;
      current++;
  }
  return current;
}

Console.Write("Input a number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int count_of_digits = ShowDigits(user_number);
Console.WriteLine($"{user_number} contains {count_of_digits}");
*/

//Задача 3. Напишите программу, которая принимает на вход число N и выдает произведение всех чисел от 1 до N.
/*
int FindFactorial (int number)
{
  int N = number;
  int factorial = 1;
  for(int current = 1; current <= N; current++)
  {
    factorial = factorial * current;
  }
  return factorial;
}
Console.Write("Imput a number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int composion = FindFactorial(user_number);
Console.WriteLine($"Factorail of {user_number} is {composion}");
*/

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) // Значения даже в рандомном массиве, все равно должны ограничиваться какими-то пределами, поэтому берем minValue и maxValue
{
int [] newArray = new int[size]; // в начале нам нужно выделить под массив память, т.е. создать ему переменную 
                                 // new int[size] - это мы создали новую переменную, в которой есть память под определенное количество ячеек массива
for (int i = 0; i < size; i++) // здесь мы пишем цикл, 
    newArray[i] = new Random().Next(minValue, maxValue + 1); //maxValue + 1 - это крайний и самый большой элемент массива; пишем + 1, т.к. индексация массива начинается с нуля
    return newArray;// массив возвращаем без каких-либо скобок.
}
void ShowArray(int[] array) //этот новый метод нужен для того, чтобы вывести на экран уже сгенерированный ранее массив.
{
    for(int i = 0; i < array.Length; i++) // array.Lenght - т.к. мы не знаем крайнего элемента массива
        Console.Write(array[i] + " "); // - эта хнеротень нужна для того, чтобы вывести на экран все элементы массива через пробел
    Console.WriteLine(); // а эта хренотень нужна для того, чтобы мы перешли на другую строку 
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max); // в новый массив myArray входит метод и то, что сгенерируется исходя из верхних трех запросов у пользователя
ShowArray(myArray);// этот метод мы вызываем в самом конце, чтобы показать наш массив. Т.к. это метод типа void, то мы его не присвоили ни в какую переменную
*/

