using System;

namespace LB3___matrices
{
    public class FirstBlock
    {
        private readonly ArrayFiller _af = new ArrayFiller();
        private const string SuccessMessage = "Found sum and elements of negative integers under main diagonal: ";

        public void Task()
        {
            int[,] array = _af.BuildArray();
            int sum = 0;
            int count = 0;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i,j] < 0)
                    {
                        sum += array[i,j];
                        count++;
                    }
                }
            }

            Console.WriteLine($"{SuccessMessage}\nsum is {sum}\ncount is {count}");
        }
    }
}