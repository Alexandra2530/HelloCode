// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Количество чисел > 0: {count}");
