// Задача 2. Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число A!");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B!");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (max < min)
{
    min = numberA;
    max = numberB;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);