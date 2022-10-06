/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру от 1 до 7 чтобы узнать день недели");
int number = int.Parse(Console.ReadLine());
if (number<=5 & number>=1) 
{
    Console.WriteLine("Будний день");
}
if (number==6 || number==7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
