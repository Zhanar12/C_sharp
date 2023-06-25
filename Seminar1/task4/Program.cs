// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число: ");
int OneNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int TwoNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

if (OneNumber > TwoNumber)
{
    if (OneNumber > TwoNumber)
    {
        Console.WriteLine("Максимальное число: " + OneNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + TwoNumber);
    }
}

else if (OneNumber > threeNumber)
{
    Console.WriteLine("Максимальное число: " + TwoNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + threeNumber);
}