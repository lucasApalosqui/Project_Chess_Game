using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess.PiecesChess;

namespace ChessGame.Chess
{
    internal class ChessMatch
    {
        public Board board { get; private set; }
        public int turn { get; private set; }
        public Color actualPlayer { get; private set; }
        public bool finish { get; private set; }

        public ChessMatch()
        {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.Red;
            finish = false;
            putPieces();
        }

        public void performMoviment(Position origin, Position destiny)
        {
            Piece p = board.removePiece(origin);
            p.incrementMovesQuantity();
            Piece capturedPiece = board.removePiece(destiny);
            board.putPiece(p, destiny);
        }

        public void makesMove(Position origin, Position destiny)
        {
            performMoviment(origin, destiny);
            turn++;
            switchPlayer();
        }

        private void switchPlayer()
        {
            if(actualPlayer == Color.Red)
            {
                actualPlayer = Color.Blue;
            }
            else
            {
                actualPlayer = Color.Red;
            }
        }

        public void validOriginPosition(Position pos)
        {
            if(board.Piece(pos) == null)
            {
                throw new BoardException("there are no pieces in the indicated position of origin");
            }
            if(actualPlayer != board.Piece(pos).color)
            {
                throw new BoardException("Your pieces are " + actualPlayer);
            }
            if (!board.Piece(pos).possibleMovesExistis())
            {
                throw new BoardException("there are no possible moves for this piece");
            }
        }

        public void validDestinyposition(Position origin, Position destiny)
        {
            if (!board.Piece(origin).canMoveTo(destiny))
            {
                throw new BoardException("Destiny position is invalid!");
            }
        }

        private void putPieces()
        {
            board.putPiece(new Tower(Color.Blue, board), new PositionChess('a', 8).toPosition());
            board.putPiece(new Horse(Color.Blue, board), new PositionChess('b', 8).toPosition());
            board.putPiece(new Bishop(Color.Blue, board), new PositionChess('c', 8).toPosition());
            board.putPiece(new Queen(Color.Blue, board), new PositionChess('d', 8).toPosition());
            board.putPiece(new King(Color.Blue, board), new PositionChess('e', 8).toPosition());
            board.putPiece(new Bishop(Color.Blue, board), new PositionChess('f', 8).toPosition());
            board.putPiece(new Horse(Color.Blue, board), new PositionChess('g', 8).toPosition());
            board.putPiece(new Tower(Color.Blue, board), new PositionChess('h', 8).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('a', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('b', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('c', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('d', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('e', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('f', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('g', 7).toPosition());
            board.putPiece(new Pawn(Color.Blue, board), new PositionChess('h', 7).toPosition());

            board.putPiece(new Tower(Color.Red, board), new PositionChess('a', 1).toPosition());
            board.putPiece(new Horse(Color.Red, board), new PositionChess('b', 1).toPosition());
            board.putPiece(new Bishop(Color.Red, board), new PositionChess('c', 1).toPosition());
            board.putPiece(new Queen(Color.Red, board), new PositionChess('d', 1).toPosition());
            board.putPiece(new King(Color.Red, board), new PositionChess('e', 1).toPosition());
            board.putPiece(new Bishop(Color.Red, board), new PositionChess('f', 1).toPosition());
            board.putPiece(new Horse(Color.Red, board), new PositionChess('g', 1).toPosition());
            board.putPiece(new Tower(Color.Red, board), new PositionChess('h', 1).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('a', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('b', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('c', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('d', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('e', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('f', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('g', 2).toPosition());
            board.putPiece(new Pawn(Color.Red, board), new PositionChess('h', 2).toPosition());

        }
    }

  
}
