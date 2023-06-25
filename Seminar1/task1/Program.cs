// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine ("Введите первое число");
string? numberStringOne = Console.ReadLine ();

Console.WriteLine ("Введите второе число");
string? numberStringTwo = Console.ReadLine();

int NumberIntOne = Convert.ToInt32(numberStringOne);
int NumberIntTwo = Convert.ToInt32(numberStringTwo);

if (NumberIntOne > NumberIntTwo)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
   Console.WriteLine("Второе число больше первого"); 
}