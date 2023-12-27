//задача 2

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] temp = FillArray(int.Parse(Console.ReadLine()));
        PrintArray(temp);
        int length = GetLength(temp);
        int[] array = CreateArray(length);
        RemoveElements(temp, array);
        PrintArray(array);
    }
    public static int GetLength(int[] array)
    {
        int length = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) <= 100)
            {
                length++;
            }
        }
        return length;
    }

    public static int[] CreateArray(int length)
    {
        int[] array = new int[length];
        return array;
    }
    public static int[] FillArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    public static void RemoveElements(int[] temp, int[] array)
    {
        int j = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            if (Math.Abs(temp[i]) <= 100)
            {
                array[j] = temp[i];
                j++;
            }
        }
    }
}
