/*Виды функций:

Первый вид - ничего не принимает(не принимает никаких аргументов) и ничего не возвращает. 

Второй вид - принимает какие-то аргументы, но ничего не возвращает.

Третий вид - возврщает что-то, но ничего не принимает(например, генерато случайных чисел).

Четвертый вид - принимает какие-то аргументы и возвращает что-то для дальнейшей работы.

*/

// Первый вид:
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); - чтобы вызвать такой метод, нужно написать имя метода и поставить пустые круглые скобки.
*/
/*
// Второй вид:
void Method2(string message)
{
   Console.WriteLine(message); //- в собках мы используем те аргументы, которые были приняты в начале.
}
Method2("Текс сообщения");
*/
/*
void Method21(string message, int count) // - int count - это сколько раз мы хотим, чтобы вывелось нашее ссобщение
{
   int i = 0; // 
   while(i < count)
   {
    Console.WriteLine(message); 
    i++; //увеличение на 1 называется инкремент
    }

}  
Method21(message: "Текс сообщения", count: 4); // например, мы хотим, чтобы сообщение повторялось четыре раза
*/
/*
// Третий вид методов:

int Method3() // скобка пустая, т.к. аргументов этот метод никаких не принимает
{
    return DateTime.Now.Year; //этот опертор показывает нынешний год
}
int year = Method3();
Console.WriteLine(year);
*/

//Четвертый вид методов:
/*
string Method4 (int count, string text)
{
   int i = 0;
   // string result = " "; //Просто пустая строка
   string result = String.Empty; //пустая строка как вверху
   while(i < count)
   {
    result = result + text;
    i++;
   }
   return result;
}
string res = Method4(10, "Funny message");
Console.WriteLine(res);
*/

// Цикл for (или "цикл со счетчиком")
/*
string Method4 (int count, string text)   

{   string result = String.Empty;
    
    for(int i = 0; i < count; i++)
   {
       result = result + text;
    }
    return result;
}
      

string res = Method4(10, "Funny message");
Console.WriteLine(res);
*/

//Цикл for. Цикл в цикле.
//Напишите программу, которая выводит таблицу умнрожения от 2 до 10.
/*
for(int i = 2; i <= 10; i++) 
{
    for( int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine(); // это чтобы была пустая строка после умножения на каждое конкртное число.
}
*/

// Задача. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
// а все большие "С" заменить маленькими "c". 
/*
string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/
//Функционл для строк:
// string s = "Goodman" - дана строка
//             0123456 - позиции символов строки, начиная с нуля
//s[3] // - с помощью такой конструкции мы можем найти интересующий нас символ строки. под третим номер у нас буква d.

//char - это символьный тип данных, предназначенный для хранения одного символа (управляющего или печатного) в определённой кодировке.
/*
string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue) //- char oldValue - это конкретный символ, который мы хотим заменить
                                                          // - char newValue - это конкретный символ, на который мы хотим заменить старый символ
{
    string result = String.Empty;

    int lenght = text.Lenght; //-text.Lenght _это длина, размер текста
    for(int i = 0; i < lenght; i++)
    {
       if(text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";

    }
    return result;
}
string newText = Replace(text, ' ', '-'); //здесь пишем, что на что меняем - здесь все пробелы заменяем на черточки
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
*/ 

//Задача. Нужно упорядочить массив.
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();

void SelectionSort(int[] array)   
{
    for (int i = 0; i < array.Length -1; i++)
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) 
        {
            minPosition = j;
        }
    }
    int temporary = array[i];
    array[j] = array[minPosition];
    array[minPosition] = temporary;

}
}
PrintArray(arr);
SelectionSort(arr); //эта форма вызывает программу упорядочивания массива


PrintArray(arr);