// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 < 1000 && num1 > 100)
{
    int num2 = num1%100;

    int num3 = num2/10;

    Console.Write("Ваше число " +num3);
    }
else 
{
    Console.Write("Вы ввели число состоящее менее или более трех знаков" );
}