// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

void CheckPalindrom(int number)
{
    if(number >= 10000)
    {
        int rev1 = number / 10000;
        int ost1 = number % 10;
            if (rev1 == ost1)
            {
                number = number / 10;
                int rev2 = (number / 100) % 10;
                int ost2 = number % 10;
                if (rev2 == ost2)
                    Console.WriteLine("Да");
            }
            else
            Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
CheckPalindrom(number);
