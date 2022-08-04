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
                    try
                    {
                        Console.Clear();
                        Screen.printMatch(macth);


                        Console.Write("Origin: ");
                        Position origin = Screen.readChessPosition().toPosition();
                        macth.validOriginPosition(origin);

                        bool[,] possiblePositions = macth.board.Piece(origin).possibleMoves();

                        Console.Clear();
                        Screen.printBoard(macth.board, possiblePositions);

                        Console.Write("Destiny: ");
                        Position destiny = Screen.readChessPosition().toPosition();
                        macth.validDestinyposition(origin, destiny);

                        macth.makesMove(origin, destiny);
                    }
                    catch(BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Write("Press ENTER to try again: ");
                        Console.ReadLine();
                    }
                }

                
            }catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            
        }
        
    }
}
