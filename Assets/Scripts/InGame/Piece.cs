using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int pieceNum;
    public Board board;
    int boardNum = 0;
    Transform[] boardPos;
    IEnumerator MoveEffect(int moveNum)
    {
        boardPos = board.boardPos;
        Vector3 NewPos = new Vector3(boardPos[boardNum].transform.position.x,boardPos[boardNum].transform.position.y, -1);
        Vector3 OriginPos = this.transform.position;
        while(Vector3.Distance(transform.position,NewPos) > 0.05f )
        {
            transform.position = Vector3.Lerp(OriginPos,NewPos,1f);
            yield return new WaitForSeconds(1f);
        }
    }

    void Start()
    {
        boardPos = board.boardPos;
        transform.position = new Vector3(boardPos[boardNum].transform.position.x, boardPos[boardNum].transform.position.y, -1);
    }

    public void MovePiecePos(int moveNum)
    {
        boardNum += moveNum;
        if(boardNum >= 11)
        {
            boardNum = 11;
            Debug.Log("Game End");
        }
        StartCoroutine(MoveEffect(moveNum));

    }
}
