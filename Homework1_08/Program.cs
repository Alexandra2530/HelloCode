// Задача 8. Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число!");
int N = Convert.ToInt32(Console.ReadLine());
int ost = 0;
int i = 1;
while (i <= N)
{
    ost = i % 2;
    if (ost == 0)
    {
    Console.WriteLine (i);
    }
    i = i + 1;
}