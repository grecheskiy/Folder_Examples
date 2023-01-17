Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = number * number;
Console.WriteLine("Square of number: " + result);