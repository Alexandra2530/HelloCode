// Задача 13. Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

int number = 645;
number = Math.Abs(number);
if (number > 99)
{
    while(number > 999)
    {
        number /= 10;
    }
    Console.WriteLine("третья цифра числа " + number%10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
   