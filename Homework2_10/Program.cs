// Задача 10. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

int ReadNumber()
{
    Console.WriteLine("Введите трёхзначное число!");

    int number = 0;
    number = Convert.ToInt32( Console.ReadLine() );
    return number;
}

int SecondDigit(int number)
{
    int Sotni = number/100;
    int Decimal = number/10;
    return Decimal - Sotni * 10; 
}

int A = ReadNumber();
Console.WriteLine(SecondDigit(A));
