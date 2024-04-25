using Chess.Scripts.Core;
using UnityEngine;

public class ObstacleChecker : MonoBehaviour
{
    [SerializeField]
    private ChessBoardPlacementHandler chessBoardPlacementHandler;
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

    public void CheckEnemy(int receivedRow, int receivedColumn)
    {
        if (child.transform.tag == "Enemy")
        {
            chessBoardPlacementHandler.HighlightRed(receivedRow, receivedColumn);
        }
    }
}