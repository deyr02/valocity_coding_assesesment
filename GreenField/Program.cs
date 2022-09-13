using System;

namespace GreenField
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.ShaffleCards();
            board.DistributeCards();
            board.PrintBoard();
        }
    }
}
