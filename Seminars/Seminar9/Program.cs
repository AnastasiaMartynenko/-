﻿//Тема: Рекурсия.
//Обязательным условием любого рекурсивного метода является то,что он в определенный момент должен закончиться.
//Этим условием рекурсивные методы похожи на циклы.
//Рекурсивные методы работают в обоих направлениях(например, как от 0 до n, так и от n до 0)
//Задача 1. Задайте значение n и напишите программу, которая выведет все натуральные числа в промежутке от 1 до n.
/*
void ShowNumbers(int n)
{
   if(n > 1) ShowNumbers(n - 1); //условие продолжения рекурсии if(n > 1) - если аргумент больше чем величина, которая будет являться пределом,
   Console.Write(n + " ");       //то мы вызываем метод внутри этой рекурсии. Каждый последующий аргумент нового метода рекурсии, должен отличаться от предыдущего, т.е. быть меньше
}
ShowNumbers(10);//число 10 мы подставили просто для примера, можно любое другое число
/*
//А теперь тоже самое, но выведем числа в обратном порядке
void ShowNumbers(int n)
{
   Console.Write(n + " ");      
   if(n > 1) ShowNumbers(n - 1); 
}
ShowNumbers(10);
*/
//Задача 2. Напишите программу, которая на вход будет принимать число  и возвращать сумму его цифр.
/*
void ShowNumbers(int n)
{
   if(n > 1) ShowNumbers(n - 1);
   Console.Write(n + " ");      
}

int FindSum(int n)
{
   if(n > 0)
     return FindSum(n / 10) + n % 10; //отсекаем разряд числа(т.е. делим на цифры) и прибавляем остаток
   else 
     return n;
}
ShowNumbers(10);
Console.WriteLine();
Console.WriteLine(FindSum(123)); //нашли сумму цифр числа 123
*/
//Задача 3. Необходимо задать значения m и n и написать программу, которая выведет все натуральные числа в промежутке от n до m.
/*void ShowNumbers(int n, int m)
{
   if(m != n)
   {
      if(n > m) 
      {ShowNumbers(n - 1, m);
      Console.Write(n + " ");
      }
      else
      {
      ShowNumbers(m - 1, n);
      Console.Write(m + " ");
      }
   }
   else
      Console.Write(m + " ");
}   
ShowNumbers(5, 15);
*/
//Задача 4. Необходимо написать программу, которая число a возводить в целую степень b.
/*
 int FindNumbers(int a, int b)
 {
   if(b != 0) //b тут вместо счетчика
   {
      return FindNumbers (a, b - 1) *a;
   }
   else return 1;
 }
 Console.WriteLine(FindNumbers(2, 3));
*/