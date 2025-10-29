using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array1 = GenerateArray(10, 10);
        int[,] array2 = GenerateArray(10, 10);

        int count1 = CountPositiveOddSumRows(array1);
        int count2 = CountPositiveOddSumRows(array2);

        Console.WriteLine($"Количество строк с положительной суммой нечетных элементов в первом массиве: {count1}");
        Console.WriteLine($"Количество строк с положительной суммой нечетных элементов во втором массиве: {count2}");


        if (count1 == 0 && count2 == 0)
        {
            Console.WriteLine("Нет строк с положительной суммой нечетных элементов ни в одном из массивов.");
        }
        PrintArray(array1);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(array2);
    }
    static int PrintArray(int[,] array1)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(array1[i, j]) ;
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        return 0;
    }
    static int[,] GenerateArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

    static int CountPositiveOddSumRows(int[,] array)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = CalculateOddSum(array, i);
            if (sum > 0)
            {
                count++;
            }
        }
        return count;
    }

    static int CalculateOddSum(int[,] array, int rowIndex)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j % 2 != 0)
            {
                sum += array[rowIndex, j];
            }
        }
        return sum;
    }
}
