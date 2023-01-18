//Показать вторую цифру трёхзначного числа
Console.Write("Enter a three-digit number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int x2 = (n/10)%10;
if (n>=100)
Console.WriteLine(x2);
else
Console.WriteLine(" False ");