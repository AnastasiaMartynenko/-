// Задача 1. Создайте массив из 12-ти элементов, заполненный случайными числами в промежутке от -9 до 9. 
// Необходимо найти сумму отрицательных элементов и сумму положительных элементов.

//Алгоритм решения этой задачи:
// Задача состоит из 3х методов. Первый метод - создает новый массив. Второй - выводит его на экран. Третий - создает метод, который будет считать сумму положительных и отрицательных значений.

//Первый метод:
//1. Написать имя метода и присвоить ему три аргумента(размер, минимально значение, максимальное значение)
//2. В теле метода создаем переменную массиву и кладем туда new int[size]. 
//3. Тут-же в теле метода пишем цикл, в котором будем сортировать все элементы массива.
//4. В переменную элементов индекса массива кладем генератор случайных чисел(т.к. массив рандомный)
//5. Возвращем наш массив 

//Второй метод:
//1. Написать имя метода типа void и присвоить ему переменную (массив, который будем выводить на экран)
//2.В теле метода пишем цикл (он покажет до какого момента выводить элементы массива на экран)
//3.Собственно здесь и выводим все элементы массива на экран

//Третий метод:
//1. Написать имя метода и присвоить ему тип данных
//2. В теле метода создать новые две переменные, в которых будем хранить суммы положительных и отрицательных значений
//3. Создать цикл, в котором будем считать отрицательные и положительные значения
//4. В цикле создать уловие if, которое поможет узнать, какие значения положительные, а какие отрицательные
//5. Если значение положительное, то sumPositive будет увеличиваться на элемент массива под текущим индексом, а если отрицательное, то sumNegative будет увеличиваться на элемент массива под текущим индексом
//6. В методе (сразу за циклом) напечатаем наши суммы

//После методов попросим пользователя ввести размер массива, максимальное и минимальное значения массива.
//Создадим переменную, куда положим наш первый метод с тремя новыми запрошенными от пользователя аргументами.
//Выведем на экран второй метод - FindMinMaxSum(myArray); - сначала имя второго метода, в скобках переменная, в которую положили первый метод
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

void FindMinMaxSum(int [] array) // В начале мы создаем метод, в качестве аргумента которого будет массив (в этом массиве мы и будем искать суммы положительных и отрицательных чисел)
//Чтобы найти отрицательные и положительные элементы нам нужен цикл
//Также нам нужно ввести новые переменные(int sumPositive и int sumNegative), в которым мы будем хранить сумму положительных и отрицательных значений. 
{
   int sumPositive = 0;
   int sumNegative = 0;

   for(int i = 0; i < array.Length; i++) // вот теперь создаем цикл, который будет считать наши суммы положительных и отрицательных значений
   { 
        if(array[i] > 0) //тут мы берем число под каким-то индексом и спрашиваем: "Оно положительное?". Если да, то увеличиваем нашу положительную сумму на один.
       {
           sumPositive = sumPositive + array[i];
        } 
        else
        {
           sumNegative = sumNegative + array[i]; //если наше число под текущим индексом меньше ноля, то отрицательную сумму увеличиваем на один.
        }
        

    }
    Console.WriteLine($"Sum of negative elements is {sumNegative }");//прям тут в методе печатаем наши суммы.
    Console.WriteLine($"Sum of positive elements is {sumPositive }");//мы не возвращаем суммы в основуную программу потому, что: это метод void и потому, что мы еще не умеем возвращать два значения.
}
Console.Write("Input size for array: ");
int user_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] myArray = CreateRandomArray (user_size, min, max); // в новый массив myArray входит метод и то, что сгенерируется исходя из верхних трех запросов у пользователя
ShowArray(myArray);
FindMinMaxSum(myArray);
*/
/*
//Задача 2. Напишите программу замены элементов массива: положительные элементы замените на отрицательные, а отрицательные замените на положительные.
//Алгоритм решения этой задачи:
// Задача состоит из 3х методов(вообще-то из 4х, если убрать 114 строку, но не надо так делать). Первый метод - создает новый массив. Второй - выводит его на экран. Третий - создает метод, который положительные значения меняет на отрицательные и наоборот.
//Первый метод:
//1. Написать имя метода и присвоить ему три аргумента(размер, минимально значение, максимальное значение)
//2. В теле метода создаем переменную массиву и кладем туда new int[size]. 
//3. Тут-же в теле метода пишем цикл, в котором будем сортировать все элементы массива.
//4. В переменную элементов индекса массива кладем генератор случайных чисел(т.к. массив рандомный)
//5. Возвращем наш массив 

//Второй метод:
//1. Написать имя метода типа void и присвоить ему переменную (массив, который будем выводить на экран)
//2.В теле метода пишем цикл (он покажет до какого момента выводить элементы массива на экран)
//3.Собственно здесь и выводим все элементы массива на экран

//Третий метод:
//1. Написать имя метода и присвоить ему массив
//2. В теле метода пишем цикл, который будет перебирать все элементы
//3. В цикле меняем значения всех элементов на противоположные (умножая на -1)
//4. За циклом возвращем массив в основную программу.

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

int[] ChangeElements (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array; //возвращаем массив без каких-либо скобок
}
Console.Write("Input size for array: ");
int user_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[] myArray = CreateRandomArray (user_size, min, max); 
ShowArray(myArray);
ShowArray(ChangeElements(myArray)); //Attention!!! Мы поместили наш третий метод в скобки перед myArray, для того, чтобы  не писать четвертый метод, который бы выводил наш третий преобразованный метод на экран. Это намного быстрее, красивее, молодежнее.
*/
// Задача 3. Необходимо задать массив и написать программу, которая определяет, присутствует ли заданное число в массиве. 
//Задать массив можно любым способом: попросить пользователя ввести размер массива, макс и мин значение элементов; можно сгенерировать рандомом; можно самому тупо в лоб ввести значения массива.
//Например, мы решили, что будем просить пользователя что-то ввести. Нам нужно, чтобы он ввел массив и число, которое мы будем искать в этом массиве.
//Тут лучше использовать тип bool, т.к. нам просто нужно ответить, есть ли число пользователя в массиве или нет. 

/*
int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
        }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
bool CheckNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true; 
    }
    return false;
}
Console.Write("Input size for array: ");
int user_array = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int user_any_number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (user_array);
ShowArray(myArray);
bool check = CheckNumber(myArray, user_any_number);
if (check == true) Console.WriteLine($"Число {user_any_number} найдено в заданном массиве");
else Console.WriteLine($"Число {user_any_number} не найдено в заданном массиве");
*/




//Задача 4. Задайте одномерный массив из 12ти случайных чисел. Необходимо найти количество элементов массива, значения которых лежат в отрезке от 10 до 99 включительно.
// То есть нам нужно определить количество двухзначных чисел, которые в этом массиве есть. 
//Тут на вход в третий метод мы будем брать массив и два числа.
//А возвращать будем числа в отрезке между этими двумя числами.
/*
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
int CountElements(int[] array, int min, int max)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i]<= max) count++;
    }
   return count;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max1 = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = CountElements(myArray, min1, max1);
Console.WriteLine($"Количество элементов массива, находящихся в заданном отрезке, равно {result}");
*/

// Задача 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
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
int[] CompositionPairsOfElements(int[] array)
{
    int[] newArray = new int [array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i]*array[array.Length - 1 - i];
    }
   return newArray;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(CompositionPairsOfElements(myArray));
*/