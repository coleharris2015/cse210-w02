using System;
using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> board = new List<char>{'1', '2', '3'};
            
            //Display baord 
            DisplayBoard(board);

            //Get input

            //

            board[0] = 'x';
            DisplayBoard(board);
        }
    }
}

static void DisplayBoard(List<char> board)
{
    Console.WriteLine(board[0] + "|" + board[2]);
}