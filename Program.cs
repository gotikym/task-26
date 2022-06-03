using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 11, 12, 13, 22, 99, 64, 31, 16, 77, 41, 54, 16, 17, 14, 43, 54, 16, 88, 65 };
        int temporaryNumber = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temporaryNumber = array[i];
                    array[i] = array[j];
                    array[j] = temporaryNumber;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}