System.Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
string s = a.ToString();
char[] ar = s.ToCharArray();
Array.Reverse(ar);
s = new String(ar);
int x = Convert.ToInt32(s);
if ( a == x) 
{
    System.Console.WriteLine("the given number is a palindrome");
}
else 
{
    System.Console.WriteLine("the given number is not a palindrome");
}
//System.Console.WriteLine(x);