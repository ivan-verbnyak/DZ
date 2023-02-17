// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 100;
int b = a / 10;
System.Console.WriteLine(b);
