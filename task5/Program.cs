//задача 5
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[][] array = InputArray(int.Parse(Console.ReadLine()));
        PrintArray(array);
        array = ReplaceEvenElements(array);
        PrintArray(array);

    }
    public static int[][] InputArray(int rows)
    {
        int[][] array = new int[rows][];
        for (int i = 0; i < array.Length; i++)
        {
            int columns = int.Parse(Console.ReadLine());
            array[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }
        return array;
    }
    public static int[][] ReplaceEvenElements(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] % 2 == 0)
                {
                    array[i][j] = i * j;
                }
            }
        }
        return array;
    }
    public static void PrintArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}


