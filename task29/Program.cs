// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Random rand = new Random();

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
    Console.Write(array[i] + " " );
}
System.Console.WriteLine();