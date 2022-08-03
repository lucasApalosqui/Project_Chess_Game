﻿using System;
using ChessGame.board;
using ChessGame.board.Enum;
using ChessGame.Chess.PiecesChess;

namespace ChessGame.Chess
{
    internal class ChessMatch
    {
        public Board board { get; private set; }
        private int turn;
        private Color actualPlayer;
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
