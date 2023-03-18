using System;

namespace LB3___matrices
{
    public class ThirdBlock
    {
        private readonly ArrayFiller _af = new ArrayFiller();
        private readonly ColSortings _cs = new ColSortings();
        
        public void Task()
        { 
            int[,] array = _af.BuildArray();
            for (int column = 0; column < array.GetLength(0); column++)
            {
                int[] colArray = _cs.BuildColArray(array, column);
                if (column % 2 == 0)
                {
                    _cs.DecSort(ref colArray);
                    _cs.SetSortedColumn(ref array, colArray, column);
                    continue;
                }
                _cs.IncSort(ref colArray);
                _cs.SetSortedColumn(ref array, colArray, column);
            }

            _af.LogArray(array);
            Console.WriteLine("Success. Sorted elements in given order");
        }
    }
}