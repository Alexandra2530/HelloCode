// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
 
Console.WriteLine("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива под индексом "+i+": ");
    array [i] = Convert.ToInt32(Console.ReadLine ());
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i!=array.Length - 1)
    {
        Console.Write(", ");
    }
}
