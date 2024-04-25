using Chess.Scripts.Core;
using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    [SerializeField]
    private ChessBoardPlacementHandler chessBoardPlacementHandler;
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private HightlightHandler hightlightHandler;
    private ChessPlayerPlacementHandler chessPlayerPlacementHandler;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray ray = camera.ScreenPointToRay(mousePosition);

        RaycastHit hit;

        bool weHitSomething = Physics.Raycast(ray, out hit);

        if (weHitSomething)
        {
            GameObject hitObject = hit.transform.gameObject;

            if (hitObject != null)
            {
                chessPlayerPlacementHandler = hitObject.GetComponent<ChessPlayerPlacementHandler>();
            }

            if (hit.transform.tag == "Pawn")
            {
                hightlightHandler.Pawn(chessPlayerPlacementHandler);
            }
            else if (hit.transform.tag == "Rook")
            {
                hightlightHandler.Rook(chessPlayerPlacementHandler);
            }
            else if (hit.transform.tag == "Bishop")
            {
                hightlightHandler.Bishop(chessPlayerPlacementHandler);
            }
            else if (hit.transform.tag == "Knight")
            {
                hightlightHandler.Knight(chessPlayerPlacementHandler);
            }
            else if (hit.transform.tag == "King")
            {
                hightlightHandler.King(chessPlayerPlacementHandler);
            }
            else if (hit.transform.tag == "Queen")
            {
                hightlightHandler.Queen(chessPlayerPlacementHandler);
            }
        }
        else
        {
            chessBoardPlacementHandler.ClearHighlights();
        }
    }
}
