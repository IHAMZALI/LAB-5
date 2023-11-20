using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = Initialize2DArray();
        Print2DArray(myArray); 
    }

    static int[,] Initialize2DArray()
    {
        int[,] array = new int[3, 4]; 

    
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = i * 4 + j + 1;
            }
        }

        return array;
    }

    static void Print2DArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t"); 
            }
            Console.WriteLine();
        }
    }
}

