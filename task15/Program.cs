// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("input number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0 && n < 6) System.Console.WriteLine("Работаем");

else if (n > 5 && n < 8) System.Console.WriteLine("Пора отдыхать");

else System.Console.WriteLine("не такого дня недели");
