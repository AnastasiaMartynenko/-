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
//Задача 4. Напишите программу, которая вывод массив из восьми элементов, заполненный нолями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] newArray = new int[size];

  for(int i = 0; i <= size; i++)
  {
    newArray[i] = new Random().Next(minValue, maxValue + 1); //maxValue + 1 - потому, что максимально(последнее значение всегда на один меньше, т.к. индексация начинается с нуля)
  }
  return newArray; //массив возвращается без скобок, как обычная переменная
}

void ShowArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
 {
    Console.Write($"array[i] + "); 
  }
  Console.WriteLine(); // Здесь мы используем эту конструкцию, чтобы возникла пустая строка и все вместе не слипалось
  
}


Console.Write("Imput size for array: ");
int user_array = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min value for an element: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max value for an element: ");
int user_max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(user_array, user_min, user_max);
ShowArray(myArray);
