//задача 4

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[,] array = InputArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        PrintArray(array);
        int[,] array1 = InputRowArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        PrintArray(array1);
        int[,] matrix = FillArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        PrintArray(matrix);
    }
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static int[,] InputArray(int columns, int rows)
    {
        int[,] array = new int[columns, rows];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return array;
    }

    public static int[,] InputRowArray(int columns, int rows)
    {
        int[,] array = new int[columns, rows];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(input[j]);
            }
        }
        return array;
    }

    public static int[,] FillArray(int columns, int rows)
    {
        int[,] array = new int[columns, rows];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        return array;
    }
}
