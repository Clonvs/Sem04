// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// int num1;
// int num2;
// int sum;
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sum = num1;
// for (int i = 1; i < num2; i++)
// {
//    sum = sum * num1; 
// }

// Console.WriteLine("" + num1 + " ^ " + num2 + " -> " + sum + "");
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("input number");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int num = number;
// while (num >0)
// {
//     sum = sum + (num %10);
//     num = num / 10;
// }
// Console.WriteLine(number +  "->" + sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int [] numbers = new int [8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers [i] = new Random().Next(0, 11);
//     Console.Write("  " + Method (i) + " , " );
// }
// Console.Write("]");
// int Method (int a)
// {
// return numbers[a];
// }