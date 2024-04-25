using Chess.Scripts.Core;
using UnityEngine;

public class HightlightHandler : MonoBehaviour
{
    [SerializeField]
    private ChessBoardPlacementHandler chessBoardPlacementHandler;
    [SerializeField]
    private ObstacleChecker obstacleChecker;

    #region Pawn
    public void Pawn(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        int row = chessPlayerPlacementHandler.row;
        int column = chessPlayerPlacementHandler.column;

        if (row + 1 <= 7)
        {
            if (obstacleChecker.CheckObstacle(row + 1, column + 1) && column + 1 <= 7)
            {
                obstacleChecker.CheckEnemy(row + 1, column + 1);
            }
            if (obstacleChecker.CheckObstacle(row + 1, column - 1) && column - 1 >= 0)
            {
                obstacleChecker.CheckEnemy(row + 1, column - 1);
            }
        }

        if (row == 1)
        {
            for (int i = 0; i < 2; i++)
            {
                if (obstacleChecker.CheckObstacle(row + 1, column))
                {
                    return;
                }
                chessBoardPlacementHandler.Highlight(row + 1, column);
                row++;
            }
        }
        else if (row + 1 <= 7)
        {
            if (obstacleChecker.CheckObstacle(row + 1, column))
            {
                return;
            }
            chessBoardPlacementHandler.Highlight(row + 1, column);
        }
    }
    #endregion

    #region Rook
    public void Rook(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        int row = chessPlayerPlacementHandler.row;
        int column = chessPlayerPlacementHandler.column;

        while (chessPlayerPlacementHandler.row + 1 <= 7) // Top
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column);
            chessPlayerPlacementHandler.row++;
        }

        chessPlayerPlacementHandler.row = row;

        while (chessPlayerPlacementHandler.row - 1 >= 0) // Bottom
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column);
            chessPlayerPlacementHandler.row--;
        }

        chessPlayerPlacementHandler.row = row;

        while (chessPlayerPlacementHandler.column + 1 <= 7) //Right 
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column + 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column + 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column + 1);
            chessPlayerPlacementHandler.column++;
        }

        chessPlayerPlacementHandler.column = column;

        while (chessPlayerPlacementHandler.column - 1 >= 0) //Left 
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column - 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column - 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row, chessPlayerPlacementHandler.column - 1);
            chessPlayerPlacementHandler.column--;
        }

        chessPlayerPlacementHandler.column = column;
    }
    #endregion

    #region Bishop
    public void Bishop(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        int row = chessPlayerPlacementHandler.row;
        int column = chessPlayerPlacementHandler.column;

        while (chessPlayerPlacementHandler.row + 1 <= 7 && chessPlayerPlacementHandler.column + 1 <= 7) // Top right diagonal
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column + 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column + 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column + 1);
            chessPlayerPlacementHandler.row++;
            chessPlayerPlacementHandler.column++;
        }

        chessPlayerPlacementHandler.row = row;
        chessPlayerPlacementHandler.column = column;

        while (chessPlayerPlacementHandler.row - 1 >= 0 && chessPlayerPlacementHandler.column - 1 >= 0) // Bottom left diagonal
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column - 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column - 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column - 1);
            chessPlayerPlacementHandler.row--;
            chessPlayerPlacementHandler.column--;
        }

        chessPlayerPlacementHandler.row = row;
        chessPlayerPlacementHandler.column = column;

        while (chessPlayerPlacementHandler.row - 1 >= 0 && chessPlayerPlacementHandler.column + 1 <= 7) // Bottom right diagonal
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column + 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column + 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row - 1, chessPlayerPlacementHandler.column + 1);
            chessPlayerPlacementHandler.row--;
            chessPlayerPlacementHandler.column++;
        }

        chessPlayerPlacementHandler.row = row;
        chessPlayerPlacementHandler.column = column;

        while (chessPlayerPlacementHandler.row + 1 <= 7 && chessPlayerPlacementHandler.column - 1 >= 0) // Top left diagonal
        {
            if (obstacleChecker.CheckObstacle(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column - 1))
            {
                obstacleChecker.CheckEnemy(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column - 1);
                break;
            }
            chessBoardPlacementHandler.Highlight(chessPlayerPlacementHandler.row + 1, chessPlayerPlacementHandler.column - 1);
            chessPlayerPlacementHandler.row++;
            chessPlayerPlacementHandler.column--;
        }

        chessPlayerPlacementHandler.row = row;
        chessPlayerPlacementHandler.column = column;
    }
    #endregion

    #region Knight
    public void Knight(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        int row = chessPlayerPlacementHandler.row;
        int column = chessPlayerPlacementHandler.column;
        if (row + 2 <= 7) // Top
        {
            if ((column + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 2, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row + 2, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 2, column + 1))
            {
                obstacleChecker.CheckEnemy(row + 2, column + 1);
            }

            if ((column - 1 >= 0) && !obstacleChecker.CheckObstacle(row + 2, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row + 2, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 2, column - 1))
            {
                obstacleChecker.CheckEnemy(row + 2, column - 1);
            }
        }
        if (row - 2 >= 0) // Bottom
        {
            if ((column + 1 <= 7) && !obstacleChecker.CheckObstacle(row - 2, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row - 2, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 2, column + 1))
            {
                obstacleChecker.CheckEnemy(row - 2, column + 1);
            }

            if ((column - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 2, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row - 2, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 2, column - 1))
            {
                obstacleChecker.CheckEnemy(row - 2, column - 1);
            }
        }
        if (column + 2 <= 7) // Right
        {
            if ((row + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 1, column + 2))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column + 2);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column + 2))
            {
                obstacleChecker.CheckEnemy(row + 1, column + 2);
            }

            if ((row - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 1, column + 2))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column + 2);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column + 2))
            {
                obstacleChecker.CheckEnemy(row - 1, column + 2);
            }
        }
        if (column - 2 >= 0) // Left
        {
            if ((row + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 1, column - 2))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column - 2);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column - 2))
            {
                obstacleChecker.CheckEnemy(row + 1, column - 2);
            }

            if ((row - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 1, column - 2))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column - 2);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column - 2))
            {
                obstacleChecker.CheckEnemy(row - 1, column - 2);
            }
        }
    }
    #endregion

    #region King
    public void King(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        int row = chessPlayerPlacementHandler.row;
        int column = chessPlayerPlacementHandler.column;
        if (row + 1 <= 7) // Top
        {
            if (!obstacleChecker.CheckObstacle(row + 1, column))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column))
            {
                obstacleChecker.CheckEnemy(row + 1, column);
            }

            if ((column + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 1, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column + 1))
            {
                obstacleChecker.CheckEnemy(row + 1, column + 1);
            }

            if ((column - 1 >= 0) && !obstacleChecker.CheckObstacle(row + 1, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column - 1))
            {
                obstacleChecker.CheckEnemy(row + 1, column - 1);
            }
        }
        if (row - 1 >= 0) // Bottom
        {
            if (!obstacleChecker.CheckObstacle(row - 1, column))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column))
            {
                obstacleChecker.CheckEnemy(row - 1, column);
            }

            if ((column + 1 <= 7) && !obstacleChecker.CheckObstacle(row - 1, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column + 1))
            {
                obstacleChecker.CheckEnemy(row - 1, column + 1);
            }

            if ((column - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 1, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column - 1))
            {
                obstacleChecker.CheckEnemy(row - 1, column - 1);
            }
        }
        if (column + 1 <= 7) // Right
        {
            if (!obstacleChecker.CheckObstacle(row, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row, column + 1))
            {
                obstacleChecker.CheckEnemy(row, column + 1);
            }

            if ((row + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 1, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column + 1))
            {
                obstacleChecker.CheckEnemy(row + 1, column + 1);
            }

            if ((row - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 1, column + 1))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column + 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column + 1))
            {
                obstacleChecker.CheckEnemy(row - 1, column + 1);
            }
        }
        if (column - 1 >= 0) // Left
        {
            if (!obstacleChecker.CheckObstacle(row, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row, column - 1))
            {
                obstacleChecker.CheckEnemy(row, column - 1);
            }

            if ((row + 1 <= 7) && !obstacleChecker.CheckObstacle(row + 1, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row + 1, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row + 1, column - 1))
            {
                obstacleChecker.CheckEnemy(row + 1, column - 1);
            }

            if ((row - 1 >= 0) && !obstacleChecker.CheckObstacle(row - 1, column - 1))
            {
                chessBoardPlacementHandler.Highlight(row - 1, column - 1);
            }
            else if (obstacleChecker.CheckObstacle(row - 1, column - 1))
            {
                obstacleChecker.CheckEnemy(row - 1, column - 1);
            }
        }
    }
    #endregion

    #region Queen
    public void Queen(ChessPlayerPlacementHandler chessPlayerPlacementHandler)
    {
        Bishop(chessPlayerPlacementHandler);
        Rook(chessPlayerPlacementHandler);
    }
    #endregion
}