//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Input first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine($"Max number is {a}");
// }
// else
// {
//     Console.WriteLine($"Max number is {b}");
// }

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Input first number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number:");
// int c = Convert.ToInt32(Console.ReadLine());
// if(a > b & a > c)
// {   
//     Console.WriteLine($"Max number is {a}");
// }
// if(a < b & b > c)
// {   
//     Console.WriteLine($"Max number is {b}");
// }
// if(c > b & a < c)
// {   
//     Console.WriteLine($"Max number is {c}");
// }

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Input number:");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a % 2 == 0)
// {
//     Console.WriteLine($"Number {a} is even");
// }
// else
// {
//     Console.WriteLine($"Number {a} is odd");
// }

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Input number:");
// int a = Convert.ToInt32(Console.ReadLine());
// int digit = 2;
// while(digit <= a)
// {
//     if(digit % 2 == 0)
//     {
//         Console.Write(digit + " ");
//     }
//     digit++;
// }