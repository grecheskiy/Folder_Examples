//Показать последнюю цифру трёхзначного числа
Console.Write("Enter a three-digit number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int x3 = n % 10;
if (n>=100)
Console.WriteLine(x3);
else
Console.WriteLine(" False ");