// Task 3. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2)
// {
//      Console.Write($"max {num1} and min {num2}");
// }
// else
// {
//     if(num1 < num2)
//     {
//         Console.Write($"max {num2} and min {num1}");
//     }
//     else
//     {
//         Console.Write($"{num2} = {num1}");
//     }
// } 
// Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Input three integer numbers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if(num2 > max)
// {
//      max = num2;
// }
// if(num3 > max)
// {
//     max = num3;
// }
// Console.Write($"max: {max}");
        
//  Task 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Вариант 1
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1;
// num1 = 0;
// while (num1 < num)
// {
//   num1 = num1 + 2;
//   Console.Write($" {num1},");  
// }

// ////  Task 8. Напишите программу, которая на вход принимает число (N), 
// // а на выходе показывает все чётные числа от 1 до N.
// Вариант 2.
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1;
// for (num1 = 2; num1 <=num; num1 = num1 + 2)
// {
//   Console.Write($" {num1},");  
// }

// // Task 6. Напишите программу, которая на вход принимает число и выдаёт, 
// //является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
// {
//     Console.Write($"{num} is even");
// }
//  else
//  {
//     Console.Write($"{num} is odd");
//  }