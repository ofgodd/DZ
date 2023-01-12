// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите первую точку x " );
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую точку y " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью точку z " );
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку x " );
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку y " );
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку z " );
int num5 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(num-num3, 2)+ Math.Pow(num1-num4, 2)+ Math.Pow(num2-num5, 2)), 2);
Console.Write(distance);