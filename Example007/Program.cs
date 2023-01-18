//Удалить вторую цифру трёхзначного числа 
Console.Write("Enter a three-digit number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int x1 = n / 100;
int x2 = (n / 10) % 10;
int x3 = n % 10;
if (n>=100)
Console.WriteLine(x1 + "" + x3);
else
Console.WriteLine(" False ");