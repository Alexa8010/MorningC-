
// Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSum (int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++)
//     {
//         sum += current;
//     }

//     return sum;
// }
// Console.Write ("input a number: ");
// int number = Convert.ToInt32 (Console.ReadLine());
// int result = GetSum (number);
// Console.WriteLine ($"sum of nmbers from 1 to {number} is {result}");

// Напишите программу, 
// которая принимает на вход число и 
// выдаёт количество цифр в числе.





// Напишите программу, 
// которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.


// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
// return array;
// }
// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }

// int GetNegSum(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//         if(array [i] <0)
//             sum += array[i];
//     return sum;
// }
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// int result = GetNegSum(newArray);
// Console.WriteLine ("sum of Neg is " + result);

// Напишите программу заменs элементов массива: 
// положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

// int[] ChangePosAndNeg(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] *= -1;
        
//     return array;
// }
// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
// return array;
// }
// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] newArray = CreateRandomArray (12, -9, 9);
// ShowArray(newArray);
// ShowArray(ChangePosAndNeg(newArray));

// Задайте массив. Напишите программу,
//  которая определяет, 
// присутствует ли заданное число в массиве.

// bool FindNumberInArray(int[] array, int number)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return true;
        
//     }
//     return false;   
// }
// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
   
// return array;
// }
// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine (" ");
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// Console.Write ("Input a number to find: ");
// int number = Convert.ToInt32 (Console.ReadLine());


//  int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// if (FindNumberInArray(newArray, number))
//     Console.WriteLine ($" The number {number} exists in the array");
// else
//     Console.WriteLine ($" The number {number} does not exist in the array");

// Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [a,b].

// int HowManyNumbers(int[] array, int a, int b)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= a && array[i] <=b) counter++;
//     }
//     return counter;
// }
// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
   
// return array;
// }

// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// Console.Write ("Input a minimum value: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a maximal value: ");
// int b = Convert.ToInt32 (Console.ReadLine());


// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// int number = HowManyNumbers(newArray, a, b);
// Console.WriteLine ($"In new array there are {number} requested numbers betweeb {a} and{b}");

// Напишите программу, которая перевернёт одномерный массив (последний 
// элемент будет на первом месте, а первый - на последнем и т.д.)

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
   
// return array;
// }

// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }


// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// ReverseArray(newArray);
// ShowArray(newArray);

//Напишите программу, которая принимает на вход три числа и проверяет,
 //может ли существовать треугольник с сторонами такой длины.

// bool TriangleCheck (int a, int b, int c)
// {
//     return a < b + c && b < a + c && c < a + b;
// }

// Console.Write ("Input a: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input b: ");
// int b = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input c: ");
// int c = Convert.ToInt32 (Console.ReadLine());

// if (TriangleCheck(a, b, c)) Console.WriteLine("Yes, the triangle exists");
// else Console.WriteLine ("Triangle not found");


 //Не используя рекурсию, выведите первые N чисел Фибоначчи. 
 //Первые два числа Фибоначчи: a и b.

// int[] Fibonacci (int n, int a, int b)
// {
//     int [] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < n; i++)
//     {
//         array[i] = array[i - 1] + array [i - 2];
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
// Console.WriteLine();
// }

// Console.Write ("Input N: ");
// int n = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input b: ");
// int b = Convert.ToInt32 (Console.ReadLine());

// ShowArray(Fibonacci(n, a, b));





// Console.Write ("Input c: ");
// int c = Convert.ToInt32 (Console.ReadLine());
//Копия заданного массива с помощью поэлементного комирования.

       
//  int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
   
// return array;
// }

// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();

// }

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// ShowArray(CopyArray(newArray));


//Напишите прогу преобразования десятичного числа в двоичное

// string ConvertToBin(int number)
// {
//     string res = "";
//     int remainder;
//     while (number > 0)
//     {
//         remainder = number % 2;
//         number = number / 2;

//         if (remainder > 0) res = "1" + res;
//         else res = "0" + res;
//     }
//     return res;
    
// }
// Console.Write("Input dec number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ConvertToBin(number));


// Seminar7


// Задайте двумерный массив 
// размером m×n, заполненный случайными целыми числами.

// int[,] CreateRandom2dArray()
// {   
//     Console.Write("Input a number of rows");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colums");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible valies");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                 array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;    
// }

// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }


// int[,] newArray = CreateRandom2dArray();
// Show2Array(newArray);

// Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится 
// по формуле: Aij = i + j. Выведите полученный массив на экран.

// int [,] CreateIndexSumArray(int rows, int colums)
// {
//    int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                 array[i,j] = i + j;

//     return array;    
// }
// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());


// int[,] newArray = CreateIndexSumArray(rows, colums);
// Show2Array(newArray);


// Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

// int[,] ChangeArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i +=2)
//             for(int j = 0; j < array.GetLength(1); j+=2)
//                 array[i,j] *= array[i,j];

//     return array;    
// }

// int[,] CreateRandom2dArray()
// {   
//     Console.Write("Input a number of rows");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colums");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible valies");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                 array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;    
// }

// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }


// int[,] newArray = CreateRandom2dArray();
// Show2Array(newArray);
// ChangeArray(newArray);
// Show2Array (newArray);

// Задайте двумерный массив. Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1;1) и т.д.



