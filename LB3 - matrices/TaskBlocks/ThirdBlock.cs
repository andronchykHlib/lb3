using System;

namespace LB3___matrices
{
    public class ThirdBlock
    {
        private readonly ArrayFiller _af = new ArrayFiller();

        public void Task()
        {
            int[,] array = _af.BuildArray();

            for (int column = 0; column < array.GetLength(1); column ++)
            {
                if (column % 2 == 0)
                {
                    DescSort(array, column);
                    continue;
                }
                AscSort(array, column);
            }
            
            _af.LogArray(array);
            Console.WriteLine("Success. Sorted elements in given order");
        }

        private void AscSort(int[,] array, int column)
        {
            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int k = 0; k < array.GetLength(0) - row - 1; k++)
                {
                    if (array[k, column] > array[k + 1, column])
                    {
                        (array[k, column], array[k + 1, column]) = (array[k + 1, column], array[k, column]);
                    }
                }
            }
        }

        private void DescSort(int[,] array, int column)
        {
            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int k = 0; k < array.GetLength(0) - row - 1; k++)
                {
                    if (array[k, column] < array[k + 1, column])
                    {
                        (array[k, column], array[k + 1, column]) = (array[k + 1, column], array[k, column]);
                    }
                }
            }
        }
    }
}