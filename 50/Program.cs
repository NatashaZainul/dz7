// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());


int m = 5; 
int n = 5; 
Random random = new Random();
int[,] array = new int[m, n];
Console.WriteLine("Массив: ");



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write("{0} ", array[i, j]);
    }
Console.WriteLine();
}
if (pos1 < 0 | pos1 > array.GetLength(0) | pos2 < 0 | pos2 > array.GetLength(1))
    {
        Console.WriteLine("Элемент отсутствует  ");
    }
else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
    }
Console.ReadLine();
 
