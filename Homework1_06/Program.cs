// Задача 6. Напишите программу,которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число!");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a % 2;
if (ost == 0)
{
Console.WriteLine ("Четное число");
}
else
{
Console.WriteLine ("Не четное число");
}