using System;

namespace LB3___matrices
{
    public class ColSortings
    {
        public int[] BuildColArray(int[,] array, int column)
        {
            int length = array.GetLength(0);
            int[] result = new int[length];
            int row = 0;

            for (int k = 0; k < result.Length; k++)
            {
                result[k] = array[row,column];
                row++;
            }
            
            return result;
        }

        public void IncSort(int[] colArray)
        {
            for (int i = 0; i < colArray.Length - 1; i++)
            {
                for (int j = 0; j < colArray.Length - i - 1; j++)
                {
                    if (colArray[j] > colArray[j + 1])
                    {
                        int temp = colArray[j];
                        colArray[j] = colArray[j + 1];
                        colArray[j + 1] = temp;
                    }
                }
            }
        }

        public void DecSort(int[] colArray)
        {
            for (int i = 0; i < colArray.Length - 1; i++)
            {
                for (int j = 0; j < colArray.Length - i - 1; j++)
                {
                    if (colArray[j] < colArray[j + 1])
                    {
                        int temp = colArray[j];
                        colArray[j] = colArray[j + 1];
                        colArray[j + 1] = temp;
                    }
                }
            }
        }

        public void SetColumn(int[,] array, int[] colArray, int currentColumnIndex)
        {
            int row = 0;
            for (int i = 0; i < colArray.Length; i++)
            {
                array[row, currentColumnIndex] = colArray[i];
                row++;
            }
        }
    }
}