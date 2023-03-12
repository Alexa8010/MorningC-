// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNums(int num)
// {
//     Console.Write(num +  " ");
//     if(num > 1) ShowNums(num -1);
    
// }
// ShowNums(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumOfConsecutiveNums(int n, int m)
// {
//     if (n == m) 
//         return n;
//     else 
//         if(n > m) 
//                 return m + SumOfConsecutiveNums(n, m + 1);
//         else
//             return n + SumOfConsecutiveNums(n + 1, m);
// }
// Console.WriteLine(SumOfConsecutiveNums(1,15)); 



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int Ankerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//         if((m != 0) && (n == 0))
//             return Ankerman(m-1,1);
//         else
//             return Ankerman(m-1, Ankerman(m,n-1));
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(Ankerman(m,n));
