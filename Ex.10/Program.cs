/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine ("Введите трехзначное число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number>99 && number<1000)
{
    int result = (number / 10) % 10;
    Console.WriteLine ($"Вторая цифра введенного трехзначного числа, {result}");
}
else
{
    Console.WriteLine ("введенное число не трехзначное");
}