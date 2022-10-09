// Задача 23. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    Console.WriteLine("Введите число ");
return Convert.ToInt32(Console.ReadLine());
}

void GetPrintPow(int number)
{
    int count = 1;
    Console.WriteLine("Таблица кубов чисел от 1 до N " + number + ": ");
    while (count <= number)
    {
        Console.Write(Math.Pow((count),3) + " ");
        count ++;
    }
}

GetPrintPow(GetNumber());