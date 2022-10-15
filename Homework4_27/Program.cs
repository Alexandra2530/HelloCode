// Задача 27. Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
    int num = 0;
    while (num <= 1)
    {
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int GetSumm(int A)
{
    int summ = 0;
    for (int i = 1; i <= A; i++)
    {
        summ = summ + (A % 10);
        A = A / 10;
    }
    return summ;
}

int A = GetNumber();
Console.WriteLine("Сумма цифр в числе " + A + " равна " + GetSumm(A));