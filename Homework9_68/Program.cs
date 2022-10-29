// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    return AckermanFunction(numberM, numberN);
}

int GetNumder(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetNumder("Введите число M: ");
int n = GetNumder("Введите число N: ");
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermanFunction(m, n)}");