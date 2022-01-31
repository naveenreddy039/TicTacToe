using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            for(int i= 0; i < n; i++)
            {
                arr[i] = i;

            }
            Console.WriteLine(arr[i]);
            TicTacToeBoard board=new TicTacToeBoard();
        }
    }
}