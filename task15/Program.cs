// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("input number: ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1: System.Console.WriteLine("no");
        break;
    case 2: System.Console.WriteLine("no");
        break;
    case 3: System.Console.WriteLine("no");
        break;
    case 4: System.Console.WriteLine("no");
        break;
    case 5: System.Console.WriteLine("no");
        break;
    case 6: System.Console.WriteLine("yes");
        break;
    case 7: System.Console.WriteLine("yes");
        break;
    default: System.Console.WriteLine("There is no such day of the week");
        break;
}