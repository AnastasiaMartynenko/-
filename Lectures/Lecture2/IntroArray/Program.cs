// Функция - это подпрограмма (в C# называется 'методом')
/*
// Задача 1. Найти максимальное число.
int a1 = 15;
int b1 = 21;
int c1 = 669;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = a1; // сначала мы ввели переменную max, в которую положили значение первого аргумента
if(b1 > max) max = b1; //сравниваем превый аргумент с последующий. Если он больше значит, теперь он максимальный на данном этапе 
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3; 
if(b3 > max) max = b3; 
if(b3 > max) max = b3; 

Console.WriteLine(max);
*/ 
// Задача 2. Найти максимально значение при помощи функции.
// Функция будет работать так: сначала возьмет первые три числа и найдет максимальное.
// Потом возьмет вторые три числа и среди них найдет максимально.
//Потом возьмет последние три числа и вновь найдет максимальное. 
//И потом устроим суперфинал и найдет максимальное среди финалистов.
/*
int Max(int arg1, int arg2, int arg3) //ввели 3 аргумента. ; - после объявления функции не ставим.
{
    int result = arg1; //в теле метода вводим переменную result, где будет хранится значение максимального
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // теперь наш метод будет возвращать максимум из 3х чисел
}
//             0   1   2   3   4   5   6   7   8   -индексы массива
int[] array = {11, 21, 31, 41, 15, 61, 178, 18, 19};
array[0] = 12; // здесь мы присвоили элементу под индексом ноль значение 12
//Console.WriteLine(array[4]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
*/
/*
// Задача 3. Имеется массив array из n элементов. Требуется найти элемент массива, равный find.
// Решение:
// 1. Установить счетчик index на 0
// 2. Если array[index] = find, алгоритм завершил работу успешно.
// 3. Если array[index] еще не равно find => увеличиваем index на 1 (index++)
// 4. Если index < n, то переходим к шагу 2. В противном случае алгоритм завершит работу безуспешно.

int[] array = {1, 12, 31, 4, 18, 16, 17, 18, 30}; 

int n = array.Length; // array.Length возвращает количество элементов массива
int find = 18; // допустим пользователь ввел 4
int index = 0;

while(index < n) 
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // оператор break нужен,когда в массиве несолько индексов с одинаковыми значениями. Он прерывает цикл, когда мы нашли первое значени. Иначе в печать выйдут все индексы с одинаковыми значениями.

    }
    index = index + 1;
}
 */
 /*
 //Задача 4. 
 void FillArray(int[] collection)
 {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index + 1;

    }
 }
//void метод - это метод, который ничего не возвращает
 
 void PrintArray(int[] collection2)// мы не можем использовать элемент collection, т.к. он уже нами использовался
 {
    int count = collection2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection2[position]);
        position = position + 1;
    }
 } 
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        
        }
        index = index +1;
    }return position;


}


 int[] array = new int[10]; //new int[10] - означает "создай новый массив, в котором будет 10 элементов"
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/