using Chess.Scripts.Core;
using UnityEngine;

public class ObstacleChecker : MonoBehaviour
{
    private ChessPlayerPlacementHandler chessPlayerPlacementHandler;
    private Transform child;


    public bool CheckObstacle(int receivedRow, int receivedColumn)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            child = transform.GetChild(i);

            chessPlayerPlacementHandler = child.GetComponent<ChessPlayerPlacementHandler>();

            if (receivedRow == chessPlayerPlacementHandler.row && receivedColumn == chessPlayerPlacementHandler.column)
            {
                return true;
            }
        }
        return false;
    }
}