﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 456 -> 5
 782 -> 8
 918 -> 1*/
 Console.WriteLine("Введите трехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());
if(x<100||x>999){
    Console.WriteLine("Число не трехзначное");
}else {
    int y =x%10;
    int z = ((x-y)/10)%10;
    Console.WriteLine("Второе число\t" +z);
}