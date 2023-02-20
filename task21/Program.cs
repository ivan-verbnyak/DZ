Console.WriteLine("Enter the coordinates of point A and B: ");
int[] c = new int [6];
for (int i = 0; i < c.Length; i++)
{
    c[i] = Convert.ToInt32(Console.ReadLine());
}
double distance = Math.Sqrt((c[3]-c[0]) * (c[3]-c[0]) + (c[4]-c[1]) * (c[4]-c[1] )+ (c[5]-c[2]) * (c[5]-c[2]));

System.Console.WriteLine($"distance between points A and B:{distance}");
