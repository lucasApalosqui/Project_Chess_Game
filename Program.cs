using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess.PiecesChess;
using ChessGame.Chess;

namespace ChessGame
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                ChessMatch macth = new ChessMatch();
                while(macth.finish == false)
                {
                    Console.Clear();
                    Screen.printBoard(macth.board);

                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPosition().toPosition();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.readChessPosition().toPosition();

                    macth.performMoviment(origin, destiny);
                }

                
            }catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            
        }
        
    }
}
