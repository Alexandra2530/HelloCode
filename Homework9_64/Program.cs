// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

void Sequence(double number)
{
    if (number > 1)
    {
        Console.Write($"{number},");
        Sequence(number - 1);
    }
    else
    {
        Console.Write(number);
        Console.WriteLine();
    }
}

double GetNumder()
{
    Console.WriteLine("Введите число N");
    return Convert.ToDouble(Console.ReadLine());
}

Sequence(Math.Truncate(GetNumder()));
