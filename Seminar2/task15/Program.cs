/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите число:\t");
int x = Convert.ToInt32(Console.ReadLine());
if(x<=5 && x>0){
   Console.WriteLine("Не выходной"); 
} else if (x>=6 && x<=7){
    Console.WriteLine("Выходной");
} else {
    Console.WriteLine("Такого дня недели не существует");
}