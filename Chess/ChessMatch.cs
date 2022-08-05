using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess.PiecesChess;
using System.Collections.Generic;

namespace ChessGame.Chess
{
    internal class ChessMatch
    {
        public Board board { get; private set; }
        public int turn { get; private set; }
        public Color actualPlayer { get; private set; }
        public bool finish { get; private set; }
        public bool xeque { get; private set; }
        private HashSet<Piece> pieces;
        private HashSet<Piece> captures;

        public ChessMatch()
        {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.Red;
            xeque = false;
            finish = false;
            pieces = new HashSet<Piece>();
            captures = new HashSet<Piece>();
            putPieces();
        }

        public Piece performMoviment(Position origin, Position destiny)
        {
            Piece p = board.removePiece(origin);
            p.incrementMovesQuantity();
            Piece capturedPiece = board.removePiece(destiny);
            board.putPiece(p, destiny);
            if(capturedPiece != null)
            {
                captures.Add(capturedPiece);
            }
            return capturedPiece;
        }

        public void makesMove(Position origin, Position destiny)
        {
            Piece capturedPiece = performMoviment(origin, destiny);
            if (isinXeque(actualPlayer))
            {
                unmakeMove(origin, destiny, capturedPiece);
                throw new BoardException("you can't put yourself in check!");
            }

            if(isinXeque(adversary(actualPlayer)))
            {
                xeque = true;
            }
            else
            {
                xeque = false;
            }

            if (isXequeMate(adversary(actualPlayer)))
            {
                finish = true;
            }
            else
            {
                turn++;
                switchPlayer();
            }

           
        }

        private void unmakeMove(Position origin, Position destiny, Piece capturedPiece)
        {
            Piece p = board.removePiece(destiny);
            p.decrementMovesQuantity();
            if (capturedPiece != null)
            {
                board.putPiece(capturedPiece, destiny);
                captures.Remove(capturedPiece);
            }
            board.putPiece(p, origin);
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

        public HashSet<Piece> capturedPieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach(Piece p in captures)
            {
                if(p.color == color)
                {
                    aux.Add(p);
                }
            }
            return aux;
        }

        public HashSet<Piece> piecesInGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece p in pieces)
            {
                if (p.color == color)
                {
                    aux.Add(p);
                }
            }
            aux.ExceptWith(capturedPieces(color));
            return aux;
        }

        private Color adversary(Color color)
        {
            if (color == Color.Red)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Red;
            }
        }

        private Piece king(Color color)
        {
            foreach(Piece x in piecesInGame(color))
            {
                if(x is King)
                {
                    return x;
                }
            }
            return null;
        }

        public bool isinXeque(Color color)
        {
            Piece K = king(color);
            if (K == null)
            {
                throw new BoardException("There´s no King with " + color + " color in Board");
            }
            foreach(Piece x in piecesInGame(adversary(color)))
            {
                bool[,] mat = x.possibleMoves();
                if (mat[K.position.row, K.position.column])
                {
                    return true;
                }
            }
            return false;
        }

        public bool isXequeMate(Color color)
        {
            if (!isinXeque(color))
            {
                return false;
            }
            foreach(Piece x in piecesInGame(color))
            {
                bool[,] mat = x.possibleMoves();
                for (int r = 0; r < board.rows; r++)
                {
                    for(int c = 0; c < board.columns; c++)
                    {
                        if (mat[r, c])
                        {
                            Position origin = x.position;
                            Position destiny = new Position(r, c);
                            Piece capturedPiece = performMoviment(x.position, destiny);
                            bool xequeTest = isinXeque(color);
                            unmakeMove(origin, destiny, capturedPiece);
                            if (!xequeTest)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void putNewPiece(char column, int row, Piece piece)
        {
            board.putPiece(piece, new PositionChess(column, row).toPosition());
            pieces.Add(piece);
        }

        private void putPieces()
        {
            putNewPiece('a', 8, new Tower(Color.Blue, board));
            putNewPiece('b', 8, new Horse(Color.Blue, board));
            putNewPiece('c', 8, new Bishop(Color.Blue, board));
            putNewPiece('d', 8, new Queen(Color.Blue, board));
            putNewPiece('e', 8, new King(Color.Blue, board));
            putNewPiece('f', 8, new Bishop(Color.Blue, board));
            putNewPiece('g', 8, new Horse(Color.Blue, board));
            putNewPiece('h', 8, new Tower(Color.Blue, board));
            putNewPiece('a', 7, new Pawn(Color.Blue, board));
            putNewPiece('b', 7, new Pawn(Color.Blue, board));
            putNewPiece('c', 7, new Pawn(Color.Blue, board));
            putNewPiece('d', 7, new Pawn(Color.Blue, board));
            putNewPiece('e', 7, new Pawn(Color.Blue, board));
            putNewPiece('f', 7, new Pawn(Color.Blue, board));
            putNewPiece('g', 7, new Pawn(Color.Blue, board));
            putNewPiece('h', 7, new Pawn(Color.Blue, board));


            putNewPiece('a', 1, new Tower(Color.Red, board));
            putNewPiece('b', 1, new Horse(Color.Red, board));
            putNewPiece('c', 1, new Bishop(Color.Red, board));
            putNewPiece('d', 1, new Queen(Color.Red, board));
            putNewPiece('e', 1, new King(Color.Red, board));
            putNewPiece('f', 1, new Bishop(Color.Red, board));
            putNewPiece('g', 1, new Horse(Color.Red, board));
            putNewPiece('h', 1, new Tower(Color.Red, board));
            putNewPiece('a', 2, new Pawn(Color.Red, board));
            putNewPiece('b', 2, new Pawn(Color.Red, board));
            putNewPiece('c', 2, new Pawn(Color.Red, board));
            putNewPiece('d', 2, new Pawn(Color.Red, board));
            putNewPiece('e', 2, new Pawn(Color.Red, board));
            putNewPiece('f', 2, new Pawn(Color.Red, board));
            putNewPiece('g', 2, new Pawn(Color.Red, board));
            putNewPiece('h', 2, new Pawn(Color.Red, board));


        }
    }

  
}
