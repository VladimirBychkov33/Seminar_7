// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


Console.Clear();

int[,] array = GetArray(4, 4, 10, 80);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите позиции элемента в массиве. Индекс строки: ");
int indR = int.Parse(Console.ReadLine());
Console.Write("Индекс столбца: ");
int indC = int.Parse(Console.ReadLine());
ElementMass(array);

void ElementMass(int[,] massiv)
{

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        { 
            if (i == indR && j == indC) Console.Write($"{massiv[i, j]}");
            // else Console.Write("Такого числа нет");
            
        }
    }


}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}