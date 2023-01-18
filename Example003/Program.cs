//Выяснить является ли число чётным
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int reuslt = n % 2;
if (reuslt == 0)
//int number = Convert.ToInt32(Console.ReadLine()) % 2;
//if (number == 0)
{Console.WriteLine(" even number ");}
else
{Console.WriteLine(" odd number ");}