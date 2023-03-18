using System;

namespace LB3___matrices
{
    public class SecondBlock
    {
        private readonly ArrayFiller _af = new ArrayFiller();
        
        public void Task()
        { 
            int[,] array = _af.BuildArray();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int temp = array[i, array.GetLength(0) - 1 - i];
                array[i, array.GetLength(0) - 1 - i] = array[i, 0];
                array[i, 0] = temp;
            }
            
            _af.LogArray(array);
            Console.WriteLine("Success. Changed elements of first row with side diagonal elements");
        }
    }
}