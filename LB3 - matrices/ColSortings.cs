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