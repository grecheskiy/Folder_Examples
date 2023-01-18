//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int [] numbers = {10, 99};
int a = numbers[0]; int b = numbers[1];
if (a > b)
Console.WriteLine(numbers[0]);
else
Console.WriteLine(numbers[1]);