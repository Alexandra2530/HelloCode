// Задача 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру!");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6)
{
    Console.WriteLine("Да");
}
else if (a == 7)
{
    Console.WriteLine("Да");
}
else if (a < 6)
{
    Console.WriteLine("Нет");
}

   
