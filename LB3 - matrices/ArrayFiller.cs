using System;

namespace LB3___matrices
{
    public class ArrayFiller
    {
        private Random _rnd = new Random();
        
        public int[,] BuildArray()
        {
            Console.WriteLine("How would you like to fill array\n\t1-By hands\n\t2-By random");
            int fillingType = Int32.MaxValue;

            while (fillingType != 1 || fillingType != 2)
            {
                fillingType = int.Parse(Console.ReadLine());
                switch (fillingType)
                {
                    case 1:
                        Console.WriteLine("By hands...");
                        int[,] handArray = FillByHand();
                        return handArray;
                    case 2:
                        Console.WriteLine("By random...");
                        int[,] randomArray = FillByRandom();
                        LogArray(randomArray);
                        return randomArray;
                    default:
                        Console.WriteLine("Incompatible");
                        break;
                }
            }

            return new int[0, 0];
        }

        private int[,] FillByRandom()
        {
            Console.WriteLine("Enter matrix size");
            int size = int.Parse(Console.ReadLine());
            if (size > 1)
            {
                int[,] array = new int[size, size];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = _rnd.Next(-100,101);
                    }
                }
                return array;
            }

            return new int[0,0];
        }

        private int[,] FillByHand()
        {
            Console.WriteLine("Fill");
            int[] firstLine = Array.ConvertAll(Console.ReadLine().Trim().Split(), Convert.ToInt32);
            int[,] array = new int[firstLine.Length, firstLine.Length];
            for (int k = 0; k < array.GetLength(0); k++)
            {
                array[0, k] = firstLine[k];
            }

            for (int i = 1; i < array.GetLength(0); i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Trim().Split(), Convert.ToInt32);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = line[j];
                }
            }

            return array;
        }

        public void LogArray(int[,] array)
        {
            Console.WriteLine("-----");
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ",array[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----");
        }
    }
}