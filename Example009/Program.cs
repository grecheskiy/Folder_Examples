//Найти третью цифру числа или сообщить, что её нет
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
string str = n.ToString();
if (n>=100)
Console.WriteLine(str[3]);
else
Console.WriteLine(" Not found ");