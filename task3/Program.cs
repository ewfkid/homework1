//задача 3
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] temp = InputArray(int.Parse(Console.ReadLine()));
        PrintArray(temp);
        int[] array = SortArray(temp);
        PrintArray(RemoveDuplicates(array, GetLength(array)));
    }
    
    public static int[] InputArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    public static int[] RemoveDuplicates(int[] array, int length)
    {
        int[] result = new int[length];
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 || array[i] != array[i - 1])
            {
                result[counter]= array[i];
                counter++;
            }
        }
        return result;
    }

    public static int GetLength(int[] array)
    {
        int length = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 || array[i] != array[i - 1])
            {
                length++;
            }
        }
        return length;
    }

    public static int[] SortArray(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        foreach(int el in array)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();
    }
}

