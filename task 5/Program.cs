// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 100)
{
    string aStr = num1.ToString();
    Console.WriteLine(aStr[2]);
}
else
{
    Console.WriteLine("число не имеет 3-й цифры ");
}