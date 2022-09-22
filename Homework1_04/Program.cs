// Задача 4. Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите число A!");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B!");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C!");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB>max) max = numberB;
if (numberC>max) max = numberC;
Console.Write ("max = ");
Console.WriteLine (max);