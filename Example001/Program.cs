//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter a number: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int k = m * m;
if (n == k)
Console.WriteLine(" True ");
else
{Console.WriteLine(" False ");}