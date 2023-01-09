// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число для сравнения ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число для сравнения ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число для сравнения ");
double num3 = Convert.ToDouble(Console.ReadLine());
 if (num1 > num2 & num1 > num3)
 {
    Console.WriteLine($"Число {num1} Больше чем число {num2} и {num3}");
 }
  else if (num1 < num2 & num2 > num3)
 {
    Console.WriteLine($"Число {num2} Больше чем число {num1} и {num3}");
 }
  else if (num1 < num3 & num3 > num2)
 {
    Console.WriteLine($"Число {num3} Больше чем число {num1} и {num2}");
 }
 else
 {
  Console.WriteLine("Числа равны ");
 }




