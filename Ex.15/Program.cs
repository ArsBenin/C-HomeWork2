/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine ("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 0 && number < 8)
{
    if (number > 0 && number < 6)
    { 
        Console.WriteLine ("Будний день");
    }
    else
    {
        Console.WriteLine ("Выходной день");
    }
}
else
    Console.WriteLine ("Такого дня недели нет");