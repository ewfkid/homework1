//задача 1

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = CreateArray(int.Parse(Console.ReadLine()));
        PrintArray(array);
        Console.WriteLine($"Average : {GetAverage(array)}");
    }
    public static int[] CreateArray(int length)
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
    }
    public static int GetAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum / array.Length;
    }
}
