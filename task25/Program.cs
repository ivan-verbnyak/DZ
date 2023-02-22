/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

System.Console.Write("Введите число: ");
double Number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень возведения: ");
double Degree = Convert.ToInt32(Console.ReadLine());

double Result = Math.Pow(Number, Degree);
Console.WriteLine(Result);