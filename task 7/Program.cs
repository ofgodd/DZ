// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 6)
    
    switch (num1)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    default:
        Console.WriteLine("Неверный ввод числа дня");
        break;
}
else
{
     Console.WriteLine("Выходной");
}