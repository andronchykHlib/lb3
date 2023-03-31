using System;
using System.Collections.Generic;
using System.Linq;

namespace LB3___matrices
{
    public class FourthBlock
    {
        private readonly ArrayFiller _af = new ArrayFiller();
        private readonly ColSortings _cs = new ColSortings();
        
        public void Task()
        { 
            int[,] array = _af.BuildArray();
            Dictionary<int[], int> compositionsData = new Dictionary<int[], int>();

            MakeCompositionsDictionary(array, compositionsData);
            var sortedCompositionsByValue = compositionsData.OrderBy(item => item.Value);
            SetSortedColumns(array, sortedCompositionsByValue);

            _af.LogArray(array);
            Console.WriteLine("Success. Sorted elements in given order");
        }

        private void MakeCompositionsDictionary(int[,] array, Dictionary<int[], int> dictionary)
        {
            for (int column = 0; column < array.GetLength(0); column++)
            {
                int[] colArray = _cs.BuildColArray(array, column);
                CalcComposition(colArray, dictionary, column);
            }
        }

        private void SetSortedColumns(int[,] array, IOrderedEnumerable<KeyValuePair<int[], int>> arrayIntDictionary)
        {
            for (int i = 0; i < arrayIntDictionary.Count(); i++)
            {
                KeyValuePair<int[], int> item = arrayIntDictionary.ElementAt(i);
                _cs.SetColumn(array, item.Key, i);
            }
        }

        private void CalcComposition(int[] array, Dictionary<int[],int> compositions, int columnIndex)
        {
            int comp = 1;
            Array.ForEach(array, i => comp *= i);
            compositions.Add(array, comp);
        }
    }
}