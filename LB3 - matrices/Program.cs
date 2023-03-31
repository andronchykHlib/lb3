using System;

namespace LB3___matrices
{
    internal class Program
    {
        private static readonly FirstBlock _firstBlock = new FirstBlock();
        private static readonly SecondBlock _secondBlock = new SecondBlock();
        private static readonly ThirdBlock _thirdBlock = new ThirdBlock();
        private static readonly FourthBlock _fourthBlock = new FourthBlock();

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Enter number of task you want to check\n\t1-First block\n\t2-Second block\n\t3-Third block\n\t4-Fourth block\n\t0-Exit");
            int task = Int32.MaxValue;
            while (task != 0)
            {
                task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        Console.WriteLine("First block...");
                        _firstBlock.Task();
                        return;
                    case 2:
                        Console.WriteLine("Second block...");
                        _secondBlock.Task();
                        return;
                    case 3:
                        Console.WriteLine("Third block...");
                        _thirdBlock.Task();
                        return;
                    case 4:
                        Console.WriteLine("Fourth block...");
                        _fourthBlock.Task();
                        return;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
                        break;
                }
            }
        }
    }
}