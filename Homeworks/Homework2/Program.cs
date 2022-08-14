// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int MiddleDigit (int number)
{
   int dec = number / 10 % 10;
   return dec;
}
int randomNumber = new Random().Next(100, 999);
int newNumber = MiddleDigit(randomNumber);
*/

//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*

int FindThirdDigit (int[] array, int number)   // <<== первый неправильный способ
{  
   number = array.Length;
   int index = 0;
   int digit = array[index];
   while (index < 2)
   {
      Console.WriteLine("Here is no third digit");
      index++;
   }
      if(index == 2)
      {
         Console.WriteLine("It is third digit of {number}");
      } 
   return array[index];
}

Console.Write("Input a number: ");
int number  = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(number);
Console.WriteLine(new_digit);

*/
/*
int FindThirdDigit (int[] array)    //<<== Второй неправильный способ
{  
   int number = array.Length;
   int index = 0;
   int third_digit = array[2];
   while (index < 2)
   {
      Console.WriteLine("Here is no third digit");
      index++;
   }
      if(index == 2)
      {
         Console.WriteLine("It is third digit of {number}");
      } 
   return array[2];
}

Console.Write("Input a number: ");
int number  = Convert.ToInt32(Console.ReadLine());
int new_digit = FindThirdDigit(number);
Console.WriteLine(new_digit);
*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool FindWeekend (int day_number)
{
   if(day_number >= 6)
      return true;
   
   else
      return false;
}
Console.Write("Input any number of a week day: ");
int day_number = Convert.ToInt32(Console.ReadLine());
bool FindDay = FindWeekend(day_number);
Console.WriteLine(FindDay);
*/